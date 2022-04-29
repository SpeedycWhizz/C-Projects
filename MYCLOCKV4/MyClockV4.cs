using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Speech.Synthesis;
using System.IO;

namespace MYCLOCKV1
{
  
    public partial class FrmMyClockV : Form
    {
        // Information about the following application
        // ========================================================
        // 
        // Application Name                 : MyClock V4
        // Application Designed & Coded By  : Speedy C (aka Speedy)
        // ---------------------------------------------------------
        //
        // Why was this appication created ?
        // =================================
        //
        // This application was created just for fun
        // and for a bit of coding practice in C#.
        // Plus I need a bigger clock on my PC as 
        // the windows 10 clock is a bit small for me
        // to read correctly.  Most of my applications,
        // end up having some practical use.
        //
        // The application contains the following
        // --------------------------------------
        // 1. A large time & date display
        // 2. An internet connection status checker
        // 3. 3 Voices to choose from 1, David, 2 Hazel 3, Zira
        // 4. Voice volume control 25%, 50%, 75%, 100% 
        // 5  Hourly report
        // 6. text reminder or reminders spoken

        // Javidx9 (Javid)
        // 
        // I would like this to be considered for entry into your 
        // next One Lone Coder Shoecase. 
        //
        // Give it a Speedy spin LOL...
        // You never know you may find it useful
        // Thanks... Speedy



        string vDisplayTime;
        string vDisplayDate;
        string vDisplayDay;
        bool vCheckConnection;
        bool vNoTimeSet = false;
       

        String vSysDir = @"C:\MyClock\";
        string vReminderSetTime;
        String vHSet;
        String vMSet;
        String vSSet;
        String vtmpReminderStore;
        string vFileEx =".mfs";
        
        Thread MyConnection;
        Thread MyHourlyCheck;
        Thread MyReminderCheck;

        ArrayList alHourlyReport = new ArrayList();
        ArrayList alStoreReminders = new ArrayList();

        SpeechSynthesizer Synth = new SpeechSynthesizer();


        public FrmMyClockV()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            // Runs subtoutine
            SubPreloadStuff();
            SubChangeDayColour();

            // Connection thread
            MyConnection = new Thread(new ThreadStart(SubCheckMyNetwork));
            MyConnection.IsBackground = true;
            MyConnection.Start();

            // Hourly report thread
            MyHourlyCheck = new Thread(new ThreadStart(SubHourlyCheck));
            MyHourlyCheck.IsBackground = true;
            MyHourlyCheck.Start();

            // Reminder check thread
            MyReminderCheck = new Thread(new ThreadStart(SubReminderCheck));
            MyReminderCheck.IsBackground = true;
            MyReminderCheck.Start();

            RBxReminder.Focus();
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
            // 3. The day will change colour

            if (CBxHourlyReportOnAndOff.Checked == true)
            {
                frmlblHR.Visible = true;
                frmlblVoice.Visible = true;

                // Subroutine
                SubHourlyCheck();
            }
            else if (CBxHourlyReportOnAndOff.Checked == false)
            {
                frmlblHR.Visible = false;
                frmlblVoice.Visible = false;
            }

            if (CBxRedRemindersOndAndOff.Checked == true)
            {
                frmlblReadReminders.Visible = true;

                // Subroutine
                SubReminderCheck();
            }
            if (CBxRedRemindersOndAndOff.Checked == false)
            {
                frmlblReadReminders.Visible = false;
                
                // Subroutine
                SubReminderCheck();
            }

                // The golden hour
            if (BtnShowTime.Text == "00:00:00")
            {
                // Displays day of the week
                lblDay.Text = DateTime.Now.DayOfWeek.ToString();

                // Displays new date
                BtnShowDate.Text = DateTime.Now.ToString("dd/MM/yy");

                // Change day colour routine
                SubChangeDayColour();
                SubOpenDayOfReminder();
                SubUpdateReminders();

                // Turns off reminder display
                lblDisplayReminders.Visible = false;
            }
        }

    // Subroutines

