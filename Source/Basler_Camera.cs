using Basler.Pylon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Vision.Source
{
    public class Basler_Camera
    {
        private Camera camera;
        private bool enable_run;
        // Time to wait for the user to disconnect the camera device.
        const int cTimeOutMs = 60000;

        
        public Basler_Camera()
        {
            Console.WriteLine("Basler_Camera has been called.");
            camera = new Camera();
            Enable_run = true;

        }

        ~Basler_Camera()
        {
            camera.Dispose();
            Console.WriteLine("~Basler_Camera has been called.");
        }

        public bool Enable_run { get => enable_run; set => enable_run = value; }

        // Event handler for connection loss, is shown here for demonstration purposes only.
        // Note: This event is always called on a separate thread.
        static void OnConnectionLost(Object sender, EventArgs e)
        {
            // For demonstration purposes, print a message.
            Console.WriteLine("OnConnectionLost has been called.");
        }

        void Run_loop()
        {
            // Start the timeout timer.
            Console.WriteLine("Please disconnect the device. (Timeout {0}s)", cTimeOutMs / 1000.0);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Grab and display images until timeout.
            while (enable_run && camera.StreamGrabber.IsGrabbing && stopWatch.ElapsedMilliseconds < cTimeOutMs)
            {
                try
                {
                    // Wait for an image and then retrieve it. A timeout of 10000 ms is used.
                    IGrabResult grabResult = camera.StreamGrabber.RetrieveResult(10000, TimeoutHandling.ThrowException);
                    using (grabResult)
                    {
                        // Image grabbed successfully?
                        if (grabResult.GrabSucceeded)
                        {
                            // Display the grabbed image.
                            ImageWindow.DisplayImage(0, grabResult);
                        }
                    }
                }
                catch (Exception)
                {
                    // An exception occurred. Is it because the camera device has been physically removed?

                    // Known issue: Wait until the system safely detects a possible removal.
                    System.Threading.Thread.Sleep(1000);

                    if (!camera.IsConnected)
                    {
                        // Yes, the camera device has been physically removed.
                        Console.WriteLine("The camera device has been removed. Please reconnect. (Timeout {0}s)", cTimeOutMs / 1000.0);

                        // Close the camera object to close underlying resources used for the previous connection.
                        camera.Close();

                        // Try to re-establish a connection to the camera device until timeout.
                        // Reopening the camera triggers the above registered Configuration.AcquireContinuous.
                        // Therefore, the camera is parameterized correctly again.
                        camera.Open(cTimeOutMs, TimeoutHandling.ThrowException);

                        // Due to unplugging the camera, settings have changed, e.g. the heartbeat timeout value for GigE cameras.
                        // After the camera has been reconnected, all settings must be restored. This can be done in the CameraOpened
                        // event as shown for the Configuration.AcquireContinuous.
                        camera.Parameters[PLTransportLayer.HeartbeatTimeout].TrySetValue(1000, IntegerValueCorrection.Nearest);

                        // Restart grabbing.
                        camera.StreamGrabber.Start();

                        // Restart the timeout timer.
                        Console.WriteLine("Camera reconnected. You may disconnect the camera device again (Timeout {0}s)", cTimeOutMs / 1000.0);
                        stopWatch.Restart();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
        public void Device_Removal_Handling()
        {
            

            try
            {
                // Create a camera object that selects the first camera device found.
                // More constructors are available for selecting a specific camera device.
                
                {
                    // Print the model name of the camera.
                    Console.WriteLine("Using camera {0}.", camera.CameraInfo[CameraInfoKey.ModelName]);

                    // Set the acquisition mode to free running continuous acquisition when the camera is opened.
                    camera.CameraOpened += Configuration.AcquireContinuous;

                    // For demonstration purposes, only add an event handler for connection loss.
                    camera.ConnectionLost += OnConnectionLost;

                    // Open the connection to the camera device.
                    camera.Open();

                    ///////////////// Don't single step beyond this line when using GigE cameras (see comments above) ///////////////////////////////
                    // Before testing the callbacks, we manually set the heartbeat timeout to a short value when using GigE cameras.
                    // For debug versions, the heartbeat timeout has been set to 5 minutes, so it would take up to 5 minutes
                    // until device removal is detected.
                    camera.Parameters[PLTransportLayer.HeartbeatTimeout].TrySetValue(1000, IntegerValueCorrection.Nearest);  // 1000 ms timeout

                    // Start the grabbing.
                    camera.StreamGrabber.Start();

                    Thread run_camera = new Thread(Run_loop);
                    run_camera.Start();

                    Console.WriteLine("finish grap camera");
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Exception: {0}", e.Message);
                
            }
            finally
            {
                // Comment the following two lines to disable waiting on exit.
                Console.Error.WriteLine("\nPress enter to exit.");
            }

        }
    }
}
