using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
namespace Winform_Vision.Source
{
    public class MyDefine
    {
        public static UInt16 port = 9999;
        public static string ip = "192.168.1.13";
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
