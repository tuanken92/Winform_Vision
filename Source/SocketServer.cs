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
using System.Windows.Forms;

namespace Winform_Vision.Source
{
    public class SocketServer : Form
    {
        //variable
        private IPEndPoint ip = null;
        private ushort port = MyDefine.port;
        private Socket socket_server = null;
        private List<Socket> list_socket_client = null;
        public string data_receive = null;


        TextBox tbIP = null;
        TextBox tbPort = null;
        TextBox tbData2Send = null;
        Button btnOpenClose = null;
        Button btnSend = null;
        ListBox lbDataReceive = null;


        public SocketServer(TextBox tbIP, TextBox tbPort, TextBox tbData2Send, Button btnOpenClose, Button btnSend, ListBox lbDataReceive)
        {
            Console.WriteLine("Socket Server constructor....");

            this.tbIP = tbIP;
            this.tbPort = tbPort;
            this.tbData2Send = tbData2Send;
            this.btnOpenClose = btnOpenClose;
            this.btnSend = btnSend;
            this.lbDataReceive = lbDataReceive;

            this.btnSend.Click += BtnSend_Click;
            this.btnOpenClose.Click += BtnOpenClose_Click;


            Console.WriteLine("ip  = {0}, port = {1}", this.tbIP.Text, this.tbPort.Text);

            //init
            /*var localEndPoint = ip.Client.LocalEndPoint as IPEndPoint;
            var localAddress = localEndPoint.Address;
            var localPort = localEndPoint.Port;*/


            //bool get_port = UInt16.TryParse(this.tbPort.Text, out port);
            Console.WriteLine($"Socket Server constructor: port = {port}");
            data_receive = null;
            list_socket_client = new List<Socket>();
            ip = new IPEndPoint(IPAddress.Any, port);

            Console.WriteLine("SocketServer done, ip = ", ip);

        }

        private void BtnOpenClose_Click(object sender, EventArgs e)
        {
            Console.WriteLine("BtnOpenClose socket server ....");

            OpenServer();

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn Send data to client....");
            foreach(Socket client in list_socket_client)
            {
                Send(client, tbData2Send.Text);
            }
        }

        ~SocketServer()
        {
            Console.WriteLine("Socket Server destroy....");
            Close_Server();
        }

        public void OpenServer()
        {
            socket_server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socket_server.Bind(ip);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        socket_server.Listen(100);
                        Socket client = socket_server.Accept();
                        list_socket_client.Add(client);

                        Thread receive = new Thread(Recieve);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, port);
                    socket_server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    Console.WriteLine("Can't socket_server.Accept()!");
                }

            });
            Listen.IsBackground = true;
            Listen.Start();

            Console.WriteLine("OpenServer done");
        }

        public void Close_Server()
        {
            if (socket_server != null)
            {
                if (socket_server.Connected)
                {

                    socket_server.Close();
                }

            }
        }

        public void Send(Socket client, string message)
        {
            if (client == null)
            {
                Console.WriteLine("Client is null");
                return;
            }

            if (client.Connected)
            {
                client.Send(Serialize(message));
            }
        }

        public void Recieve(Object obj)
        {
            Socket client = obj as Socket;
            if (client == null)
            {
                Console.WriteLine("Client is null");
                return;
            }

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    client.Receive(data);

                    data_receive = Deserialize(data).ToString();
                    Console.WriteLine("Recieve = {0} from {1}", data_receive, client.ToString());
                }
            }
            catch
            {
                list_socket_client.Remove(client);
                client.Close();
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
