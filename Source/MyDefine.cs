using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
namespace Winform_Vision.Source
{
    public class CameraPrameter
    {
        public enum EFlipFrame
        {
            Flip_None = 0,
            Flip_X,
            Flip_Y,
            Flip_XY
        }
        public enum ETypeCamera
        {
            Cam_Webcam = 0,
            Cam_IP,
            Cam_Basler_Gig,
            Cam_Basler_USB,
            Cam_Cognex_Gig,
            Cam_Cognex_USB,
            Cam_IMI_Teach,
            Cam_DMK_Gig
        }

        public enum EFormatCamera
        {
            MONO = 0,
            COLOR
        }

        
        private bool _use_calib;
        private bool _is_support;
        private string _name;
        private string _calib_file;
        private uint _fps;
        private Rect _roi;
        private ETypeCamera _type_camera;
        private EFlipFrame _flip;
        private EFormatCamera _format;

        //name of camera
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                    _name = value;
            }
        }

        //type of camera
        public ETypeCamera Type_Camera
        {
            get { return _type_camera; }
            set
            {
                if (value != _type_camera)
                    _type_camera = value;
            }
        }


        //roi of camera
        public Rect Roi
        {
            get { return _roi; }
            set
            {
                if (value != _roi)
                    _roi = value;
            }
        }


        //fps of camera
        public uint Fps
        {
            get { return _fps; }
            set
            {
                if (value != _fps)
                    _fps = value;
            }
        }


        //flip of camera
        public EFlipFrame Flip
        {
            get { return _flip; }
            set
            {
                if (value != _flip)
                    _flip = value;
            }
        }


        //format of camera: is mono or color
        public EFormatCamera Format
        {
            get { return _format; }
            set
            {
                if (value != _format)
                    _format = value;
            }
        }


        //is enable calib
        public bool Use_calib { get => _use_calib; set => _use_calib = value; }


        //calibration
        public string Calib_file
        {
            get { return _calib_file; }
            set
            {
                //need check file exist
                if(File.Exists(value))
                {
                    if (value != _calib_file)
                        _calib_file = value;
                }
                else
                {
                    //MessageBox.Show($"File calibration {value} not exist !");
                    Console.WriteLine($"File calibration {value} not exist !");
                }
            }
        }

        public bool Is_support { get => _is_support; set => _is_support = value; }
        

        public void Print_Infor()
        {
            Console.WriteLine("*****************Camera Parameter begin*****************");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Type = {Type_Camera}");
            Console.WriteLine($"Format = {Format}");
            Console.WriteLine($"Is support = {Is_support}");
            Console.WriteLine($"Roi = {Roi.ToString()}");
            Console.WriteLine($"FPS = {Fps}");
            Console.WriteLine($"Flip = {Flip}");
            Console.WriteLine($"Use Calibration = {Use_calib}");
            Console.WriteLine($"File Calibration = {Calib_file}");
            Console.WriteLine("*****************Camera Parameter end*****************");
        }
        public CameraPrameter()
        {
            Console.WriteLine("CameraPrameter create");
            Name = "camera_name";
            Is_support = true;
            Type_Camera = ETypeCamera.Cam_Webcam;
            Roi = new Rect(0, 0, 1920, 1080);
            Fps = 25;
            Flip = EFlipFrame.Flip_None;
            Use_calib = false;
            Calib_file = "";
            Print_Infor();
        }


        public CameraPrameter(int i)
        {
            Console.WriteLine("CameraPrameter create {0}",i);
            Name = $"Camera_{i}";
            Type_Camera = ETypeCamera.Cam_Webcam;
            Roi = new Rect(0, 0, 1920, 1080);
            Fps = 25;
            Flip = EFlipFrame.Flip_None;
            Use_calib = false;
            Calib_file = "";
            Print_Infor();
        }




        ~CameraPrameter()
        {
            Console.WriteLine("CameraPrameter destroy");
        }
    }


    public class ComportParameter
    {
        private string _name;
        private string _port_name;
        private UInt32 _baudrate;
        private UInt32[] list_baudrate = { 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                    _name = value;
            }
        }


        public string Port_name
        {
            get { return _port_name; }
            set
            {
                value = value.ToUpper();
                if (value != _port_name)
                    _port_name = value;
            }
        }

        public UInt32 Baudrate
        {
            get { return _baudrate; }
            set
            {
                if (value != _baudrate && Array.IndexOf(list_baudrate, value) != -1)
                    _baudrate = value;
                else
                    _baudrate = 9600;
            }
        }

        public void Print_Info()
        {
            Console.WriteLine("*****************Comport Parameter begin*****************");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"ComPort Name = {Port_name}");
            Console.WriteLine($"Baudrate = {Baudrate}");
            Console.WriteLine("*****************Comport Parameter end*****************");
        }

        public ComportParameter()
        {
            this.Name = "demo_comport";
            this.Baudrate = 9600;
            this.Port_name = "COM1";

            Print_Info();
        }

        public ComportParameter(int i)
        {
            this.Name = $"demo_comport_{i}";
            this.Baudrate = 9600;
            this.Port_name = "COM1";

            Print_Info();
        }

        ~ComportParameter()
        {

        }
    }


    public class SocketParameter
    {
        private string _name;
        private string _ip;
        private UInt32 _port;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                    _name = value;
            }
        }


        public string Ip
        {
            get { return _ip; }
            set
            {
                if (value != _ip)
                    _ip= value;
            }
        }

        public UInt32 Port
        {
            get { return _port; }
            set
            {
                if (value != _port)
                    _port = value;
                
            }
        }

        public void Print_Info()
        {
            Console.WriteLine("*****************SocketParameter begin*****************");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"ComPort Name = {Ip}");
            Console.WriteLine($"Baudrate = {Port}");
            Console.WriteLine("*****************SocketParameter end*****************");
        }

        public SocketParameter()
        {
            this.Name = "demo_socket";
            this.Ip = "127.0.0.1";
            this.Port = 8888;

            Print_Info();
        }


        public SocketParameter(int i)
        {
            this.Name = $"demo_socket_{i}";
            this.Ip = "127.0.0.1";
            this.Port = 8888;

            Print_Info();
        }


        ~SocketParameter()
        {

        }
    }



    public class ParameterManager
    {
        public ParameterManager()
        {
            Console.WriteLine("Parameter Manager create...");
            list_cam = new List<CameraPrameter>();
            list_comport = new List<ComportParameter>();
            list_socket_client = new List<SocketParameter>();
        }

        ~ParameterManager()
        {
            Console.WriteLine("Parameter Manager destroy...");
            list_cam.Clear();
            list_comport.Clear();
            list_socket_client.Clear();
        }


        public List<CameraPrameter> list_cam;
        public List<ComportParameter> list_comport;
        public List<SocketParameter> list_socket_client;
    }


    public class StateObject
    {
        // Client  socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 1024;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();


        public void Release()
        {
            if(workSocket != null) 
            {
                Console.WriteLine("free socket...");
                workSocket.Dispose();
            }
            Array.Clear(buffer, 0, buffer.Length);
            sb.Clear();
        }
    }

    public class TabControlIndex
    {
        public enum TabControl
        {
            Tab_Auto = 0,
            Tab_Manual,
            Tab_COM,
            Tab_Socket,
            Tab_Camera,
            Tab_Setting,
            Tab_Log,
            Tab_Help,
            Tab_About
        }
    }

    public class MyListBoxItem
    {
        public MyListBoxItem(Color c, string m)
        {
            ItemColor = c;
            Message = m;
        }
        public Color ItemColor { get; set; }
        public string Message { get; set; }
    }

    public class MyDefine
    {
        public static UInt16 port = 8888;
        public static string ip = "127.0.0.1";
        public static string FILE_JSON_PARAMETER = @"C:\Users\Admin\Downloads\tuanken92\param.json";
    }

    public class FrameData
    {
        public Mat frame;
        public ulong time_stamp;
        public ulong frame_id;

        public FrameData()
        {
            frame = new Mat();
            time_stamp = 0;
            frame_id = 0;
            Console.WriteLine("Create FrameData");
        }

        ~FrameData()
        {
            frame.Release();
            time_stamp = 0;
            frame_id = 0;
            Console.WriteLine("Destroy FrameData");
        }
    }
}
