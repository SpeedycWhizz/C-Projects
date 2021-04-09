using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using TEST.Properties;

namespace TEST
{
    public partial class MyNotepadV2 : Form
    {
        string SysDir = @"C:\Notepad\";
        ArrayList filescan = new ArrayList();

        public MyNotepadV2()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LblFilename.Visible = false;
            TBxFilename.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button2.ForeColor = Color.White;
          // Checks For Directory
            if (Directory.Exists(SysDir))
            {
                SubCheckForFiles();
                SubLoadFontAndColourSettings();
                this.Show();
                RTxWritingPad.Focus();
            }
            else
            {
                // Creates A Directory
                Directory.CreateDirectory(SysDir);
                this.Show();
                RTxWritingPad.Focus();
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clears WrittingPad
            RTxWritingPad.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays Button Name
            LblFilename.Visible = false;
            TBxFilename.Visible = false;
            BtnOption.Text = "Open";

        }

        private void sAveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays Button Name
            LblFilename.Visible = true;
            TBxFilename.Visible = true;
            BtnOption.Text = "Save";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete File RToutine
            BtnOption.Text = "Delete";
            SubCheckSelectedFile();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Copy Selected Text
            RTxWritingPad.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Cut Selected Text
            RTxWritingPad.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pastes Selected Text
            RTxWritingPad.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Highlights Selected
            RTxWritingPad.SelectAll();
        }


        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Context Copy Selected Text
            RTxWritingPad.Copy();
        }

        private void cuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Context Cut Selected Text
            RTxWritingPad.Cut();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            // Context Paste Text
            RTxWritingPad.Paste();
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Context Highlight All Text
            RTxWritingPad.SelectAll();
        }

        private void textLeftToolStripMenuItem_Click(object sender, EventArgs e)

        {
        // Text Alignment Left 
        RTxWritingPad.SelectionAlignment = HorizontalAlignment.Left;
        
        }

        private void textRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Text Alignment Right
            RTxWritingPad.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void textCentreToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // Text Alignment Centre 
            RTxWritingPad.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closes Application
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Font Size
            DialogResult fontcheck = FontDBx.ShowDialog();
            if (fontcheck == DialogResult.OK)
            {
                RTxWritingPad.SelectionFont = FontDBx.Font;
                button2.Text = FontDBx.Font.Size.ToString();
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Font Colour
            DialogResult colourcheck = ColourDBx.ShowDialog();
            if (colourcheck == DialogResult.OK)
            {
                RTxWritingPad.SelectionColor = ColourDBx.Color;
                button1.ForeColor = ColourDBx.Color;
            }
        }

        private void LBxListMyFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBxListMyFiles.SelectedItems.Count>0)
            {
                // Enables Button
                BtnOption.Enabled = true;
                SubCheckSelectedFile();
            }
            else
            {
                // Disables Button
                BtnOption.Enabled = false;
            }
            
        }

        private void BtnOption_Click(object sender, EventArgs e)
        {
            // Selectes Button Options
            if (BtnOption.Text== "Open")
            {
                // Open File Routine
                DirectoryInfo dinfo = new DirectoryInfo(SysDir);
                String FileFound = dinfo + LBxListMyFiles.SelectedItem.ToString();
                RTxWritingPad.LoadFile(FileFound, RichTextBoxStreamType.RichText);
                RTPreview.Clear();

            }
            else if (BtnOption.Text == "Save")
            {

                // Save File Routine
                DirectoryInfo dinfo = new DirectoryInfo(SysDir);
                String FileFound = dinfo + TBxFilename.Text + ".rtf";
                filescan.Add(Path.GetFileName(FileFound));
                RTxWritingPad.SaveFile(FileFound, RichTextBoxStreamType.RichText);
                SubUpdateDisplay();

            }
            else if (BtnOption.Text =="Delete")
            {
                // Delete File Routine
                DirectoryInfo dinfo = new DirectoryInfo(SysDir);
                String FileFound = dinfo + LBxListMyFiles.SelectedItem.ToString();
                filescan.RemoveAt(LBxListMyFiles.SelectedIndex);
                File.Delete(FileFound);
                RTPreview.Clear();
                SubUpdateDisplay();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Saves Applications / User Settings
            SubSaveAllSettings();
        }

        private void SubCheckForFiles()
        { 
            // Check For Files
            DirectoryInfo dinfo = new DirectoryInfo(SysDir);
            FileInfo[] FilesFound = dinfo.GetFiles("*.rtf");
            foreach (FileInfo fi in FilesFound)
            {
                filescan.Add(Path.GetFileName(fi.Name));
                SubUpdateDisplay();
            }
        }

        private void SubCheckSelectedFile()
        {
            // Loads Selected File
            DirectoryInfo dinfo = new DirectoryInfo(SysDir);
            String FileFound = dinfo + LBxListMyFiles.SelectedItem.ToString();
            RTPreview.LoadFile(FileFound, RichTextBoxStreamType.RichText);
        }

        private void SubUpdateDisplay()
        {
            // Displays Files
            LBxListMyFiles.Items.Clear();
            foreach (string filescanfound in filescan)
            {
                LBxListMyFiles.Items.Add(filescanfound);
            }
        }

        private void SubLoadFontAndColourSettings()
        {
            // Loads Applications / User Settings
            FontDBx.Font = Settings.Default.FontSize;
            ColourDBx.Color = Settings.Default.FontColour;
            RTxWritingPad.Font = FontDBx.Font;
            RTxWritingPad.ForeColor = ColourDBx.Color;
            button1.ForeColor = Settings.Default.TextColour;
            button2.Text = FontDBx.Font.Size.ToString();       
        }

        private void SubSaveAllSettings()
        {
            // Saves Settings
            Settings.Default.FontSize = FontDBx.Font;
            Settings.Default.FontColour = ColourDBx.Color;
            Settings.Default.TextColour = ColourDBx.Color;
            Settings.Default.FontSizeSelected = FontDBx.Font;
            Settings.Default.Save();
        }

      
    }     
    
}
