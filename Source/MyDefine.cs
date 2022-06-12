using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
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
                if (File.Exists(value))
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
            Console.WriteLine("CameraPrameter create {0}", i);
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
                    _ip = value;
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



    public class SaveLoadParameter
    {
        public static void Save_Parameter(object param)
        {
            //save
            if (File.Exists(MyDefine.file_config))
            {
                Save_Parameter(param, MyDefine.file_config);
            }
            else
            {
                //create folder
                FileInfo fileInfo = new FileInfo(MyDefine.file_config);
                if (!fileInfo.Exists)
                    Directory.CreateDirectory(fileInfo.Directory.FullName);

                //create file
                using (FileStream f = File.Create(MyDefine.file_config))
                {
                    f.Close();
                    Console.WriteLine($"Create file {MyDefine.file_config}");
                }

                //save param to file
                Save_Parameter(param, MyDefine.file_config);
            }
        }

        public static object Load_Parameter(object param)
        {
            if (File.Exists(MyDefine.file_config))
            {
                using (StreamReader file = File.OpenText(MyDefine.file_config))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    param = serializer.Deserialize(file, param.GetType());
                }
            }
            else
            {
                MessageBox.Show($"Not found {MyDefine.file_config}");
            }

            return param;
        }

        public static void Save_Parameter(object param, string file_name)
        {
            //save
            if (File.Exists(file_name))
            {
                // serialize JSON directly to a file
                Console.WriteLine("Save parameter to file " + file_name);
                using (StreamWriter file = File.CreateText(file_name))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, param);
                }
            }
            else
            {
                //create folder
                FileInfo fileInfo = new FileInfo(file_name);
                if (!fileInfo.Exists)
                    Directory.CreateDirectory(fileInfo.Directory.FullName);

                //create file
                using (FileStream f = File.Create(file_name))
                {
                    f.Close();
                    Console.WriteLine($"Create file {file_name}");
                }

                // serialize JSON directly to a file
                Console.WriteLine("Save parameter to file " + file_name);
                using (StreamWriter file = File.CreateText(file_name))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, param);
                }
            }
        }

        public static object Load_Parameter(object param, string file_name)
        {
            if (File.Exists(file_name))
            {
                using (StreamReader file = File.OpenText(file_name))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    param = serializer.Deserialize(file, param.GetType());
                }
            }
            else
            {
                MessageBox.Show($"Not found {file_name}");
            }

            return param;
        }
    }


    public class ISCamera
    {
        string ip;
        string userName;
        string passWord;

        public string Ip { get => ip; set => ip = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        public ISCamera()
        {
            Ip = "127.0.0.1";
            UserName = "admin";
            PassWord = "";
        }

        public ISCamera(string _ip, string _userName = "admin", string _passWord = "")
        {
            Ip = _ip;
            UserName = _userName;
            PassWord = _passWord;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"IP = {Ip}, {UserName}:{PassWord}");
        }
    }

    public class QMitsubishi
    {
        string ip;
        int port;

        int addTrigger;
        int addPosition;
        int addResult;


        int addX, addY, addAngle;

        public string Ip { get => ip; set => ip = value; }
        public int Port { get => port; set => port = value; }
        public int TriggerInput { get => addTrigger; set => addTrigger = value; }
        public int PosCheckInput { get => addPosition; set => addPosition = value; }
        public int ResultOutput { get => addResult; set => addResult = value; }
        public int AddX { get => addX; set => addX = value; }
        public int AddY { get => addY; set => addY = value; }
        public int AddAngle { get => addAngle; set => addAngle = value; }

        public QMitsubishi(string _ip, int _port, int _addTrig, int _addPosition, int _addResult)
        {
            Ip = _ip;
            Port = _port;
            TriggerInput = _addTrig;
            PosCheckInput = _addPosition;
            ResultOutput = _addResult;
        }

        public QMitsubishi()
        {
            Ip = "192.168.3.222";
            Port = 12222;
            TriggerInput = 1000;
            PosCheckInput = 1005;
            ResultOutput = 1015;
            AddX = 1016;
            AddY = 1018;
            AddAngle = 1020;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"IP:Port = {Ip}:{Port}");
            Console.WriteLine($"TriggerInput = {TriggerInput}");
            Console.WriteLine($"PosCheckInput = {PosCheckInput}");
            Console.WriteLine($"ResultOutput = {ResultOutput}");
            
            Console.WriteLine($"AddX = {AddX}");
            Console.WriteLine($"AddY = {AddY}");
            Console.WriteLine($"Add" +
                $"Angle = {AddAngle}");
        }

    }

    public class CommonParam
    {
        ulong numOK;
        ulong numNG;
        String pathImage;
        String pathText;
        bool isSaveImage;
        bool isUsePLC;
        bool isUseCamera;

        public ulong NumOK { get => numOK; set => numOK = value; }
        public ulong NumNG { get => numNG; set => numNG = value; }
        public string PathImage { get => pathImage; set => pathImage = value; }
        public string PathText { get => pathText; set => pathText = value; }
        public bool IsSaveImage { get => isSaveImage; set => isSaveImage = value; }
        public bool IsUsePLC { get => isUsePLC; set => isUsePLC = value; }
        public bool IsUseCamera { get => isUseCamera; set => isUseCamera = value; }

        public CommonParam()
        {
            NumOK = 0;
            NumNG = 0;
            pathImage = MyDefine.path_save_images;
            pathText = MyDefine.path_save_texts;
            IsSaveImage = false;
            IsUsePLC = false;
            IsUseCamera = false;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Num OK = {NumOK}, NG = {numNG}, isSaveImage = {IsSaveImage}"); 
            Console.WriteLine($"IsUsePLC = {IsUsePLC}, IsUseCamera = {IsUseCamera}, isSaveImage = {IsSaveImage}");
            Console.WriteLine($"Path image = {PathImage}\nPath text = {PathText}");
        }

    }
    public class ParameterManager
    {
        public ISCamera cam;
        public QMitsubishi plc;
        public CommonParam common;

        public ParameterManager()
        {
            cam = new ISCamera();
            plc = new QMitsubishi();
            common = new CommonParam();

            


        }

        public void PrintInfo()
        {
            cam.PrintInfo();
            plc.PrintInfo();
            common.PrintInfo();
        }

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
            if (workSocket != null)
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
            Tab_Camera,
            Tab_Setting,
            Tab_Log,
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

  

            public static uint WM_LBUTTONDOWN = 0x201;
        public static uint WM_LBUTTONUP = 0x202;

        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        public static readonly string workspaceDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string resources_folder = String.Format($"{workingDirectory}\\resources");

        public static readonly string regex_get_image_file = @"[^\s]+(.*?)\.(jpg|jpeg|png|gif|JPG|JPEG|PNG|GIF)$";
        public static readonly string regex_get_ip = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";


        #region Path file json
        public static readonly string file_brand = String.Format($"{workingDirectory}\\Configs\\brand.json");
        public static readonly string file_category = String.Format($"{workingDirectory}\\Configs\\category.json");
        public static readonly string file_user = String.Format($"{workingDirectory}\\Configs\\user.json");
        public static readonly string file_customer = String.Format($"{workingDirectory}\\Configs\\customer.json");
        public static readonly string file_warehouse = String.Format($"{workingDirectory}\\Configs\\warehouse.json");
        public static readonly string file_product = String.Format($"{workingDirectory}\\Configs\\product.json");
        public static readonly string file_unit = String.Format($"{workingDirectory}\\Configs\\unit.json");
        public static readonly string file_setting = String.Format($"{workingDirectory}\\Configs\\setting.json");
        public static readonly string file_import_product_manager = String.Format($"{workingDirectory}\\Configs\\product_import_manager.json");
        public static readonly string file_export_product_manager = String.Format($"{workingDirectory}\\Configs\\product_export_manager.json");
        public static readonly string import_product_tmp = String.Format($"{workingDirectory}\\Data\\Import\\") + @"product_import_{0}_{1}_{2}.json";
        public static readonly string export_product_tmp = String.Format($"{workingDirectory}\\Data\\Export\\") + @"product_export_{0}_{1}_{2}.json";


        public static readonly string file_config = String.Format($"{workingDirectory}\\Configs\\config_param.json");
        public static readonly string file_excel = String.Format($"{workingDirectory}\\Data\\ImportData.xlsx");

        public static readonly string file_config_format_data = String.Format($"{workingDirectory}\\Data\\configs\\format_data.json");
        public static readonly string file_config_common_param = String.Format($"{workingDirectory}\\Data\\configs\\common_param.json");
        public static readonly string file_config_filter_window = String.Format($"{workingDirectory}\\Data\\configs\\filter_window.json");
        public static readonly string path_load_img_database = @"C:\Program Files\Cognex\VisionPro\Images";
        public static readonly string path_load_vpp_file = @"C:\Users\Admin\Desktop\Vpp_file";
        public static readonly string path_save_images = String.Format("{0}\\Images", projectDirectory);
        public static readonly string path_save_texts = String.Format("{0}\\Texts", projectDirectory);

        public static readonly string key_thh = @"https://tanhungha.com.vn/";
        public static readonly string hash_key = "";
        #endregion

        #region api
        public static string API_OK = "success";
        public static string API_NG = "error";
        public static string API_Warning = "warning";
        public static string API_LOSS_CONNECTION = "network";
        #endregion

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);



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
