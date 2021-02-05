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

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        String SysDir = @"c:\Notepad\";
        string MBT = "System Infomation";

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Displays system message
            if (Directory.Exists(SysDir))
            {
                this.Show();
                MessageBox.Show("Directory Exists", MBT);
            }
            else 
            {
                // Creates directory
                this.Show();
                Directory.CreateDirectory(SysDir);
                MessageBox.Show("Directory Created",MBT);
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clears all text
            RTBWroteNote.Clear();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             // Cuts selected text
            RTBWroteNote.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Copies selected text
            RTBWroteNote.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Paste text
            RTBWroteNote.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  selectAll text
            RTBWroteNote.SelectAll();
        }

        
        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Context menu option
            RTBWroteNote.Copy();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Context menu option
            RTBWroteNote.Cut();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Context menu option
            RTBWroteNote.Paste();
        }


        private void selectALLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Context menu option
            RTBWroteNote.SelectAll();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Context menu Bold
            RTBWroteNote.Font = new Font(RTBWroteNote.Font, FontStyle.Bold);
        }

        private void itallicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Context menu Italic
            RTBWroteNote.Font = new Font(RTBWroteNote.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Context menu Underline
            RTBWroteNote.Font = new Font(RTBWroteNote.Font, FontStyle.Underline);
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Context menu Regular
            RTBWroteNote.Font = new Font(RTBWroteNote.Font, FontStyle.Regular);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            // Sets FileDialog 
            openFileDialog1.InitialDirectory = @"c:\Notepad\";
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "rtf files (*.rtf)|*.rtf";
            openFileDialog1.ShowDialog();
            RTBWroteNote.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);       

            if (RTBWroteNote.TextLength>0)
            {
                MessageBox.Show("Note Opened Successfully ");
            }
            else if (RTBWroteNote.TextLength==0)
            {
             
                MessageBox.Show("No Note Written");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sets FileDialog 
            saveFileDialog1.InitialDirectory = @"c:\Notepad\";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.Filter = "rtf files (*.rtf)|*.rtf";
            saveFileDialog1.ShowDialog();
            RTBWroteNote.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closes App
            Application.Exit();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Colour Selection
            colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                
                RTBWroteNote.SelectionColor=colorDialog1.Color;
                              
            }

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Font Dialog
          
            FontDialog fontDialog1 = new FontDialog();
            
            if (fontDialog1.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(RTBWroteNote.Text))
            {
               
                RTBWroteNote.SelectionFont=fontDialog1.Font;
                        
            }
        }

        private void codedByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SpeedyOnAGoSlow (c) 2021 - 2022 ","Coded By");
        }
    }  
  
}
