using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
namespace Winform_Vision.Source
{

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
