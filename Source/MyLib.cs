using MCProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Vision.Source
{
    public class MyLib
    {

        public static async void ConnectToPlc(string ip, int port)
        {

            if (PLCData.PLC != null)
            {
                PLCData.PLC.Dispose();
                PLCData.PLC = null;
            }

            PLCData.PLC = new Mitsubishi.McProtocolTcp(ip, port, Mitsubishi.McFrame.MC3E);



            try
            {
                await PLCData.PLC.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public static bool DisconnectPLC()
        {
            if (PLCData.PLC == null)
                return false;

            if (PLCData.PLC.Connected)
            {
                int iClose = PLCData.PLC.Close();
                Console.WriteLine(iClose);
            }

            return !PLCData.PLC.Connected;
        }
    }


    
}
