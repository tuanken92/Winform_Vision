using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Vision.Source
{
    class SocketClient : Form
    {
        private IPEndPoint ip = null;
        private UInt16 port = MyDefine.port;
        private Socket socket_client = null;
        public string data_receive = null;
        
        TextBox tbIP = null;
        TextBox tbPort = null;
        TextBox tbData2Send = null;
        Button btnConnectDisconnect= null;
        Button btnSend = null;
        ListBox lbDataReceive = null;


        public SocketClient(TextBox tbIP, TextBox tbPort, TextBox tbData2Send, Button btnConnectDisconnect, Button btnSend, ListBox lbDataReceive)
        {
            Console.WriteLine("SocketClient constructor....");
            CheckForIllegalCrossThreadCalls = false;
            this.tbIP = tbIP;
            this.tbPort = tbPort;
            this.tbData2Send = tbData2Send;
            this.btnConnectDisconnect = btnConnectDisconnect;
            this.btnSend = btnSend;
            this.lbDataReceive = lbDataReceive;

            this.btnSend.Click += BtnSend_Click;
            this.btnConnectDisconnect.Click += BtnConnectDisconnect_Click;


            //var ip_scan = GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            var ip_scan = GetLocalIPv4(NetworkInterfaceType.Ethernet);

            //bool b = UInt16.TryParse(this.tbPort.Text, out port);
            port = UInt16.Parse(this.tbPort.Text);
            ip = new IPEndPoint(IPAddress.Parse(ip_scan), port);

            Console.WriteLine($"SocketClient: port = {port}, ip = {ip}");


        }

        private void BtnConnectDisconnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Send_Socket(this.tbData2Send.Text);
        }

        ~SocketClient()
        {
            Console.WriteLine("Socket Client destroy....");
            Close();
        }

        public void Connect()
        {
            Console.WriteLine($"SocketClient: port = {port}, ip = {ip}");
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

        public void Close_Socket()
        {
            if (socket_client.Connected)
                socket_client.Close();
        }

        public void Send_Socket(string message)
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
                while (true)
                {
                    byte[] data = new byte[1024];
                    socket_client.Receive(data);

                    string data_receive = Deserialize(data).ToString();
                    //string data_receive = Encoding.UTF8.GetString(data);
                    Console.WriteLine("Recieve = {0}", data_receive);
                }
            }
            catch
            {
                socket_client.Close();
                Console.WriteLine("socket_client.Close()");
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
            stream.Position = 0;
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string ip_scan = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ip_scan = ip.Address.ToString();
                        }
                    }
                }
            }

            Console.WriteLine($"ouput = {ip_scan}, type = {_type.ToString()}");
            return ip_scan;
        }
    }
}
