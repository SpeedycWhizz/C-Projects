namespace TEST
{
    partial class MyNotepadV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNotepadV2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontcolourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textAlignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblFilename = new System.Windows.Forms.Label();
            this.TBxFilename = new System.Windows.Forms.TextBox();
            this.LBxListMyFiles = new System.Windows.Forms.ListBox();
            this.BtnOption = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RTPreview = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RTxWritingPad = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FontDBx = new System.Windows.Forms.FontDialog();
            this.ColourDBx = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fontcolourToolStripMenuItem,
            this.textAlignmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.sAveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // sAveToolStripMenuItem
            // 
            this.sAveToolStripMenuItem.Name = "sAveToolStripMenuItem";
            this.sAveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.sAveToolStripMenuItem.Text = "Save";
            this.sAveToolStripMenuItem.Click += new System.EventHandler(this.sAveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // fontcolourToolStripMenuItem
            // 
            this.fontcolourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.fontcolourToolStripMenuItem.Name = "fontcolourToolStripMenuItem";
            this.fontcolourToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.fontcolourToolStripMenuItem.Text = "Font / Colour";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.colourToolStripMenuItem.Text = "Colour";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // textAlignmentToolStripMenuItem
            // 
            this.textAlignmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textLeftToolStripMenuItem,
            this.textRightToolStripMenuItem,
            this.textCentreToolStripMenuItem});
            this.textAlignmentToolStripMenuItem.Name = "textAlignmentToolStripMenuItem";
            this.textAlignmentToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.textAlignmentToolStripMenuItem.Text = "Text Alignment";
            // 
            // textLeftToolStripMenuItem
            // 
            this.textLeftToolStripMenuItem.Name = "textLeftToolStripMenuItem";
            this.textLeftToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.textLeftToolStripMenuItem.Text = "Text - Left";
            this.textLeftToolStripMenuItem.Click += new System.EventHandler(this.textLeftToolStripMenuItem_Click);
            // 
            // textRightToolStripMenuItem
            // 
            this.textRightToolStripMenuItem.Name = "textRightToolStripMenuItem";
            this.textRightToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.textRightToolStripMenuItem.Text = "Text - Right";
            this.textRightToolStripMenuItem.Click += new System.EventHandler(this.textRightToolStripMenuItem_Click);
            // 
            // textCentreToolStripMenuItem
            // 
            this.textCentreToolStripMenuItem.Name = "textCentreToolStripMenuItem";
            this.textCentreToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.textCentreToolStripMenuItem.Text = "Text - Centre";
            this.textCentreToolStripMenuItem.Click += new System.EventHandler(this.textCentreToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LblFilename);
            this.panel1.Controls.Add(this.TBxFilename);
            this.panel1.Controls.Add(this.LBxListMyFiles);
            this.panel1.Controls.Add(this.BtnOption);
            this.panel1.Location = new System.Drawing.Point(6, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 176);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Font Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Font Colour";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(161, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(103, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LblFilename
            // 
            this.LblFilename.AutoSize = true;
            this.LblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilename.ForeColor = System.Drawing.Color.White;
            this.LblFilename.Location = new System.Drawing.Point(9, 160);
            this.LblFilename.Name = "LblFilename";
            this.LblFilename.Size = new System.Drawing.Size(70, 16);
            this.LblFilename.TabIndex = 3;
            this.LblFilename.Text = "Filename :";
            // 
            // TBxFilename
            // 
            this.TBxFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBxFilename.Location = new System.Drawing.Point(79, 156);
            this.TBxFilename.Name = "TBxFilename";
            this.TBxFilename.Size = new System.Drawing.Size(131, 21);
            this.TBxFilename.TabIndex = 2;
            // 
            // LBxListMyFiles
            // 
            this.LBxListMyFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBxListMyFiles.FormattingEnabled = true;
            this.LBxListMyFiles.Location = new System.Drawing.Point(0, 0);
            this.LBxListMyFiles.Name = "LBxListMyFiles";
            this.LBxListMyFiles.Size = new System.Drawing.Size(210, 108);
            this.LBxListMyFiles.TabIndex = 0;
            this.LBxListMyFiles.SelectedIndexChanged += new System.EventHandler(this.LBxListMyFiles_SelectedIndexChanged);
            // 
            // BtnOption
            // 
            this.BtnOption.Location = new System.Drawing.Point(6, 130);
            this.BtnOption.Name = "BtnOption";
            this.BtnOption.Size = new System.Drawing.Size(75, 23);
            this.BtnOption.TabIndex = 1;
            this.BtnOption.Text = "Open";
            this.BtnOption.UseVisualStyleBackColor = true;
            this.BtnOption.Click += new System.EventHandler(this.BtnOption_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RTPreview);
            this.panel2.Location = new System.Drawing.Point(6, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 176);
            this.panel2.TabIndex = 2;
            // 
            // RTPreview
            // 
            this.RTPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTPreview.Location = new System.Drawing.Point(0, 0);
            this.RTPreview.Name = "RTPreview";
            this.RTPreview.Size = new System.Drawing.Size(210, 176);
            this.RTPreview.TabIndex = 0;
            this.RTPreview.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RTxWritingPad);
            this.panel3.Location = new System.Drawing.Point(223, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 359);
            this.panel3.TabIndex = 3;
            // 
            // RTxWritingPad
            // 
            this.RTxWritingPad.AcceptsTab = true;
            this.RTxWritingPad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxWritingPad.ContextMenuStrip = this.contextMenuStrip1;
            this.RTxWritingPad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxWritingPad.Location = new System.Drawing.Point(0, 0);
            this.RTxWritingPad.Name = "RTxWritingPad";
            this.RTxWritingPad.Size = new System.Drawing.Size(385, 359);
            this.RTxWritingPad.TabIndex = 0;
            this.RTxWritingPad.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.cuyToolStripMenuItem,
            this.pasteToolStripMenuItem1,
            this.toolStripSeparator3,
            this.selectAllToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 98);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // cuyToolStripMenuItem
            // 
            this.cuyToolStripMenuItem.Name = "cuyToolStripMenuItem";
            this.cuyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cuyToolStripMenuItem.Text = "Cut";
            this.cuyToolStripMenuItem.Click += new System.EventHandler(this.cuyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(130, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.selectAllToolStripMenuItem1.Text = "Select All";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.selectAllToolStripMenuItem1_Click);
            // 
            // MyNotepadV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(615, 397);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MyNotepadV2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyNotepad in C#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnOption;
        private System.Windows.Forms.ListBox LBxListMyFiles;
        private System.Windows.Forms.RichTextBox RTxWritingPad;
        private System.Windows.Forms.RichTextBox RTPreview;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontcolourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.FontDialog FontDBx;
        private System.Windows.Forms.ColorDialog ColourDBx;
        private System.Windows.Forms.Label LblFilename;
        private System.Windows.Forms.TextBox TBxFilename;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem textAlignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textCentreToolStripMenuItem;
    }
}