    private void SubPreloadStuff()
    {
            // Hourly reports
            alHourlyReport.Add("00:00:00");
            alHourlyReport.Add("01:00:00");
            alHourlyReport.Add("02:00:00");
            alHourlyReport.Add("03:00:00");
            alHourlyReport.Add("04:00:00");
            alHourlyReport.Add("05:00:00");
            alHourlyReport.Add("06:00:00");
            alHourlyReport.Add("07:00:00");
            alHourlyReport.Add("08:00:00");
            alHourlyReport.Add("09:00:00");
            alHourlyReport.Add("10:00:00");
            alHourlyReport.Add("11:00:00");
            alHourlyReport.Add("12:00:00");
            alHourlyReport.Add("13:00:00");
            alHourlyReport.Add("14:00:00");
            alHourlyReport.Add("15:00:00");
            alHourlyReport.Add("16:00:00");
            alHourlyReport.Add("17:00:00");
            alHourlyReport.Add("18:00:00");
            alHourlyReport.Add("19:00:00");
            alHourlyReport.Add("20:00:00");
            alHourlyReport.Add("21:00:00");
            alHourlyReport.Add("22:00:00");
            alHourlyReport.Add("23:00:00");

            // Checks for directory and reminders
            // if neither can be found, they will be
            // created automatically.

            if (!Directory.Exists(vSysDir))
            {
                Directory.CreateDirectory(vSysDir);
            }

            if (Directory.Exists(vSysDir))
            {
                if (!File.Exists(vSysDir + "Monday" + vFileEx))
                {
                    File.Create(vSysDir + "Monday" + vFileEx);
                }
                else
                {
                    lblDay.Text = "Monday";
                    if (lblDay.Text == DateTime.Now.DayOfWeek.ToString())
                    {
                        // Runs subroutines
                        SubOpenDayOfReminder();
                    }
                }

                if (!File.Exists(vSysDir + "Tuesday" + vFileEx))
                {
                    File.Create(vSysDir + "Tuesday" + vFileEx);
                }
                else
                {
                    lblDay.Text = "Tuesday";
                    if (lblDay.Text == DateTime.Now.DayOfWeek.ToString())
                    {
                        // Runs subroutines
                        SubOpenDayOfReminder();
                    }
                }

                if (!File.Exists(vSysDir + "Wednesday" + vFileEx))
                {
                    File.Create(vSysDir + "Wednesday" + vFileEx);
                }
                else
                {
                    lblDay.Text = "Wednesday";
                    if (lblDay.Text == DateTime.Now.DayOfWeek.ToString())
                    {
                        // Runs subroutines
                        SubOpenDayOfReminder();
                    }
                }

                if (!File.Exists(vSysDir + "Thursday" + vFileEx))
                {
                    File.Create(vSysDir + "Thursday" + vFileEx);
                }
                else
                {
                    lblDay.Text = "Thursday";
                    if (lblDay.Text == DateTime.Now.DayOfWeek.ToString())
                    {
                        // Runs subroutines
                        SubOpenDayOfReminder();
                    }
                }

                if (!File.Exists(vSysDir + "Friday" + vFileEx))
                {
                    File.Create(vSysDir + "Friday" + vFileEx);
                }
                else
                {
                    lblDay.Text = "Friday";
                    if (lblDay.Text == DateTime.Now.DayOfWeek.ToString())
                    {
                        // Runs subroutines
                        SubOpenDayOfReminder();
                    }
                }

                if (!File.Exists(vSysDir + "Saturday" + vFileEx))
                {
                    File.Create(vSysDir + "Saturday" + vFileEx);
                }
                else
                {
                    lblDay.Text = "Saturday";
                    if (lblDay.Text == DateTime.Now.DayOfWeek.ToString())
                    {
                        // Runs subroutines
                        SubOpenDayOfReminder();
                    }
                }

                if (!File.Exists(vSysDir + "Sunday" + vFileEx))
                {
                    File.Create(vSysDir + "Sunday" + vFileEx);
                }
                else
                {
                   lblDay.Text = "Sunday";
                   if (lblDay.Text == DateTime.Now.DayOfWeek.ToString())
                   {
                        // Runs subroutine
                        SubOpenDayOfReminder(); 
                   }
                }
            }

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

            // Default selected voice "David"
            Synth.SelectVoice("Microsoft David Desktop");
            frmlblVoice.Text = "David";

            // Volume preset at 50%
            Synth.Volume = 50;
            lblVolume.Text = Synth.Volume.ToString() + "%";

            // Disables buttons
            BtnDelteReminder.Enabled = false;
            BtnAddReminder.Enabled = false;
            BtnClearReminderWritten.Enabled = false;
            BtnViewedReminder.Enabled = false;
            lblDisplayReminders.Visible = false;

            // Updates reminders
            SubUpdateReminders();

            // Gives focus to text entry field
            RBxReminder.Focus();
                      
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
            else if (lblDay.Text == "Tuesday")
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
            else if (lblDay.Text == "Saturday" || lblDay.Text == "Sunday")
            {
                lblDay.ForeColor = Color.Red;
            }
        }

