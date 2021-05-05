using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace Winform_Vision.Source
{
    public class SerialPortManager: Form
    {
        private Button btnConnectDisconnect;
        private Button btnSend;
        private ComboBox cbbListComport;
        private ListBox lbLogComport;
        private ListBox lbDataReceiveComport;
        private TextBox tbDataToSend;
        private SerialPort serialPort;
        string comPortName;
        public SerialPortManager( 
            Button btnConnect, 
            Button btnSend,
            ComboBox cbbListComport,
            ListBox lbLogComport,
            ListBox lbDataReceive,
            TextBox tbData2Send
            )
        {
            serialPort = new SerialPort();
            comPortName = null;
            this.btnConnectDisconnect = btnConnect;
            this.btnSend = btnSend;
            this.cbbListComport = cbbListComport;
            this.lbLogComport = lbLogComport;
            this.lbDataReceiveComport = lbDataReceive;
            this.tbDataToSend = tbData2Send;


            //assig event
            this.btnSend.Click += BtnSend_Click;
            this.btnConnectDisconnect.Click += BtnConnectDisconnect_Click;
            
            this.cbbListComport.SelectedIndexChanged += CbbListComport_SelectedIndexChanged;

            this.serialPort.DataReceived += SerialPort_DataReceived;

            //init
            scan_comport();

        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var data_received = this.serialPort.ReadExisting();
            Console.WriteLine($"data_received = {data_received}");
        }

        ~SerialPortManager()
        {
            if (serialPort.IsOpen)
                serialPort.Close();

            Console.WriteLine("SerialPortManager destroy");
        }

        private void CbbListComport_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("combobox selected-index-changed click");
            comPortName = cbbListComport.GetItemText(cbbListComport.SelectedItem);
            this.serialPort.PortName = comPortName;
            Console.WriteLine($"{comPortName} is {this.serialPort.IsOpen}");

        }

        private void BtnConnectDisconnect_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn connect-disconnect click");
            if (!this.serialPort.IsOpen)
            {

                this.serialPort.Open();
                if (this.serialPort.IsOpen)
                {
                    Console.WriteLine($"{comPortName} connected");
                    cbbListComport.Enabled = false;
                }
            }
            else
            {
                this.serialPort.Close();
                if (!this.serialPort.IsOpen)
                {
                    Console.WriteLine($"{comPortName} disconnected");
                    cbbListComport.Enabled = true;
                }
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var data_to_send = tbDataToSend.Text;
            Console.WriteLine($"data2send = {data_to_send}");

            if (data_to_send.Length < 1)
            {
                Console.WriteLine("data2send is empty, retry");
                return;
            }

            if (this.serialPort.IsOpen)
            {
                this.serialPort.Write(data_to_send);
            }
            else
            {
                Console.WriteLine($"{comPortName} not open, recheck!");
            }

        }


        private void scan_comport()
        {
            //log.Debug("Scan all comport availble");
            string[] ArrayComPortsNames = null;
            int index = -1;

            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cbbListComport.Items.Add(ArrayComPortsNames[index]);
                //log.Debug($"Found {ArrayComPortsNames[index]}");
            }

            while (!((ArrayComPortsNames[index] == comPortName)
                          || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            //want to get first out
            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                comPortName = ArrayComPortsNames[0];
            }
            cbbListComport.Text = ArrayComPortsNames[0];
        }
    }
}
