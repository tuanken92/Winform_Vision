using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Winform_Vision.Source
{
    public class SocketClient_
    {
        private IPEndPoint ip;
        private UInt16 port;
        private Socket socket_client;
        public string data_receive;


        public SocketClient_()
        {
            Console.WriteLine("Socket Client constructor....");
            port = 9999;
            data_receive = null;
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
        }

        ~SocketClient_()
        {
            Console.WriteLine("Socket Client destroy....");
            Close();
        }

        public void Connect()
        {
            socket_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                socket_client.Connect(ip);
            }
            catch
            {
                Console.WriteLine("Can't connect to server!");
                return;
            }
            Thread listen = new Thread(Recieve);
            listen.IsBackground = true;
            listen.Start();
        }

        public void Close()
        {
            if (socket_client.Connected)
                socket_client.Close();
        }

        public void Send(string message)
        {
            if (socket_client.Connected)
            {
                socket_client.Send(Serialize(message));
            }
        }

        public void Recieve()
        {
            try
            {
                while(true)
                {
                    byte[] data = new byte[1024];
                    socket_client.Receive(data);

                    data_receive = Deserialize(data).ToString();
                }
            }
            catch
            {
                socket_client.Close();
            }
            
        }

        public byte[] Serialize(Object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        public Object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }
    }
}
