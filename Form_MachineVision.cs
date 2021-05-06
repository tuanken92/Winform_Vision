using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Vision.Source;



namespace Winform_Vision
{

    public partial class Vision : Form
    {
        ShowDateTime showDateTimeManager;
        SerialPortManager serialPortManager;

        SocketServer socketServerManager;
        SocketClient socketClientManager;
        FrameCapture frameCaptureManager;
        Basler_Camera basler_camera;
        public Vision()
        {
            InitializeComponent();

            showDateTimeManager = new ShowDateTime(timer_Datetime, label_DateTime);
            serialPortManager = new SerialPortManager(button_COM_Connect,
                                                      button_COM_Send,
                                                      comboBox_ListComPort,
                                                      listBox_COM_Log,
                                                      listBox_COM_Receive,
                                                      textBox_COM_Data2Send);

            socketServerManager = new SocketServer(textBox_Server_Port,
                                                   textBox_Server_Ip,
                                                   textBox_Server_Send,
                                                   button_Server_Open,
                                                   button_Server_Send,
                                                   listBox_Server_Receive);

            socketClientManager = new SocketClient(textBox_Client_Port,
                                                   textBox_Client_Ip,
                                                   textBox_Client_Send,
                                                   button_Client_Connect,
                                                   button_Client_Send,
                                                   listBox_Client_Receive);




            frameCaptureManager = new FrameCapture(listBox_Camera_Log, pictureBox_Frame_Camera, textBox_Cam_URL, button_Camera_Connect);


            basler_camera = new Basler_Camera();


#if AUTO_RESIZE
            _form_resize = new clsResize(this); //I put this after the initialize event to be sure that all controls are initialized properly
            this.Load += new EventHandler(_Load); //This will be called after the initialization // form_load
            this.Resize += new EventHandler(_Resize); //form_resize
#endif
        }

        ~Vision()
        {
            Console.WriteLine("Vision destroy.....");
        }

        static bool isPressBasler = false;
        private void button_Test_Cam_Basler_Click(object sender, EventArgs e)
        {
            if(!isPressBasler)
            {
                Console.WriteLine("Press basler");
                basler_camera.Enable_run = true;
                basler_camera.Device_Removal_Handling();
                isPressBasler = true;
            }
            else
            {
                Console.WriteLine("Stop basler");
                basler_camera.Enable_run = false;
                isPressBasler = false;

            }
        }



#if AUTO_RESIZE
        clsResize _form_resize;
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
#endif
    }
}
