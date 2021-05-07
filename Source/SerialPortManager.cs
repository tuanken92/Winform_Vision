using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;

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
        private Label lbComportStatus;

        private string comPortName;
        private StringBuilder dataReceived;

        public StringBuilder DataReceived { get => dataReceived; set => dataReceived = value; }

        public SerialPortManager( 
            Button btnConnect, 
            Button btnSend,
            ComboBox cbbListComport,
            ListBox lbLogComport,
            ListBox lbDataReceive,
            TextBox tbData2Send,
            Label lbComportStatus
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
            this.lbComportStatus = lbComportStatus;
            this.DataReceived = new StringBuilder();
            //init
            Init_UI();
            

        }

        private void Init_UI()
        {

            this.lbComportStatus.Text = "Welcome to SerialPort";
            
            //assign event
            this.btnSend.Click += BtnSend_Click;
            this.btnConnectDisconnect.Click += BtnConnectDisconnect_Click;
            /*this.lbLogComport.DrawItem += LbLogComport_DrawItem;*/
            this.cbbListComport.SelectedIndexChanged += CbbListComport_SelectedIndexChanged;
            this.serialPort.DataReceived += SerialPort_DataReceived;
            scan_comport();
        }

       /* private void LbLogComport_DrawItem(object sender, DrawItemEventArgs e)
        {
            MyListBoxItem item = lbLogComport.Items[e.Index] as MyListBoxItem; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {
                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    item.Message, // The message linked to the item
                    lbLogComport.Font, // Take the font from the listbox
                    new SolidBrush(item.ItemColor), // Set the color 
                    0, // X pixel coordinate
                    e.Index * lbLogComport.ItemHeight // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
            }
            else
            {
                // The item isn't a MyListBoxItem, do something about it
            }
        }*/

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data_com = this.serialPort.ReadExisting();
            if(data_com != null)
                this.DataReceived = new StringBuilder(data_com);

            Console.WriteLine($"data_received = {data_com}");
            this.lbDataReceiveComport.Items.Add(data_com);
            
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

                    btnConnectDisconnect.Text = "Disconnect";
                    lbComportStatus.Text = $"{comPortName} connected";


                    /*lbLogComport.Items.Add(new MyListBoxItem(Color.Blue, $"{comPortName} connected"));*/
                    lbLogComport.Items.Add($"{comPortName} connected");
                }
            }
            else
            {
                this.serialPort.Close();
                if (!this.serialPort.IsOpen)
                {
                    Console.WriteLine($"{comPortName} disconnected");
                    btnConnectDisconnect.Text = "Connect";
                    cbbListComport.Enabled = true;
                    lbComportStatus.Text = $"{comPortName} disconnected";

                    /*lbLogComport.Items.Add(new MyListBoxItem(Color.Red, $"{comPortName} disconnected"));*/
                    lbLogComport.Items.Add($"{comPortName} disconnected");
                }
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if(!this.serialPort.IsOpen)
            {
                MessageBox.Show("Warning", "Please connect COM-port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var data_to_send = tbDataToSend.Text;
            Console.WriteLine($"data2send = {data_to_send}");

            if (data_to_send.Length < 1)
            {
                Console.WriteLine("data2send is empty, retry");
                return;
            }

            this.serialPort.Write(data_to_send);

            /*lbLogComport.Items.Add(new MyListBoxItem(Color.Black, $"Send data: {data_to_send}"));*/
            lbLogComport.Items.Add($"Send data: {data_to_send}");

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
