
namespace MYCLOCKV1
{
    partial class FrmMyClockV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyClockV));
            this.lblIntCheck = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.BtnShowTime = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.TmrClockTick = new System.Windows.Forms.Timer(this.components);
            this.frmlblHR = new System.Windows.Forms.Label();
            this.CBxHourlyReportOnAndOff = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.davidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hazelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ziraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voiceVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reminderDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mondayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuesdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wednesdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thursdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fridayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saturdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sundayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.currentReminderDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frmlblVoice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEamTime = new System.Windows.Forms.Label();
            this.CBxSeconds = new System.Windows.Forms.ComboBox();
            this.CBxMinutes = new System.Windows.Forms.ComboBox();
            this.BtnViewedReminder = new System.Windows.Forms.Button();
            this.BtnClearReminderWritten = new System.Windows.Forms.Button();
            this.frmlblReminders = new System.Windows.Forms.Label();
            this.RBxReminder = new System.Windows.Forms.RichTextBox();
            this.BtnAddReminder = new System.Windows.Forms.Button();
            this.BtnDelteReminder = new System.Windows.Forms.Button();
            this.LBxRem = new System.Windows.Forms.ListBox();
            this.CBxRedRemindersOndAndOff = new System.Windows.Forms.CheckBox();
            this.BtnShowDate = new System.Windows.Forms.Button();
            this.frmlblReadReminders = new System.Windows.Forms.Label();
            this.lblDisplayReminders = new System.Windows.Forms.Label();
            this.CBxHours = new System.Windows.Forms.ComboBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntCheck
            // 
            this.lblIntCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntCheck.ForeColor = System.Drawing.Color.White;
            this.lblIntCheck.Location = new System.Drawing.Point(222, 185);
            this.lblIntCheck.Name = "lblIntCheck";
            this.lblIntCheck.Size = new System.Drawing.Size(206, 20);
            this.lblIntCheck.TabIndex = 15;
            this.lblIntCheck.Text = "Please Wait...";
            this.lblIntCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay
            // 
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(229, 121);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(195, 20);
            this.lblDay.TabIndex = 14;
            this.lblDay.Text = "Day";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnShowTime
            // 
            this.BtnShowTime.BackColor = System.Drawing.Color.Black;
            this.BtnShowTime.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowTime.ForeColor = System.Drawing.Color.Gold;
            this.BtnShowTime.Location = new System.Drawing.Point(224, 29);
            this.BtnShowTime.Name = "BtnShowTime";
            this.BtnShowTime.Size = new System.Drawing.Size(204, 118);
            this.BtnShowTime.TabIndex = 13;
            this.BtnShowTime.Text = "Clock Display";
            this.BtnShowTime.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(228, 153);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(198, 20);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TmrClockTick
            // 
            this.TmrClockTick.Interval = 1000;
            this.TmrClockTick.Tick += new System.EventHandler(this.TmrClockTick_Tick);
            // 
            // frmlblHR
            // 
            this.frmlblHR.AutoSize = true;
            this.frmlblHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmlblHR.ForeColor = System.Drawing.Color.Cyan;
            this.frmlblHR.Location = new System.Drawing.Point(232, 38);
            this.frmlblHR.Name = "frmlblHR";
            this.frmlblHR.Size = new System.Drawing.Size(19, 12);
            this.frmlblHR.TabIndex = 18;
            this.frmlblHR.Text = "HR";
            this.frmlblHR.Visible = false;
            // 
            // CBxHourlyReportOnAndOff
            // 
            this.CBxHourlyReportOnAndOff.AutoSize = true;
            this.CBxHourlyReportOnAndOff.ForeColor = System.Drawing.Color.Cyan;
            this.CBxHourlyReportOnAndOff.Location = new System.Drawing.Point(227, 281);
            this.CBxHourlyReportOnAndOff.Name = "CBxHourlyReportOnAndOff";
            this.CBxHourlyReportOnAndOff.Size = new System.Drawing.Size(91, 17);
            this.CBxHourlyReportOnAndOff.TabIndex = 19;
            this.CBxHourlyReportOnAndOff.Text = "Hourly Report";
            this.CBxHourlyReportOnAndOff.UseVisualStyleBackColor = true;
            this.CBxHourlyReportOnAndOff.CheckedChanged += new System.EventHandler(this.CBxHourlyReportOnAndOff_CheckedChanged);
            this.CBxHourlyReportOnAndOff.Enter += new System.EventHandler(this.CBxHourlyReportOnAndOff_Enter);
            this.CBxHourlyReportOnAndOff.MouseLeave += new System.EventHandler(this.CBxRedRemindersOndAndOff_MouseLeave);
            this.CBxHourlyReportOnAndOff.MouseHover += new System.EventHandler(this.CBxRedRemindersOndAndOff_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voicesToolStripMenuItem,
            this.voiceVolumeToolStripMenuItem,
            this.reminderDayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 25);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voicesToolStripMenuItem
            // 
            this.voicesToolStripMenuItem.CheckOnClick = true;
            this.voicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.davidToolStripMenuItem,
            this.hazelToolStripMenuItem,
            this.ziraToolStripMenuItem});
            this.voicesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.voicesToolStripMenuItem.Name = "voicesToolStripMenuItem";
            this.voicesToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.voicesToolStripMenuItem.Text = "Voices";
            // 
            // davidToolStripMenuItem
            // 
            this.davidToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.davidToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.davidToolStripMenuItem.Name = "davidToolStripMenuItem";
            this.davidToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.davidToolStripMenuItem.Text = "David";
            this.davidToolStripMenuItem.Click += new System.EventHandler(this.davidToolStripMenuItem_Click);
            // 
            // hazelToolStripMenuItem
            // 
            this.hazelToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.hazelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hazelToolStripMenuItem.Name = "hazelToolStripMenuItem";
            this.hazelToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.hazelToolStripMenuItem.Text = "Hazel";
            this.hazelToolStripMenuItem.Click += new System.EventHandler(this.hazelToolStripMenuItem_Click);
            // 
            // ziraToolStripMenuItem
            // 
            this.ziraToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ziraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ziraToolStripMenuItem.Name = "ziraToolStripMenuItem";
            this.ziraToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.ziraToolStripMenuItem.Text = "Zira";
            this.ziraToolStripMenuItem.Click += new System.EventHandler(this.ziraToolStripMenuItem_Click);
            // 
            // voiceVolumeToolStripMenuItem
            // 
            this.voiceVolumeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volumeToolStripMenuItem,
            this.volumeToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.volumeToolStripMenuItem2});
            this.voiceVolumeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.voiceVolumeToolStripMenuItem.Name = "voiceVolumeToolStripMenuItem";
            this.voiceVolumeToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.voiceVolumeToolStripMenuItem.Text = "Voice Volume";
            // 
            // volumeToolStripMenuItem
            // 
            this.volumeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.volumeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            this.volumeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.volumeToolStripMenuItem.Text = "25% Volume";
            this.volumeToolStripMenuItem.Click += new System.EventHandler(this.volumeToolStripMenuItem_Click);
            // 
            // volumeToolStripMenuItem1
            // 
            this.volumeToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.volumeToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.volumeToolStripMenuItem1.Name = "volumeToolStripMenuItem1";
            this.volumeToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.volumeToolStripMenuItem1.Text = "50% Volume";
            this.volumeToolStripMenuItem1.Click += new System.EventHandler(this.volumeToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem2.Text = "75% Volume";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // volumeToolStripMenuItem2
            // 
            this.volumeToolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            this.volumeToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.volumeToolStripMenuItem2.Name = "volumeToolStripMenuItem2";
            this.volumeToolStripMenuItem2.Size = new System.Drawing.Size(155, 22);
            this.volumeToolStripMenuItem2.Text = "100% Volume";
            this.volumeToolStripMenuItem2.Click += new System.EventHandler(this.volumeToolStripMenuItem2_Click);
            // 
            // reminderDayToolStripMenuItem
            // 
            this.reminderDayToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.reminderDayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mondayToolStripMenuItem,
            this.tuesdayToolStripMenuItem,
            this.wednesdayToolStripMenuItem,
            this.thursdayToolStripMenuItem,
            this.fridayToolStripMenuItem,
            this.saturdayToolStripMenuItem,
            this.sundayToolStripMenuItem,
            this.toolStripSeparator1,
            this.currentReminderDayToolStripMenuItem});
            this.reminderDayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reminderDayToolStripMenuItem.Name = "reminderDayToolStripMenuItem";
            this.reminderDayToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
            this.reminderDayToolStripMenuItem.Text = "Reminder Day";
            // 
            // mondayToolStripMenuItem
            // 
            this.mondayToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mondayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mondayToolStripMenuItem.Name = "mondayToolStripMenuItem";
            this.mondayToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.mondayToolStripMenuItem.Text = "Monday";
            this.mondayToolStripMenuItem.Click += new System.EventHandler(this.mondayToolStripMenuItem_Click);
            // 
            // tuesdayToolStripMenuItem
            // 
            this.tuesdayToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.tuesdayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tuesdayToolStripMenuItem.Name = "tuesdayToolStripMenuItem";
            this.tuesdayToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.tuesdayToolStripMenuItem.Text = "Tuesday";
            this.tuesdayToolStripMenuItem.Click += new System.EventHandler(this.tuesdayToolStripMenuItem_Click);
            // 
            // wednesdayToolStripMenuItem
            // 
            this.wednesdayToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.wednesdayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.wednesdayToolStripMenuItem.Name = "wednesdayToolStripMenuItem";
            this.wednesdayToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.wednesdayToolStripMenuItem.Text = "Wednesday";
            this.wednesdayToolStripMenuItem.Click += new System.EventHandler(this.wednesdayToolStripMenuItem_Click);
            // 
            // thursdayToolStripMenuItem
            // 
            this.thursdayToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.thursdayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thursdayToolStripMenuItem.Name = "thursdayToolStripMenuItem";
            this.thursdayToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.thursdayToolStripMenuItem.Text = "Thursday";
            this.thursdayToolStripMenuItem.Click += new System.EventHandler(this.thursdayToolStripMenuItem_Click);
            // 
            // fridayToolStripMenuItem
            // 
            this.fridayToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.fridayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fridayToolStripMenuItem.Name = "fridayToolStripMenuItem";
            this.fridayToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.fridayToolStripMenuItem.Text = "Friday";
            this.fridayToolStripMenuItem.Click += new System.EventHandler(this.fridayToolStripMenuItem_Click);
            // 
            // saturdayToolStripMenuItem
            // 
            this.saturdayToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.saturdayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saturdayToolStripMenuItem.Name = "saturdayToolStripMenuItem";
            this.saturdayToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.saturdayToolStripMenuItem.Text = "Saturday";
            this.saturdayToolStripMenuItem.Click += new System.EventHandler(this.saturdayToolStripMenuItem_Click);
            // 
            // sundayToolStripMenuItem
            // 
            this.sundayToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.sundayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sundayToolStripMenuItem.Name = "sundayToolStripMenuItem";
            this.sundayToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.sundayToolStripMenuItem.Text = "Sunday";
            this.sundayToolStripMenuItem.Click += new System.EventHandler(this.sundayToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // currentReminderDayToolStripMenuItem
            // 
            this.currentReminderDayToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.currentReminderDayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.currentReminderDayToolStripMenuItem.Name = "currentReminderDayToolStripMenuItem";
            this.currentReminderDayToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.currentReminderDayToolStripMenuItem.Text = "Current Reminder Day";
            this.currentReminderDayToolStripMenuItem.Click += new System.EventHandler(this.currentReminderDayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // frmlblVoice
            // 
            this.frmlblVoice.AutoSize = true;
            this.frmlblVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmlblVoice.ForeColor = System.Drawing.Color.Cyan;
            this.frmlblVoice.Location = new System.Drawing.Point(257, 38);
            this.frmlblVoice.Name = "frmlblVoice";
            this.frmlblVoice.Size = new System.Drawing.Size(29, 12);
            this.frmlblVoice.TabIndex = 21;
            this.frmlblVoice.Text = "Voice";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblEamTime);
            this.panel1.Controls.Add(this.CBxSeconds);
            this.panel1.Controls.Add(this.CBxMinutes);
            this.panel1.Controls.Add(this.BtnViewedReminder);
            this.panel1.Controls.Add(this.BtnClearReminderWritten);
            this.panel1.Controls.Add(this.frmlblReminders);
            this.panel1.Controls.Add(this.RBxReminder);
            this.panel1.Controls.Add(this.BtnAddReminder);
            this.panel1.Controls.Add(this.BtnDelteReminder);
            this.panel1.Controls.Add(this.LBxRem);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 294);
            this.panel1.TabIndex = 22;
            // 
            // lblEamTime
            // 
            this.lblEamTime.AutoSize = true;
            this.lblEamTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEamTime.ForeColor = System.Drawing.Color.White;
            this.lblEamTime.Location = new System.Drawing.Point(11, 144);
            this.lblEamTime.Name = "lblEamTime";
            this.lblEamTime.Size = new System.Drawing.Size(47, 12);
            this.lblEamTime.TabIndex = 29;
            this.lblEamTime.Text = "Rem Time";
            // 
            // CBxSeconds
            // 
            this.CBxSeconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBxSeconds.FormattingEnabled = true;
            this.CBxSeconds.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.CBxSeconds.Location = new System.Drawing.Point(144, 140);
            this.CBxSeconds.Name = "CBxSeconds";
            this.CBxSeconds.Size = new System.Drawing.Size(43, 21);
            this.CBxSeconds.TabIndex = 28;
            this.CBxSeconds.SelectedIndexChanged += new System.EventHandler(this.CBxSeconds_SelectedIndexChanged);
            this.CBxSeconds.Enter += new System.EventHandler(this.CBxHours_Enter);
            this.CBxSeconds.MouseLeave += new System.EventHandler(this.CBxHours_MouseLeave);
            // 
            // CBxMinutes
            // 
            this.CBxMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBxMinutes.FormattingEnabled = true;
            this.CBxMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.CBxMinutes.Location = new System.Drawing.Point(97, 140);
            this.CBxMinutes.Name = "CBxMinutes";
            this.CBxMinutes.Size = new System.Drawing.Size(43, 21);
            this.CBxMinutes.TabIndex = 27;
            this.CBxMinutes.SelectedIndexChanged += new System.EventHandler(this.CBxMinutes_SelectedIndexChanged);
            this.CBxMinutes.Enter += new System.EventHandler(this.CBxHours_Enter);
            this.CBxMinutes.MouseLeave += new System.EventHandler(this.CBxHours_MouseLeave);
            // 
            // BtnViewedReminder
            // 
            this.BtnViewedReminder.ForeColor = System.Drawing.Color.Black;
            this.BtnViewedReminder.Location = new System.Drawing.Point(66, 243);
            this.BtnViewedReminder.Name = "BtnViewedReminder";
            this.BtnViewedReminder.Size = new System.Drawing.Size(63, 37);
            this.BtnViewedReminder.TabIndex = 11;
            this.BtnViewedReminder.Text = "Viewed Reminder";
            this.BtnViewedReminder.UseVisualStyleBackColor = true;
            this.BtnViewedReminder.Click += new System.EventHandler(this.BtnViewedReminder_Click);
            this.BtnViewedReminder.MouseLeave += new System.EventHandler(this.RBxReminder_MouseLeave);
            this.BtnViewedReminder.MouseHover += new System.EventHandler(this.BtnAddReminder_MouseHover);
            // 
            // BtnClearReminderWritten
            // 
            this.BtnClearReminderWritten.ForeColor = System.Drawing.Color.Black;
            this.BtnClearReminderWritten.Location = new System.Drawing.Point(128, 243);
            this.BtnClearReminderWritten.Name = "BtnClearReminderWritten";
            this.BtnClearReminderWritten.Size = new System.Drawing.Size(63, 37);
            this.BtnClearReminderWritten.TabIndex = 8;
            this.BtnClearReminderWritten.Text = "Clear Reminder";
            this.BtnClearReminderWritten.UseVisualStyleBackColor = true;
            this.BtnClearReminderWritten.Click += new System.EventHandler(this.BtnClearReminderWritten_Click);
            this.BtnClearReminderWritten.MouseLeave += new System.EventHandler(this.RBxReminder_MouseLeave);
            this.BtnClearReminderWritten.MouseHover += new System.EventHandler(this.BtnAddReminder_MouseHover);
            // 
            // frmlblReminders
            // 
            this.frmlblReminders.AutoSize = true;
            this.frmlblReminders.ForeColor = System.Drawing.Color.White;
            this.frmlblReminders.Location = new System.Drawing.Point(8, 18);
            this.frmlblReminders.Name = "frmlblReminders";
            this.frmlblReminders.Size = new System.Drawing.Size(57, 13);
            this.frmlblReminders.TabIndex = 7;
            this.frmlblReminders.Text = "Reminders";
            // 
            // RBxReminder
            // 
            this.RBxReminder.BackColor = System.Drawing.Color.MediumBlue;
            this.RBxReminder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RBxReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBxReminder.ForeColor = System.Drawing.Color.Yellow;
            this.RBxReminder.Location = new System.Drawing.Point(11, 168);
            this.RBxReminder.Name = "RBxReminder";
            this.RBxReminder.Size = new System.Drawing.Size(179, 69);
            this.RBxReminder.TabIndex = 0;
            this.RBxReminder.TabStop = false;
            this.RBxReminder.Text = "";
            this.RBxReminder.TextChanged += new System.EventHandler(this.RBxReminder_TextChanged);
            this.RBxReminder.MouseLeave += new System.EventHandler(this.RBxReminder_MouseLeave);
            // 
            // BtnAddReminder
            // 
            this.BtnAddReminder.ForeColor = System.Drawing.Color.Black;
            this.BtnAddReminder.Location = new System.Drawing.Point(4, 243);
            this.BtnAddReminder.Name = "BtnAddReminder";
            this.BtnAddReminder.Size = new System.Drawing.Size(63, 37);
            this.BtnAddReminder.TabIndex = 2;
            this.BtnAddReminder.Text = "Add Reminder";
            this.BtnAddReminder.UseVisualStyleBackColor = true;
            this.BtnAddReminder.Click += new System.EventHandler(this.BtnAddReminder_Click);
            this.BtnAddReminder.MouseLeave += new System.EventHandler(this.RBxReminder_MouseLeave);
            this.BtnAddReminder.MouseHover += new System.EventHandler(this.BtnAddReminder_MouseHover);
            // 
            // BtnDelteReminder
            // 
            this.BtnDelteReminder.ForeColor = System.Drawing.Color.Black;
            this.BtnDelteReminder.Location = new System.Drawing.Point(9, 112);
            this.BtnDelteReminder.Name = "BtnDelteReminder";
            this.BtnDelteReminder.Size = new System.Drawing.Size(181, 22);
            this.BtnDelteReminder.TabIndex = 1;
            this.BtnDelteReminder.Text = "Delete Reminder";
            this.BtnDelteReminder.UseVisualStyleBackColor = true;
            this.BtnDelteReminder.Click += new System.EventHandler(this.BtnDelteReminder_Click);
            this.BtnDelteReminder.MouseLeave += new System.EventHandler(this.BtnDelteReminder_MouseLeave);
            this.BtnDelteReminder.MouseHover += new System.EventHandler(this.BtnDelteReminder_MouseHover);
            // 
            // LBxRem
            // 
            this.LBxRem.BackColor = System.Drawing.Color.MediumBlue;
            this.LBxRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBxRem.ForeColor = System.Drawing.Color.Yellow;
            this.LBxRem.FormattingEnabled = true;
            this.LBxRem.ItemHeight = 16;
            this.LBxRem.Location = new System.Drawing.Point(10, 37);
            this.LBxRem.Name = "LBxRem";
            this.LBxRem.Size = new System.Drawing.Size(180, 68);
            this.LBxRem.TabIndex = 0;
            this.LBxRem.SelectedIndexChanged += new System.EventHandler(this.LBxRem_SelectedIndexChanged);
            this.LBxRem.MouseEnter += new System.EventHandler(this.LBxRem_MouseEnter);
            this.LBxRem.MouseLeave += new System.EventHandler(this.LBxRem_MouseLeave);
            // 
            // CBxRedRemindersOndAndOff
            // 
            this.CBxRedRemindersOndAndOff.AutoSize = true;
            this.CBxRedRemindersOndAndOff.ForeColor = System.Drawing.Color.White;
            this.CBxRedRemindersOndAndOff.Location = new System.Drawing.Point(227, 300);
            this.CBxRedRemindersOndAndOff.Name = "CBxRedRemindersOndAndOff";
            this.CBxRedRemindersOndAndOff.Size = new System.Drawing.Size(105, 17);
            this.CBxRedRemindersOndAndOff.TabIndex = 12;
            this.CBxRedRemindersOndAndOff.Text = "Read Reminders";
            this.CBxRedRemindersOndAndOff.UseVisualStyleBackColor = true;
            this.CBxRedRemindersOndAndOff.CheckedChanged += new System.EventHandler(this.CBxRedRemindersOndAndOff_CheckedChanged);
            this.CBxRedRemindersOndAndOff.Enter += new System.EventHandler(this.CBxHourlyReportOnAndOff_Enter);
            this.CBxRedRemindersOndAndOff.MouseLeave += new System.EventHandler(this.CBxRedRemindersOndAndOff_MouseLeave);
            this.CBxRedRemindersOndAndOff.MouseHover += new System.EventHandler(this.CBxRedRemindersOndAndOff_MouseHover);
            // 
            // BtnShowDate
            // 
            this.BtnShowDate.BackColor = System.Drawing.Color.Black;
            this.BtnShowDate.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowDate.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnShowDate.Location = new System.Drawing.Point(224, 216);
            this.BtnShowDate.Name = "BtnShowDate";
            this.BtnShowDate.Size = new System.Drawing.Size(205, 57);
            this.BtnShowDate.TabIndex = 12;
            this.BtnShowDate.Text = "Date Display";
            this.BtnShowDate.UseVisualStyleBackColor = false;
            // 
            // frmlblReadReminders
            // 
            this.frmlblReadReminders.AutoSize = true;
            this.frmlblReadReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmlblReadReminders.ForeColor = System.Drawing.Color.Violet;
            this.frmlblReadReminders.Location = new System.Drawing.Point(292, 38);
            this.frmlblReadReminders.Name = "frmlblReadReminders";
            this.frmlblReadReminders.Size = new System.Drawing.Size(25, 12);
            this.frmlblReadReminders.TabIndex = 24;
            this.frmlblReadReminders.Text = "Rem";
            // 
            // lblDisplayReminders
            // 
            this.lblDisplayReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayReminders.ForeColor = System.Drawing.Color.Violet;
            this.lblDisplayReminders.Location = new System.Drawing.Point(230, 223);
            this.lblDisplayReminders.Name = "lblDisplayReminders";
            this.lblDisplayReminders.Size = new System.Drawing.Size(194, 45);
            this.lblDisplayReminders.TabIndex = 25;
            this.lblDisplayReminders.Text = "DisplayReminders";
            // 
            // CBxHours
            // 
            this.CBxHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBxHours.FormattingEnabled = true;
            this.CBxHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.CBxHours.Location = new System.Drawing.Point(70, 169);
            this.CBxHours.Name = "CBxHours";
            this.CBxHours.Size = new System.Drawing.Size(35, 21);
            this.CBxHours.TabIndex = 26;
            this.CBxHours.SelectedIndexChanged += new System.EventHandler(this.CBxHours_SelectedIndexChanged);
            this.CBxHours.Enter += new System.EventHandler(this.CBxHours_Enter);
            this.CBxHours.MouseLeave += new System.EventHandler(this.CBxHours_MouseLeave);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.Orange;
            this.lblVolume.Location = new System.Drawing.Point(321, 38);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(22, 12);
            this.lblVolume.TabIndex = 27;
            this.lblVolume.Text = "Vol";
            // 
            // FrmMyClockV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(443, 340);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.CBxHours);
            this.Controls.Add(this.lblDisplayReminders);
            this.Controls.Add(this.frmlblReadReminders);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.frmlblVoice);
            this.Controls.Add(this.CBxHourlyReportOnAndOff);
            this.Controls.Add(this.frmlblHR);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblIntCheck);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.CBxRedRemindersOndAndOff);
            this.Controls.Add(this.BtnShowTime);
            this.Controls.Add(this.BtnShowDate);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMyClockV";
            this.Text = "MyClock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyClockV1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label lblIntCheck;
        internal System.Windows.Forms.Label lblDay;
        internal System.Windows.Forms.Button BtnShowTime;
        internal System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer TmrClockTick;
        internal System.Windows.Forms.Label frmlblHR;
        private System.Windows.Forms.CheckBox CBxHourlyReportOnAndOff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem davidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hazelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ziraToolStripMenuItem;
        internal System.Windows.Forms.Label frmlblVoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox RBxReminder;
        private System.Windows.Forms.Button BtnAddReminder;
        private System.Windows.Forms.Button BtnDelteReminder;
        private System.Windows.Forms.ListBox LBxRem;
        private System.Windows.Forms.Button BtnClearReminderWritten;
        private System.Windows.Forms.Label frmlblReminders;
        internal System.Windows.Forms.Button BtnShowDate;
        private System.Windows.Forms.Button BtnViewedReminder;
        private System.Windows.Forms.CheckBox CBxRedRemindersOndAndOff;
        internal System.Windows.Forms.Label frmlblReadReminders;
        private System.Windows.Forms.Label lblDisplayReminders;
        private System.Windows.Forms.ComboBox CBxHours;
        private System.Windows.Forms.ComboBox CBxMinutes;
        private System.Windows.Forms.ComboBox CBxSeconds;
        internal System.Windows.Forms.Label lblEamTime;
        private System.Windows.Forms.ToolStripMenuItem voiceVolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem2;
        internal System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reminderDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mondayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuesdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wednesdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thursdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fridayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saturdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sundayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem currentReminderDayToolStripMenuItem;
    }
}

