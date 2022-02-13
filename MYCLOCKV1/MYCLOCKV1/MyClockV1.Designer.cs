
namespace MYCLOCKV1
{
    partial class MyClockV1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyClockV1));
            this.lblCodedBy = new System.Windows.Forms.Label();
            this.lblIntCheck = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.BtnShowTime = new System.Windows.Forms.Button();
            this.BtnShowDate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.TmrClockTick = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodedBy
            // 
            this.lblCodedBy.AutoSize = true;
            this.lblCodedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodedBy.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblCodedBy.Location = new System.Drawing.Point(6, 275);
            this.lblCodedBy.Name = "lblCodedBy";
            this.lblCodedBy.Size = new System.Drawing.Size(206, 16);
            this.lblCodedBy.TabIndex = 11;
            this.lblCodedBy.Text = "Coded By Speedy (c) 2022 - 2023";
            // 
            // lblIntCheck
            // 
            this.lblIntCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntCheck.ForeColor = System.Drawing.Color.White;
            this.lblIntCheck.Location = new System.Drawing.Point(6, 155);
            this.lblIntCheck.Name = "lblIntCheck";
            this.lblIntCheck.Size = new System.Drawing.Size(206, 20);
            this.lblIntCheck.TabIndex = 15;
            this.lblIntCheck.Text = "Internet Test";
            this.lblIntCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay
            // 
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(12, 101);
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
            this.BtnShowTime.Location = new System.Drawing.Point(7, 10);
            this.BtnShowTime.Name = "BtnShowTime";
            this.BtnShowTime.Size = new System.Drawing.Size(204, 118);
            this.BtnShowTime.TabIndex = 13;
            this.BtnShowTime.Text = "Clock Display";
            this.BtnShowTime.UseVisualStyleBackColor = false;
            // 
            // BtnShowDate
            // 
            this.BtnShowDate.BackColor = System.Drawing.Color.Black;
            this.BtnShowDate.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowDate.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnShowDate.Location = new System.Drawing.Point(7, 185);
            this.BtnShowDate.Name = "BtnShowDate";
            this.BtnShowDate.Size = new System.Drawing.Size(205, 57);
            this.BtnShowDate.TabIndex = 12;
            this.BtnShowDate.Text = "Date Display";
            this.BtnShowDate.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(10, 129);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(119, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "C# Version 1.0 ";
            // 
            // MyClockV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(219, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblIntCheck);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.BtnShowTime);
            this.Controls.Add(this.BtnShowDate);
            this.Controls.Add(this.lblCodedBy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyClockV1";
            this.Text = "MyClock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblCodedBy;
        internal System.Windows.Forms.Label lblIntCheck;
        internal System.Windows.Forms.Label lblDay;
        internal System.Windows.Forms.Button BtnShowTime;
        internal System.Windows.Forms.Button BtnShowDate;
        internal System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer TmrClockTick;
        internal System.Windows.Forms.Label label1;
    }
}

