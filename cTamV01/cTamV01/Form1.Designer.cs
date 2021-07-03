namespace cTamV01
{
    partial class TamV1
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
            this.LBxMyMessages = new System.Windows.Forms.ListBox();
            this.BtnChoiceOne = new System.Windows.Forms.Button();
            this.BtnChoiceTwo = new System.Windows.Forms.Button();
            this.RTxTypedAMessages = new System.Windows.Forms.RichTextBox();
            this.LblMessaageCount = new System.Windows.Forms.Label();
            this.LblMessages = new System.Windows.Forms.Label();
            this.LblCharacterCountRes = new System.Windows.Forms.Label();
            this.LblCharacterCount = new System.Windows.Forms.Label();
            this.LblVerNo = new System.Windows.Forms.Label();
            this.LblHomeMadeSoftware = new System.Windows.Forms.Label();
            this.PBxEditModeLED = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBxEditModeLED)).BeginInit();
            this.SuspendLayout();
            // 
            // LBxMyMessages
            // 
            this.LBxMyMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBxMyMessages.FormattingEnabled = true;
            this.LBxMyMessages.ItemHeight = 20;
            this.LBxMyMessages.Location = new System.Drawing.Point(12, 31);
            this.LBxMyMessages.Name = "LBxMyMessages";
            this.LBxMyMessages.Size = new System.Drawing.Size(228, 104);
            this.LBxMyMessages.TabIndex = 0;
            this.LBxMyMessages.SelectedIndexChanged += new System.EventHandler(this.LBxMyMessages_SelectedIndexChanged);
            this.LBxMyMessages.MouseEnter += new System.EventHandler(this.LBxMyMessages_MouseEnter);
            this.LBxMyMessages.MouseLeave += new System.EventHandler(this.LBxMyMessages_MouseLeave);
            // 
            // BtnChoiceOne
            // 
            this.BtnChoiceOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChoiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChoiceOne.Location = new System.Drawing.Point(12, 179);
            this.BtnChoiceOne.Name = "BtnChoiceOne";
            this.BtnChoiceOne.Size = new System.Drawing.Size(103, 33);
            this.BtnChoiceOne.TabIndex = 1;
            this.BtnChoiceOne.Text = "Copy";
            this.BtnChoiceOne.UseVisualStyleBackColor = true;
            this.BtnChoiceOne.Click += new System.EventHandler(this.BtnChoiceOne_Click);
            this.BtnChoiceOne.MouseLeave += new System.EventHandler(this.BtnChoiceOne_MouseLeave);
            this.BtnChoiceOne.MouseHover += new System.EventHandler(this.BtnChoiceOne_MouseHover);
            // 
            // BtnChoiceTwo
            // 
            this.BtnChoiceTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChoiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChoiceTwo.Location = new System.Drawing.Point(137, 179);
            this.BtnChoiceTwo.Name = "BtnChoiceTwo";
            this.BtnChoiceTwo.Size = new System.Drawing.Size(103, 33);
            this.BtnChoiceTwo.TabIndex = 2;
            this.BtnChoiceTwo.Text = "Delete";
            this.BtnChoiceTwo.UseVisualStyleBackColor = true;
            this.BtnChoiceTwo.Click += new System.EventHandler(this.BtnChoiceTwo_Click);
            this.BtnChoiceTwo.MouseLeave += new System.EventHandler(this.BtnChoiceTwo_MouseLeave);
            this.BtnChoiceTwo.MouseHover += new System.EventHandler(this.BtnChoiceTwo_MouseHover);
            // 
            // RTxTypedAMessages
            // 
            this.RTxTypedAMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTxTypedAMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxTypedAMessages.Location = new System.Drawing.Point(12, 249);
            this.RTxTypedAMessages.Name = "RTxTypedAMessages";
            this.RTxTypedAMessages.Size = new System.Drawing.Size(228, 128);
            this.RTxTypedAMessages.TabIndex = 0;
            this.RTxTypedAMessages.Text = "";
            this.RTxTypedAMessages.TextChanged += new System.EventHandler(this.RTxTypedAMessages_TextChanged);
            this.RTxTypedAMessages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RTxTypedAMessages_KeyDown);
            this.RTxTypedAMessages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RTxTypedAMessages_KeyUp);
            // 
            // LblMessaageCount
            // 
            this.LblMessaageCount.AutoSize = true;
            this.LblMessaageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessaageCount.Location = new System.Drawing.Point(107, 145);
            this.LblMessaageCount.Name = "LblMessaageCount";
            this.LblMessaageCount.Size = new System.Drawing.Size(18, 20);
            this.LblMessaageCount.TabIndex = 15;
            this.LblMessaageCount.Text = "0";
            // 
            // LblMessages
            // 
            this.LblMessages.AutoSize = true;
            this.LblMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessages.Location = new System.Drawing.Point(16, 145);
            this.LblMessages.Name = "LblMessages";
            this.LblMessages.Size = new System.Drawing.Size(82, 20);
            this.LblMessages.TabIndex = 14;
            this.LblMessages.Text = "Messages";
            // 
            // LblCharacterCountRes
            // 
            this.LblCharacterCountRes.AutoSize = true;
            this.LblCharacterCountRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCharacterCountRes.Location = new System.Drawing.Point(138, 381);
            this.LblCharacterCountRes.Name = "LblCharacterCountRes";
            this.LblCharacterCountRes.Size = new System.Drawing.Size(18, 20);
            this.LblCharacterCountRes.TabIndex = 17;
            this.LblCharacterCountRes.Text = "0";
            // 
            // LblCharacterCount
            // 
            this.LblCharacterCount.AutoSize = true;
            this.LblCharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCharacterCount.Location = new System.Drawing.Point(6, 381);
            this.LblCharacterCount.Name = "LblCharacterCount";
            this.LblCharacterCount.Size = new System.Drawing.Size(126, 20);
            this.LblCharacterCount.TabIndex = 16;
            this.LblCharacterCount.Text = "Character Count";
            // 
            // LblVerNo
            // 
            this.LblVerNo.AutoSize = true;
            this.LblVerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerNo.Location = new System.Drawing.Point(143, 403);
            this.LblVerNo.Name = "LblVerNo";
            this.LblVerNo.Size = new System.Drawing.Size(89, 20);
            this.LblVerNo.TabIndex = 18;
            this.LblVerNo.Text = "Version 1.0";
            // 
            // LblHomeMadeSoftware
            // 
            this.LblHomeMadeSoftware.AutoSize = true;
            this.LblHomeMadeSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHomeMadeSoftware.ForeColor = System.Drawing.Color.Gold;
            this.LblHomeMadeSoftware.Location = new System.Drawing.Point(16, 438);
            this.LblHomeMadeSoftware.Name = "LblHomeMadeSoftware";
            this.LblHomeMadeSoftware.Size = new System.Drawing.Size(219, 13);
            this.LblHomeMadeSoftware.TabIndex = 19;
            this.LblHomeMadeSoftware.Text = "Home Made Software (c) 2021 - 2022";
            this.LblHomeMadeSoftware.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBxEditModeLED
            // 
            this.PBxEditModeLED.BackColor = System.Drawing.Color.Green;
            this.PBxEditModeLED.Location = new System.Drawing.Point(186, 224);
            this.PBxEditModeLED.Name = "PBxEditModeLED";
            this.PBxEditModeLED.Size = new System.Drawing.Size(51, 10);
            this.PBxEditModeLED.TabIndex = 20;
            this.PBxEditModeLED.TabStop = false;
            // 
            // TamV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(252, 465);
            this.Controls.Add(this.PBxEditModeLED);
            this.Controls.Add(this.LblHomeMadeSoftware);
            this.Controls.Add(this.LblVerNo);
            this.Controls.Add(this.LblCharacterCountRes);
            this.Controls.Add(this.LblCharacterCount);
            this.Controls.Add(this.LblMessaageCount);
            this.Controls.Add(this.LblMessages);
            this.Controls.Add(this.RTxTypedAMessages);
            this.Controls.Add(this.BtnChoiceTwo);
            this.Controls.Add(this.BtnChoiceOne);
            this.Controls.Add(this.LBxMyMessages);
            this.Name = "TamV1";
            this.Text = "Tam V1 in C#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TamV1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PBxEditModeLED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBxMyMessages;
        private System.Windows.Forms.Button BtnChoiceOne;
        private System.Windows.Forms.Button BtnChoiceTwo;
        private System.Windows.Forms.RichTextBox RTxTypedAMessages;
   
        internal System.Windows.Forms.Label LblMessaageCount;
        internal System.Windows.Forms.Label LblMessages;
        internal System.Windows.Forms.Label LblCharacterCountRes;
        internal System.Windows.Forms.Label LblCharacterCount;
        internal System.Windows.Forms.Label LblVerNo;
        internal System.Windows.Forms.Label LblHomeMadeSoftware;
        private System.Windows.Forms.PictureBox PBxEditModeLED;
    }
}

