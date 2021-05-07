using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Vision.Source
{
    public class TCP_Server: Form
    {
        private TcpListener tcpServer;
        private TcpClient tcpClient;
        private Thread th;
        private ArrayList formArray = new ArrayList();
        private ArrayList threadArray = new ArrayList();
        public delegate void ChangedEventHandler(object sender, EventArgs e);
        public event ChangedEventHandler Changed;
        public delegate void SetListBoxItem(String str, String type);

        //variable
        private string ip = MyDefine.ip;
        private int port = MyDefine.port;
        public StringBuilder data_receive = null;


        TextBox tbIP = null;
        TextBox tbPort = null;
        TextBox tbData2Send = null;
        Button btnOpenClose = null;
        Button btnSend = null;
        ListBox lbDataReceive = null;


        public TCP_Server()
        {

        }

        public TCP_Server(TextBox tbIP, TextBox tbPort, TextBox tbData2Send, Button btnOpenClose, Button btnSend, ListBox lbDataReceive)
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

            // Add Event to handle when a client is connected
            //Changed += new ChangedEventHandler(ClientAdded);

            Console.WriteLine("ip  = {0}, port = {1}", this.tbIP.Text, this.tbPort.Text);

            //init
            /*var localEndPoint = ip.Client.LocalEndPoint as IPEndPoint;
            var localAddress = localEndPoint.Address;
            var localPort = localEndPoint.Port;*/


            //bool get_port = UInt16.TryParse(this.tbPort.Text, out port);
            Console.WriteLine($"Socket Server constructor: ip = {ip}, port = {port}");
            
        }

        ~TCP_Server()
        {

        }

        static bool isPressedConnectDisconnect = false;
        private void BtnOpenClose_Click(object sender, EventArgs e)
        {
            if (!isPressedConnectDisconnect)
            {
                isPressedConnectDisconnect = true;
                StartServer();
            }
            else
            {
                isPressedConnectDisconnect = false;
                StopServer();
            }

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn Send data to client....");
            
        }


        void StartServer() { }
        void StopServer() { }

    }
}