        private void SubReminderCheck()
        {
            // checks for reminders
            foreach (string vReadReminder in alStoreReminders)
            {
                if (vReadReminder.Contains(DateTime.Now.ToString("HH:mm:ss")))
                {
                    // Turns on speech
                    if (CBxRedRemindersOndAndOff.Checked == true)
                    {
                        // readers reminders to users
                        String vSayThisFirst = "Reading from your reminders.";
                        lblDisplayReminders.Visible = true;
                        lblDisplayReminders.Text = vReadReminder;
                        string vSpeakMessage = vReadReminder.Remove(0, 8);
                        BtnViewedReminder.Enabled = true;
                        Synth.SpeakAsync(vSayThisFirst  + vSpeakMessage);
                    }
                    else
                    {
                        // Displays Reminder to the user
                        lblDisplayReminders.Visible = true;
                        lblDisplayReminders.Text = vReadReminder;
                        BtnViewedReminder.Enabled = true;
                    }
                }
            }
        }               

        private void SubOpenDayOfReminder()
        {
            // Opens reminders for the current day
            alStoreReminders.Clear();
            LBxRem.Items.Clear();

            StreamReader srReminders = new StreamReader(vSysDir + lblDay.Text + vFileEx);
            string vGetReminders;
            while ((vGetReminders = srReminders.ReadLine()) != null)
            {
                alStoreReminders.Add(vGetReminders);
            }
            srReminders.Close();
        }

        private void SubSaveReminders()
        {
            // Saves reminder
            string vDayOfReminder = lblDay.Text + vFileEx;
            StreamWriter swSaveReminders = new StreamWriter(vSysDir + vDayOfReminder);

            foreach (string vSaveReminders in alStoreReminders)
            {
                swSaveReminders.WriteLine(vSaveReminders);

            }
            swSaveReminders.Close();
        }

        private void SubReminderSelected()
        {
            if (LBxRem.SelectedItem != null)
            {
                // Enables buttons
                lblDisplayReminders.Visible = true;
                BtnDelteReminder.Enabled = true;
                BtnViewedReminder.Enabled = true;

                // Displays reminder if one is selected
                lblDisplayReminders.Text = LBxRem.SelectedItem.ToString();
            }

            if (LBxRem.SelectedItem != null)
            {
                BtnAddReminder.Text = "Edit Reminder";

                // Enables button
                BtnAddReminder.Enabled = true;
            }

            if (LBxRem.SelectedItem != null)
            {
                // Enables buttons
                lblDisplayReminders.Visible = true;
                BtnDelteReminder.Enabled = true;
                BtnViewedReminder.Enabled = true;
                lblDisplayReminders.Text = LBxRem.SelectedItem.ToString();
            }
        }

        private void SubHourlyCheck()
        {
            // Speaks on the hour
            // if checbox is checked 
                       
            if (CBxHourlyReportOnAndOff.Checked == true)
            {
                // Sets default message 
                String vSayTheTimeIs = "The Time Is ";

                // Hourly check routine
                foreach (string vSayHour in alHourlyReport)
                {
                    if (BtnShowTime.Text == vSayHour)
                    {
                        // Displays the hour & speaks the reported hour
                       // vNewtime = DateTime.Now.ToString("hh:mm tt");
                        Synth.SpeakAsync(vSayTheTimeIs + DateTime.Now.ToString("hh:mm tt"));
                    }
                }
            }
        }

