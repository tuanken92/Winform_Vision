using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

        TCP_Client tcp_client;


        //variable data
        All_Parameter param;


        void test_save_json()
        {
            //init list
            param.list_cam = new List<CameraPrameter>();
            param.list_comport = new List<ComportParameter>();
            param.list_socket_client = new List<SocketParameter>();

            for (int i = 1; i < 5; i++)
            {
                CameraPrameter cam_param = new CameraPrameter(i);
                ComportParameter com_param = new ComportParameter(i);
                SocketParameter socket_param = new SocketParameter(i);

                param.list_cam.Add(cam_param);
                param.list_comport.Add(com_param);
                param.list_socket_client.Add(socket_param);
            }

            //to json
            JsonSerializer serializer = new JsonSerializer();

            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"E:\json.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, param);
            }
        }


        void test_load_json()
        {
        }

        public Vision()
        {
            InitializeComponent();

            showDateTimeManager = new ShowDateTime(timer_Datetime, label_DateTime);
            serialPortManager = new SerialPortManager(button_COM_Connect,
                                                      button_COM_Send,
                                                      comboBox_ListComPort,
                                                      listBox_COM_Log,
                                                      listBox_COM_Receive,
                                                      textBox_COM_Data2Send,
                                                      label_Comport_status);

            socketServerManager = new SocketServer(textBox_Server_Port,
                                                   textBox_Server_Ip,
                                                   textBox_Server_Send,
                                                   button_Server_Open,
                                                   button_Server_Send,
                                                   listBox_Server_Receive);

            /*socketClientManager = new SocketClient(textBox_Client_Ip,
                                                   textBox_Client_Port,
                                                   textBox_Client_Send,
                                                   button_Client_Connect,
                                                   button_Client_Send,
                                                   listBox_Client_Receive);*/

            tcp_client = new TCP_Client(textBox_Client_Ip,
                                                   textBox_Client_Port,
                                                   textBox_Client_Send,
                                                   button_Client_Connect,
                                                   button_Client_Send,
                                                   listBox_Client_Receive);


            frameCaptureManager = new FrameCapture(listBox_Camera_Log, pictureBox_Frame_Camera, textBox_Cam_URL, button_Camera_Connect);


            basler_camera = new Basler_Camera();

            //test_save_json();
            test_load_json();
            /*Thread print_com = new Thread(print_data_comport);
            print_com.Name = "Print_data_comport";
            print_com.IsBackground = true;
            print_com.Start();*/

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


        void print_data_comport()
        {
            while(true)
            {
                Thread.Sleep(1000);
                
                if(serialPortManager != null && serialPortManager.DataReceived != null)
                {
                    Console.WriteLine($"data comport = {serialPortManager.DataReceived.ToString()}");
                    serialPortManager.DataReceived = null;
                }
                
            }
        }

        private void tabControl_Main_Click(object sender, EventArgs e)
        {
            switch (tabControl_Main.SelectedIndex)
            {
                case (int)TabControlIndex.TabControl.Tab_Auto:
                    Console.WriteLine("Tab Auto");
                    break;
                case (int)TabControlIndex.TabControl.Tab_Manual:
                    Console.WriteLine("Tab Manul");
                    break;
                case (int)TabControlIndex.TabControl.Tab_COM:
                    Console.WriteLine("Tab COM");
                    break;
                case (int)TabControlIndex.TabControl.Tab_Socket:
                    Console.WriteLine("Tab Socket");
                    break;
                case (int)TabControlIndex.TabControl.Tab_Camera:
                    Console.WriteLine("Tab Camera");
                    break;
                case (int)TabControlIndex.TabControl.Tab_Setting:
                    Console.WriteLine("Tab Setting");
                    break;
                case (int)TabControlIndex.TabControl.Tab_Log:
                    Console.WriteLine("Tab Log");
                    break;
                case (int)TabControlIndex.TabControl.Tab_Help:
                    Console.WriteLine("Tab Help");
                    break;
                case (int)TabControlIndex.TabControl.Tab_About:
                    Console.WriteLine("Tab About");
                    break;
            }
        }

        private void Vision_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Vision_FormClosing ....");
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
