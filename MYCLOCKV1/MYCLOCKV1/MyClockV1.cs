using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;

namespace MYCLOCKV1
{
    public partial class MyClockV1 : Form
    {  
        string vDisplayTime;
        string vDisplayDate;
        string vDisplayDay;
        Thread MyConnection;

        public MyClockV1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            // Runs subtoutine
            SubPreloadStuff();
            SubChangeDayColour();

            
            MyConnection = new Thread(new ThreadStart(SubCheckMyNetwork));
            MyConnection.Start();
        }

        private void TmrClockTick_Tick(object sender, EventArgs e)
        {
            // Gets current tine from PC
            vDisplayTime = DateTime.Now.ToString("HH:mm:ss");
            BtnShowTime.Text = vDisplayTime;

            // Clock lodgic
            // ============

            // The following lodgic routine checks to see if the
            // clock has reached the "The Golden Hour" ie Midnight
            // is reached, the following will be changed.

            // 1. The day will change
            // 2. The date will change automatically
            // 3. The day of the week will change colour

            // If "The Golden Hour" is not reached
            // the three changes listed above
            // will not be changed...

            if (BtnShowTime.Text == "00:00:00")
            {
                // Displays day of the week
                lblDay.Text = DateTime.Now.DayOfWeek.ToString();

                // Displays new date
                BtnShowDate.Text = DateTime.Now.ToString("dd/MM/yy");

                // Change day colour routine
                SubChangeDayColour();
            }
            else if (BtnShowTime.Text != "00:00:00")
            {
                // Display current day of the week  
                lblDay.Text = vDisplayDay;

                // Display current date
                BtnShowDate.Text = vDisplayDate;

                // Change day colour routine
                SubChangeDayColour();
            }
        }

        // Subroutines

        private void SubPreloadStuff()
        {
            // Gets current date from PC
            vDisplayDate = DateTime.Now.ToString("dd/MM/yy");

            // Gets current tine from PC
            vDisplayTime = DateTime.Now.ToString("HH:mm:ss");
            
            // Gets current day of the week
            vDisplayDay = DateTime.Now.DayOfWeek.ToString();
           
            // Displays the current time
            BtnShowTime.Text = vDisplayTime;
            
            // Displays current day of the week
            lblDay.Text = vDisplayDay;
            
            // Display the current date
            BtnShowDate.Text = vDisplayDate;

            // Enables Timer
            TmrClockTick.Enabled = true;

            // Starts Timer
            TmrClockTick.Start();
        }

        private void SubChangeDayColour()
        {
            // Changes the colour of the day to be displayed

            if (lblDay.Text == "Monday")
            {
                lblDay.ForeColor = Color.White;
            }
            else if (lblDay.Text=="Tuesday")
            {
                lblDay.ForeColor = Color.Cyan;
            }
            else if (lblDay.Text == "Wednesday")
            {
                lblDay.ForeColor = Color.Yellow;
            }
            else if (lblDay.Text == "Thursday")
            {
                lblDay.ForeColor = Color.Pink;
            }
            else if (lblDay.Text == "Friday") 
            {
                lblDay.ForeColor = Color.Orange;
            }
            else if (lblDay.Text == "Saturday")
            {
                lblDay.ForeColor = Color.Red;
            }
            else if (lblDay.Text == "Sunday")
            {
                lblDay.ForeColor = Color.Red;
            }
        }

        private void SubCheckMyNetwork()
        {
            // Checks internet connection 
           
            while (true)
            {
                bool vCheckConnection = NetworkInterface.GetIsNetworkAvailable();

                if (vCheckConnection ==true)
                {
                    lblIntCheck.Text = "Internet Access";
                    lblIntCheck.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lblIntCheck.Text = "No Internet Access";
                    lblIntCheck.ForeColor = Color.Red;
                }

                // Put thread to sleep for 6 seconds 

                Thread.Sleep(6000);
            }
        }
    
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Aborts thread before closing application

            MyConnection.Abort();
        }
    }
}
