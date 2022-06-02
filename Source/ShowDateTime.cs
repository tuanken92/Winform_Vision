using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Winform_Vision.Source
{
    public class ShowDateTime : Form
    {
        private Timer timer_Datetime;
        private Label label_Datetime;

        public ShowDateTime(Timer timer, Label label)
        {

            Console.WriteLine("Timer created.....");
            this.timer_Datetime = timer;
            this.timer_Datetime.Tick += Timer_Datetime_Tick;
            this.label_Datetime = label;

            Inital_Timer();
            Start_Timer();

        }

        ~ShowDateTime()
        {
            if (this.timer_Datetime.Enabled)
                this.timer_Datetime.Stop();
        }

        private void Timer_Datetime_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("Timer date-time tick.....");
            this.label_Datetime.Text = DateTime.Now.ToString("ddd MM/dd/yyyy\nhh:mm:ss tt");
        }

        public void Start_Timer()
        {
            this.timer_Datetime.Start();
        }


        public void Stop_Timer()
        {
            this.timer_Datetime.Stop();
        }


        public void Inital_Timer()
        {
            this.timer_Datetime.Interval = 1000;
        }



    }
}
