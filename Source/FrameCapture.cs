using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Winform_Vision.Source
{
    public class FrameCapture :  Form
    {
        private readonly VideoCapture capture;




        ListBox logCamera;
        PictureBox displayCamera;
        TextBox urlCamera;
        Button playCamera;

        public FrameCapture(ListBox logCamera,
                            PictureBox displayCamera,
                            TextBox urlCamera,
                            Button playCamera)
        {
            this.logCamera = logCamera;
            this.displayCamera = displayCamera;
            this.urlCamera = urlCamera;
            this.playCamera = playCamera;

            this.playCamera.Click += PlayCamera_Click;

            capture = new VideoCapture();

            
        }

        void LiveCam()
        {
            while(capture.IsOpened())
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    var frameBitmap = BitmapConverter.ToBitmap(frameMat);
                    displayCamera.Image?.Dispose();
                    displayCamera.Image = frameBitmap;
                    Thread.Sleep(10);
                }
            }

            Console.WriteLine("LiveCam end");
        }

        ~FrameCapture()
        {
            
            capture.Dispose();
            Console.WriteLine("~FrameCapture ...");
        }
        private void PlayCamera_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Play camera");
            capture.Open(0, VideoCaptureAPIs.ANY);
            capture.FrameWidth = 1920;
            capture.FrameHeight = 1080;
            capture.Fps = 25;
            if (capture.IsOpened())
            {
                Thread ThreadLiveCam = new Thread(LiveCam);
                ThreadLiveCam.IsBackground = true;
                ThreadLiveCam.Start();
            }
            Console.WriteLine("Frame width = {0}, frame height = {1}", capture.FrameWidth, capture.FrameHeight);
        }
    }
}
