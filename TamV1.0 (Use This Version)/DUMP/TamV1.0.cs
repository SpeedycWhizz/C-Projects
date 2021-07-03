using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace DUMP
{
    public partial class TamV1 : Form
    {
        ArrayList MyMessages = new ArrayList();
        string SysDir = @"C:\TamV163";
        string SysFilename = @"\Messages.txt";
        bool EditMode;
        public TamV1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            SubLoadFile();
            SubUpdateDisplay();
            SubDisablesButtons();
        }
        private void SubLoadFile()
        {
            int MessageCount = 0;
            String ReadInMessages;

            if (File.Exists(SysDir + SysFilename))
            {
                StreamReader sr = new StreamReader(SysDir + SysFilename);
                while ((ReadInMessages = sr.ReadLine()) != null)
                {
                    MyMessages.Add(ReadInMessages);
                    MessageCount++;
                }
                sr.Close();

            }
            else
            {
                Directory.CreateDirectory(SysDir);
                File.Create(SysDir + SysFilename).Close();
            }

            // if no message selected, then resets button
            if (LBxMyMessages.SelectedItem == null)
            {
                // displays button text
                BtnChoiceOne.Text = "Add";
                BtnChoiceTwo.Text = "Clear";
            }

        }

        // Runs Subrootine
        private void SubEnterMessage()
        {
            // Message Entry
            MyMessages.Add(RTxTypedAMessages.Text);
            RTxTypedAMessages.Clear();
        }

        private void LBxMyMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // LBx Stuff
            // ---------

            // Error check
            if (LBxMyMessages.SelectedItem != null)
            {

                RTxTypedAMessages.Text = LBxMyMessages.SelectedItem.ToString();
                BtnChoiceOne.Text = "Copy";
                BtnChoiceTwo.Text = "Delete";
            }
            else
            {
                BtnChoiceOne.Text = "Add";
                BtnChoiceTwo.Text = "Clear";
            }
        }

        private void RTxTypedAMessages_TextChanged(object sender, EventArgs e)
        {
            // Message Entry Area
            //--------------------

            // positition text cursor at end of message
            // and allows me to edit the message

            RTxTypedAMessages.SelectionStart = RTxTypedAMessages.TextLength + 1;
            RTxTypedAMessages.Focus();

            LblCharacterCountRes.Text = RTxTypedAMessages.TextLength.ToString();

            // Highlights text
            if (RTxTypedAMessages.SelectionBackColor == Color.Yellow)
            {
                RTxTypedAMessages.SelectionBackColor = Color.White;
                RTxTypedAMessages.Focus();
            }
            // Error checks
            if (LBxMyMessages.SelectedItem != null &&
                RTxTypedAMessages.TextLength < LBxMyMessages.Text.Length ||
                RTxTypedAMessages.TextLength > LBxMyMessages.Text.Length)
            {
                // Edit check
                EditMode = true;
            }
            else
            {
                EditMode = false;
            }

            // Error check
            if (EditMode && LBxMyMessages.SelectedItem == null &&
                RTxTypedAMessages.TextLength > 0)
            {
                BtnChoiceOne.Text = "Add";
                BtnChoiceTwo.Text = "Delete";

            }

            // Edit mode enabled
            if (EditMode == true)
            {
                BtnChoiceOne.Text = "Edit";
                BtnChoiceTwo.Text = "Copy";
                SubEnabledButtons();
            }

            // Edit mode disabled
            if (EditMode == false)
            {
                BtnChoiceOne.Text = "Copy";
                BtnChoiceTwo.Text = "Delete";
                SubEnabledButtons();
            }

            // Error check
            if (LBxMyMessages.SelectedItem == null && RTxTypedAMessages.TextLength == 0)
            {
                BtnChoiceOne.Text = "Add";
                BtnChoiceTwo.Text = "Clear";
                SubDisablesButtons();
            }

            // Error check
            else if (LBxMyMessages.SelectedItem == null && RTxTypedAMessages.TextLength > 0)
            {
                BtnChoiceOne.Text = "Add";
                BtnChoiceTwo.Text = "Clear";
                SubEnabledButtons();
            }

            // Error check
            else if (LBxMyMessages.SelectedItem != null && RTxTypedAMessages.TextLength == 0)
            {
                LBxMyMessages.ClearSelected();
                BtnChoiceOne.Text = "Add";
                BtnChoiceTwo.Text = "Clear";
                SubDisablesButtons();
            }
        }

        // Runs subroutine to update display
        private void SubUpdateDisplay()
        {
            LBxMyMessages.Items.Clear();
            foreach (String ReadInMessages in MyMessages)
            {
                LBxMyMessages.Items.Add(ReadInMessages);
            }
            LblMessaageCount.Text = MyMessages.Count.ToString();
        }

        private void BtnChoiceOne_Click(object sender, EventArgs e)
        {
            // Runs subroutine
            BtnOneActions();
        }

        private void BtnChoiceTwo_Click(object sender, EventArgs e)
        {
            // Runs subroutine
            BtnTwoActions();
        }

        private void SubSaveMessages()
        {
            // Saves All Messages
            StreamWriter sw = new StreamWriter(SysDir + SysFilename);
            foreach (String SavedMessages in MyMessages)
            {
                sw.WriteLine(SavedMessages);
            }
            sw.Close();
        }

        private void SubEnabledButtons()
        {
            // Enables buttons
            BtnChoiceOne.Enabled = true;
            BtnChoiceTwo.Enabled = true;
        }

        private void SubDisablesButtons()
        {
            // Disables buttons
            BtnChoiceOne.Enabled = false;
            BtnChoiceTwo.Enabled = false;
        }

        private void SubCopyRoutine()
        {
            // Copies selected message
            RTxTypedAMessages.SelectAll();
            RTxTypedAMessages.SelectionBackColor = Color.Yellow;
            RTxTypedAMessages.Copy();
        }

        private void SubDeleteRoutine()
        {
            // Copies selected message
            MyMessages.RemoveAt(LBxMyMessages.SelectedIndex);
            RTxTypedAMessages.Clear();
        }

        private void BtnOneActions()
        {
            if (BtnChoiceOne.Text == "Add")
            {
                // Adds a new message
                SubEnterMessage();
                SubUpdateDisplay();

            }

            else if (BtnChoiceOne.Text == "Copy")
            {
                // Runs copy routine
                SubCopyRoutine();
            }

            // Error check
            else if (BtnChoiceOne.Text == "Edit" && LBxMyMessages.SelectedItem != null
                 && EditMode)
            {
                MyMessages.RemoveAt(LBxMyMessages.SelectedIndex);
                SubEnterMessage();
                SubUpdateDisplay();
            }
        }

        // Cursor change code
        private void LBxMyMessages_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void LBxMyMessages_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnChoiceOne_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnChoiceOne_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnChoiceTwo_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnChoiceTwo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SubSaveMessages();
        }

        // Button check stuff and runs subroutine
        private void BtnTwoActions()
        {
            if (BtnChoiceTwo.Text == "Copy")
            {
                SubCopyRoutine();
            }
            else if (BtnChoiceTwo.Text == "Delete")
            {
                // Runs Subroutines, all subroutines at the bottom of the application
                SubDeleteRoutine();
                SubUpdateDisplay();
            }

        }
    }

}

