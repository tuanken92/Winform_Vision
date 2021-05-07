using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Vision.Source
{
    class TCP_Client : Form
    {
        private string ip = MyDefine.ip;
        private int port = MyDefine.port;
        private TcpClient server;
        public StringBuilder data_receive = null;
        NetworkStream ns = null;
        StateObject state = null;

        TextBox tbIP = null;
        TextBox tbPort = null;
        TextBox tbData2Send = null;
        Button btnConnectDisconnect = null;
        Button btnSend = null;
        ListBox lbDataReceive = null;

        public TCP_Client(string ip, int port, ListBox lbDataReceive)
        {
            Console.WriteLine("TCPClient (0) constructor....");

            //var ip_scan = GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            this.ip = ip;
            this.port = port;
            this.state = new StateObject();
            this.lbDataReceive = lbDataReceive;
            Console.WriteLine($"TCP Client (0): port = {port}, ip = {ip}");
        }

        public TCP_Client(TextBox tbIP, TextBox tbPort, TextBox tbData2Send, Button btnConnectDisconnect, Button btnSend, ListBox lbDataReceive)
        {
            Console.WriteLine("TCPClient (1) constructor....");
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
            ip = GetLocalIPv4(NetworkInterfaceType.Ethernet);
            Console.WriteLine($"SocketClient: port = {port}, ip = {ip}, port infor = {this.tbPort.Text}");
            port = int.Parse(this.tbPort.Text);

            
        }

        ~TCP_Client()
        {
            
            if(server != null)
            {
                Console.WriteLine("free server");
                server.Dispose();
            }
            if (data_receive != null)
            {
                Console.WriteLine("free data_receive");
                data_receive.Clear();
            }


            if (ns != null)
            {
                Console.WriteLine("free NetworkStream");
                ns.Dispose();
            }

            if(state != null)
            {
                Console.WriteLine("free NetworkStream");
                state.Release();
            }


            Console.WriteLine("~TCP_Client()");
        }

        static bool isPressedConnectDisconnect = false;
        private void BtnConnectDisconnect_Click(object sender, EventArgs e)
        {
            if(!isPressedConnectDisconnect)
            {
                isPressedConnectDisconnect = true;
                Connect();
            }
            else
            {
                isPressedConnectDisconnect = false;
                Disconnect();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void Connect()
        {
            
            try
            {
                server = new TcpClient(this.ip, this.port);
                this.state = new StateObject();
            }
            catch (SocketException)
            {
                Console.WriteLine("Unable to connect to server");
                return;
            }
            Console.WriteLine("Connected to the Server...");
            Console.WriteLine("Enter the message to send it to the Sever");
            ns = server.GetStream();
            
            state.workSocket = server.Client;
            server.Client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback((new TCP_Client(this.ip, this.port, this.lbDataReceive)).OnReceive), state);

            if(state.workSocket.Connected)
            {
                this.btnConnectDisconnect.Text = "Disconnect";
            }
        }

        private void Disconnect()
        {
            state.workSocket.Close();
            ns.Close();
            server.Close();
            Console.WriteLine("Disconnect to server");
            if (!state.workSocket.Connected)
            {
                this.btnConnectDisconnect.Text = "Connect";
            }
        }

        private void SendData()
        {
            string data2send = this.tbData2Send.Text;
            if (!string.IsNullOrEmpty(data2send))
            {
                if (server.Connected)
                {
                    ns.Write(Encoding.ASCII.GetBytes(data2send), 0, data2send.Length);
                    ns.Flush();

                }
            }

        }
        public void OnReceive(IAsyncResult ar)
        {
            

            // Retrieve the state object and the handler socket
            // from the asynchronous state object.
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;
            int bytesRead;

            if (handler.Connected)
            {

                // Read data from the client socket. 
                try
                {
                    bytesRead = handler.EndReceive(ar);
                    if (bytesRead > 0)
                    {
                        // There  might be more data, so store the data received so far.
                        state.sb.Remove(0, state.sb.Length);
                        state.sb.Append(Encoding.ASCII.GetString(
                                         state.buffer, 0, bytesRead));

                        // Display Text in Rich Text Box
                        data_receive = new StringBuilder(state.sb.ToString());
                        Console.WriteLine(data_receive.ToString());
                        this.lbDataReceive.Items.Add(data_receive.ToString());

                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(OnReceive), state);

                    }
                }

                catch (SocketException socketException)
                {
                    //WSAECONNRESET, the other side closed impolitely
                    if (socketException.ErrorCode == 10054 || ((socketException.ErrorCode != 10004) && (socketException.ErrorCode != 10053)))
                    {
                        handler.Close();
                    }
                }

                // Eat up exception....Hmmmm I'm loving eat!!!
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message + "\n" + exception.StackTrace);

                }
            }
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
