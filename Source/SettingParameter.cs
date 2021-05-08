using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Winform_Vision.Source
{
    class SettingParameter: Form
    {
        //variable data
        ParameterManager parameter_manager = new ParameterManager();
        
        ComboBox cbb_list_format;
        ComboBox cbb_list_type_camera;
        ComboBox cbb_list_flip;

        public SettingParameter(ComboBox cbb_list_format,
                                ComboBox cbb_list_type_cam,
                                ComboBox cbb_list_flip
                                )
        {
            this.cbb_list_format = cbb_list_format;
            this.cbb_list_format.SelectedIndexChanged += Cbb_list_format_SelectedIndexChanged;
            this.cbb_list_format.DataSource = Enum.GetValues(typeof(CameraPrameter.EFormatCamera));

            this.cbb_list_type_camera = cbb_list_type_cam;
            this.cbb_list_type_camera.SelectedIndexChanged += Cbb_list_type_camera_SelectedIndexChanged;
            this.cbb_list_type_camera.DataSource = Enum.GetValues(typeof(CameraPrameter.ETypeCamera));

            this.cbb_list_flip = cbb_list_flip;
            this.cbb_list_flip.SelectedIndexChanged += Cbb_list_flip_SelectedIndexChanged; ;
            this.cbb_list_flip.DataSource = Enum.GetValues(typeof(CameraPrameter.EFlipFrame));
        }

        private void Cbb_list_flip_SelectedIndexChanged(object sender, EventArgs e)
        {
            CameraPrameter.EFlipFrame status;
            Enum.TryParse<CameraPrameter.EFlipFrame>(this.cbb_list_format.SelectedValue.ToString(), out status);

            Console.WriteLine(status);
        }

        private void Cbb_list_type_camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            CameraPrameter.ETypeCamera status;
            Enum.TryParse<CameraPrameter.ETypeCamera>(this.cbb_list_format.SelectedValue.ToString(), out status);

            Console.WriteLine(status);
        }

        private void Cbb_list_format_SelectedIndexChanged(object sender, EventArgs e)
        {
            CameraPrameter.EFormatCamera status;
            Enum.TryParse<CameraPrameter.EFormatCamera>(this.cbb_list_format.SelectedValue.ToString(), out status);

            Console.WriteLine(status);
        }

        void Initial_UI()
        {

        }
        
        public void Inital_Parameter()
        {
            //Create camera basler
            CameraPrameter cam_basler = new CameraPrameter();
            cam_basler.Name         = "Basler_10MP";
            cam_basler.Format       = CameraPrameter.EFormatCamera.MONO;
            cam_basler.Is_support   = true;
            cam_basler.Fps          = 10;
            cam_basler.Roi          = new OpenCvSharp.Rect(0, 0, 1920, 1080);
            cam_basler.Use_calib    = false;
            cam_basler.Flip         = CameraPrameter.EFlipFrame.Flip_None;


            //Creater COM port
            ComportParameter com_light_control = new ComportParameter();
            com_light_control.Name = "Light Controller";
            com_light_control.Port_name = "COM2";
            com_light_control.Baudrate = 9600;


            //Creater Socket-client
            SocketParameter socket_client = new SocketParameter();
            socket_client.Name      = "Client connect to Jump-Sys";
            socket_client.Port      = 8888;
            socket_client.Ip        = "127.0.0.1";

            //Add to parameter_manager
            parameter_manager.list_cam.Add(cam_basler);
            parameter_manager.list_comport.Add(com_light_control);
            parameter_manager.list_socket_client.Add(socket_client);

        }


        public void Get_Parameter()
        {

        }

        public void Update_Parameter()
        {

        }

        public void Save_Parameter()
        {
            // serialize JSON directly to a file
            Console.WriteLine(MyDefine.FILE_JSON_PARAMETER);
            using (StreamWriter file = File.CreateText(MyDefine.FILE_JSON_PARAMETER))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, parameter_manager);
            }
        }

        public void Load_Parameter()
        {
            using (StreamReader file = File.OpenText(MyDefine.FILE_JSON_PARAMETER))
            {
                JsonSerializer serializer = new JsonSerializer();
                parameter_manager = (ParameterManager)serializer.Deserialize(file, typeof(ParameterManager));
            }
            Console.WriteLine(parameter_manager.ToString());
        }

    }
}