        private void SubCheckMyNetwork()
        {
            while (true)
            {
                do
                {
                    // Puts thread to sleep for 5 seconds
                    Thread.Sleep(5000);

                    // Checks for network card
                    vCheckConnection = NetworkInterface.GetIsNetworkAvailable();

                    // Checks for internet connection
                    if (vCheckConnection == true)
                    {
                        // If connection is found then
                        // displays the following message
                        lblIntCheck.Text = "Internet Access";

                        // Displays colour
                        lblIntCheck.ForeColor = Color.Green;
                    }
                    else
                    {
                        // If connection is not found then
                        // displays the following message
                        lblIntCheck.Text = "No Internet Access";
                        lblIntCheck.ForeColor = Color.Red;
                    }
                }

                while (vCheckConnection == true);
            }
        }

        private void MyClockV1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Shuts down threads before closing 
            // the application
            MyConnection.Abort();
            MyHourlyCheck.Abort();
            MyReminderCheck.Abort();

            // Runs Subroutine
            SubSaveReminders();
        }

        private void davidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Activates selected voice
            String vVoiceSelected = "You have selected, voice David.";
            frmlblVoice.Text = "David";
            Synth.SelectVoice("Microsoft David Desktop");
            Synth.SpeakAsync(vVoiceSelected);
        }

        private void hazelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Activates selected voice
            String vVoiceSelected = "You have selected, voice Hazel.";
            frmlblVoice.Text = "Hazel";
            Synth.SelectVoice("Microsoft Hazel Desktop");
            Synth.SpeakAsync(vVoiceSelected);
        }

        private void ziraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Activates selected voice
            String vVoiceSelected = "You have selected, voice Zira.";
            frmlblVoice.Text = "Zira";
            Synth.SelectVoice("Microsoft Zira Desktop");
            Synth.SpeakAsync(vVoiceSelected);
        }

        private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Adjusts volume level to
            // Volume = 25%
            String vSayThisVolueLevel = "You selected 25% voice volume";
            Synth.Volume = 25;
            lblVolume.Text = Synth.Volume.ToString() + "%";
            Synth.SpeakAsync(vSayThisVolueLevel);
        }

        private void volumeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Adjusts volume level to
            // Volume = 50%
            String vSayThisVolueLevel = "You selected 50% voice volume";
            Synth.Volume = 50;
            lblVolume.Text  = Synth.Volume.ToString() +"%";
            Synth.SpeakAsync(vSayThisVolueLevel);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Adjusts volume level to
            // Volume = 75%
            String vSayThisVolueLevel = "You selected 75% voice volume";
            Synth.Volume = 75;
            lblVolume.Text = Synth.Volume.ToString() + "%";
            Synth.SpeakAsync(vSayThisVolueLevel);
        }

        private void volumeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Adjusts volume level to
            // Volume = 100%
            String vSayThisVolueLevel = "You selected 100% voice volume";
            Synth.Volume = 100;
            lblVolume.Text = Synth.Volume.ToString() + "%";
            Synth.SpeakAsync(vSayThisVolueLevel);
        }

        private void BtnViewedReminder_Click(object sender, EventArgs e)
        {
            // Displays current date
            lblDisplayReminders.Visible = false;
            BtnShowDate.Text = DateTime.Now.ToString("dd/MM/yy");

            if (LBxRem.SelectedItem != null)
            {
                // Disables buttons
                BtnDelteReminder.Enabled = false;
                BtnViewedReminder.Enabled = false;
                
                // Deselects reminder
                LBxRem.ClearSelected();
            }

            if (LBxRem.SelectedItem == null)
            {
                // Changes name of button
                BtnAddReminder.Text = "Add Reminder";
                BtnAddReminder.Enabled = false;
                BtnViewedReminder.Enabled = false;
            }
        }

        private void BtnClearReminderWritten_Click(object sender, EventArgs e)
        {
            // Clears text
            RBxReminder.Clear();
        }

        private void BtnAddReminder_Click(object sender, EventArgs e)
        {
            // Add reminder
            if (BtnAddReminder.Text == "Add Reminder")
            {
                if (CBxHours.SelectedIndex != -1 && CBxMinutes.SelectedIndex != -1 && CBxSeconds.SelectedIndex != -1)
                {
                    vReminderSetTime = vHSet + ":" + vMSet + ":" + vSSet + " ";
                    alStoreReminders.Add(vReminderSetTime + RBxReminder.Text);
                    SubUpdateReminders();
                    RBxReminder.Clear();

                    // Reset time entry field
                    CBxHours.SelectedIndex = -1;
                    CBxMinutes.SelectedIndex = -1;
                    CBxSeconds.SelectedIndex = -1;
                }
                else
                {
                    // Display no time set error message
                    FrmNoTimeSet frmNoTimeSet = new FrmNoTimeSet();
                    frmNoTimeSet.ShowDialog();
                }
            }

            // Allows user to edit reminder
            else if (BtnAddReminder.Text == "Edit Reminder")
            {
                // Stores copy of reminder
                vtmpReminderStore = lblDisplayReminders.Text;

                // recovers reminder to text field
                RBxReminder.Text = vtmpReminderStore;

                // Disables button
                BtnDelteReminder.Enabled = false;

                // Runs subroutine 
                SubDeleteReminder();

                // Runs subroutine 
                SubUpdateReminders();

                // Changes text button to allow button
                // to perform a different fuction 
                BtnAddReminder.Text = "Update Reminder";
            }
            else if (BtnAddReminder.Text == "Update Reminder")
            {
                // Updates reminder with user changes
                RBxReminder.Focus();
                alStoreReminders.Add(RBxReminder.Text);

                // Runs subroutine
                SubUpdateReminders();
                
                // Clears text field
                RBxReminder.Clear();

                // Changes button text to the 
                // original function
                BtnAddReminder.Text = "Add Reminder";

                // Disables buttons
                BtnAddReminder.Enabled = false;
                BtnDelteReminder.Enabled = false;
            }
        }

        private void CBxHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets the hour of the reminder
            vHSet = CBxHours.Text;
        }

        private void CBxMinutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets the minutes of the reminder
            vMSet = CBxMinutes.Text;
        }

        private void CBxSeconds_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets the seconds of the reminder
            vSSet = CBxSeconds.Text;
        }
                
        private void SubUpdateReminders()
        {
            // Runs Subroutine
            LBxRem.Items.Clear();
            foreach (string vAddingReminder in alStoreReminders)
            {
                LBxRem.Items.Add(vAddingReminder);
            }
            RBxReminder.Focus();
        }

        private void SubDeleteReminder()
        {
            // Deletes selected reminder
            alStoreReminders.RemoveAt(LBxRem.SelectedIndex);

            // Disables buttons
            lblDisplayReminders.Visible = false;
            BtnViewedReminder.Enabled = false;
        }
   
        private void RBxReminder_TextChanged(object sender, EventArgs e)
        {
            if (RBxReminder.Text != "")
            {
                // Enables buttons
                BtnAddReminder.Enabled = true;
                BtnClearReminderWritten.Enabled = true;
            }
            else
            {
                // Disables buttons
                BtnAddReminder.Enabled = false;
                BtnClearReminderWritten.Enabled = false;
            }
        }

        private void BtnDelteReminder_Click(object sender, EventArgs e)
        {
            if (LBxRem.SelectedItem != null)
            {
                // Runs subroutines
                SubDeleteReminder();
                SubUpdateReminders();

                // Disables button
                BtnDelteReminder.Enabled = false;

                // Changes text on button
                if (BtnAddReminder.Text =="Edit Reminder")
                {
                    BtnAddReminder.Text = "Add Reminder";
                   
                    // Disables button
                    BtnAddReminder.Enabled = false;
                }
            }
        }

        private void CBxHourlyReportOnAndOff_CheckedChanged(object sender, EventArgs e)
        {
            if (CBxHourlyReportOnAndOff.Checked == true)
            {
                // Turns on hourly reporting
                string vSayThisHourlyReportOn = "Hourly Report On";
                Synth.SpeakAsync(vSayThisHourlyReportOn);
            }
            else if (CBxHourlyReportOnAndOff.Checked == false)
            {
                // Turns off hourly reporting
                string vSayThisHourlyReportOff = "Hourly Report Off";
                Synth.SpeakAsync(vSayThisHourlyReportOff);
            }
        }

        private void CBxRedRemindersOndAndOff_CheckedChanged(object sender, EventArgs e)
        {
            if (CBxRedRemindersOndAndOff.Checked == true)
            {
                string vSayThisReadRemindersOn = "Read Reminders On";
                // Reports status
                Synth.SpeakAsync(vSayThisReadRemindersOn);
            }
            else if (CBxRedRemindersOndAndOff.Checked == false)
            {
                string vSayThisReadRemindersOff = "Read Reminders Off";
                // Reports status
                Synth.SpeakAsync(vSayThisReadRemindersOff);
            }
        }

        private void LBxRem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vNoTimeSet == false && CBxHours.SelectedIndex == -1 && CBxMinutes.SelectedIndex == -1 && CBxSeconds.SelectedIndex == -1)
            {
                // Runs subroutine
                SubReminderSelected();
            }
            else if (vNoTimeSet == false && CBxHours.SelectedIndex != -1 && CBxMinutes.SelectedIndex != -1 && CBxSeconds.SelectedIndex != -1)
            {
                // Runs subroutine
                SubReminderSelected();
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAboutBox Frm1 = new frmAboutBox();
            Frm1.ShowDialog();
        }

        private void mondayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDay.Text = "Monday";

            if (lblDay.Text == "Monday")
            {
                // Runs subroutines
                SubChangeDayColour();
                SubOpenDayOfReminder();
                SubUpdateReminders();
            }
        }

        private void tuesdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDay.Text = "Tuesday";

            if (lblDay.Text == "Tuesday")
            {
                // Runs subroutines
                SubChangeDayColour();
                SubOpenDayOfReminder();
                SubUpdateReminders();
            }
        }

        private void wednesdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDay.Text = "Wednesday";

            if (lblDay.Text == "Wednesday")
            {
                // Runs subroutines
                SubChangeDayColour();
                SubOpenDayOfReminder();
                SubUpdateReminders();
            }
        }

        private void thursdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDay.Text = "Thursday";

            if (lblDay.Text == "Thurssday")
            {
                // Runs subroutines
                SubChangeDayColour();
                SubOpenDayOfReminder();
                SubUpdateReminders();
            }
        }

        private void fridayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDay.Text = "Friday";

            if (lblDay.Text == "Friday")
            {
                // Runs subroutines
                SubChangeDayColour();
                SubOpenDayOfReminder();
                SubUpdateReminders();
            }
        }

        private void saturdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDay.Text = "Saturday";

            if (lblDay.Text == "Saturday")
            {
                // Runs subroutines
                SubChangeDayColour();
                SubOpenDayOfReminder();
                SubUpdateReminders();
            }
        }

        private void sundayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDay.Text = "Sunday";

            if (lblDay.Text == "Sunday")
            {
                // Runs subroutines
                SubChangeDayColour();
                SubOpenDayOfReminder();
                SubUpdateReminders();
            }
        }

        private void currentReminderDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays current day of the week
            lblDay.Text = vDisplayDay;
            SubOpenDayOfReminder();
            SubUpdateReminders();
            SubChangeDayColour();
        }
        // The following code changes the mouse cursor
        // to a hand or the default cursor
        private void LBxRem_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnDelteReminder_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void CBxHours_Enter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnAddReminder_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void CBxHourlyReportOnAndOff_Enter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void CBxRedRemindersOndAndOff_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnViewedReminder_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void LBxRem_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnDelteReminder_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void CBxHours_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void RBxReminder_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void CBxRedRemindersOndAndOff_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

    }
}