using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Reflection.Emit;
using System.Drawing.Text;

namespace cTamV01
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

            // Runs Main Subrootines
            SubLoadFile();
            SubUpdateDisplay();
            BtnChoiceOne.Enabled = false;
            BtnChoiceTwo.Enabled = false;
            PBxEditModeLED.Visible = false;

        }

       

        private void LBxMyMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // LBx Stuff
            // ---------

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

            if (RTxTypedAMessages.SelectionBackColor == Color.Yellow)
            {
                RTxTypedAMessages.SelectionBackColor = Color.White;
                RTxTypedAMessages.Focus();
            }

            if (LBxMyMessages.SelectedItem !=null &&
                RTxTypedAMessages.TextLength < LBxMyMessages.Text.Length ||
                RTxTypedAMessages.TextLength > LBxMyMessages.Text.Length)
            {
                EditMode = true;
                PBxEditModeLED.Visible = true;
            }
            else 
            {
                EditMode = false;
                PBxEditModeLED.Visible = false;
            }

            if (EditMode && LBxMyMessages.SelectedItem==null &&
                RTxTypedAMessages.TextLength>0)
            {
                BtnChoiceOne.Text = "Add";
                BtnChoiceTwo.Text = "Delete";
                PBxEditModeLED.Visible = false;
            }

            if (EditMode==true)
            {
                BtnChoiceOne.Text = "Edit";
                BtnChoiceTwo.Text = "Copy";
                BtnChoiceOne.Enabled = true;
                BtnChoiceTwo.Enabled = true;
                PBxEditModeLED.BackColor = Color.Green;
            }

            if (EditMode == false)
            {
                BtnChoiceOne.Text = "Copy";
                BtnChoiceTwo.Text = "Delete";
                BtnChoiceOne.Enabled = true;
                BtnChoiceTwo.Enabled = true;
                PBxEditModeLED.BackColor = Color.Green;
            }

            if (LBxMyMessages.SelectedItem == null && RTxTypedAMessages.TextLength == 0)
            {
                BtnChoiceOne.Text = "Add";
                BtnChoiceTwo.Text = "Clear";
                BtnChoiceOne.Enabled = false;
                BtnChoiceTwo.Enabled = false;
            }
            else if (LBxMyMessages.SelectedItem == null && RTxTypedAMessages.TextLength > 0)
            {
                BtnChoiceOne.Text = "Add";
                BtnChoiceTwo.Text = "Clear";
                BtnChoiceOne.Enabled = true;
                BtnChoiceTwo.Enabled = true;
            }
            else if (LBxMyMessages.SelectedItem != null && RTxTypedAMessages.TextLength == 0)
            {
                LBxMyMessages.ClearSelected();
                PBxEditModeLED.Visible = false;
                BtnChoiceOne.Text = "Add";
                BtnChoiceTwo.Text = "Clear";
                BtnChoiceOne.Enabled = true;
                BtnChoiceTwo.Enabled = true;
            }
        }

        private void BtnChoiceOne_Click(object sender, EventArgs e)
        {
            BtnOneActions();
        }

        private void BtnChoiceTwo_Click(object sender, EventArgs e)
        {
            BtnTwoActions();
        }

        private void LBxMyMessages_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void LBxMyMessages_MouseLeave(object sender, EventArgs e)
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

        private void BtnChoiceOne_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnChoiceOne_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void SubLoadFile()
        {
            // Reads Messages From Directory / File

            int Counter = 0;
            String ReadInMessages;

            if (File.Exists(SysDir + SysFilename))
            {
                StreamReader sr = new StreamReader(SysDir + SysFilename);
                while ((ReadInMessages = sr.ReadLine()) != null)
                {
                    MyMessages.Add(ReadInMessages);
                    Counter++;
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
           // RTxTypedAMessages.Clear();
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

        private void TamV1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SubSaveMessages();
        }

        private void SubCopyRoutine()
        {
            RTxTypedAMessages.SelectAll();
            RTxTypedAMessages.SelectionBackColor = Color.Yellow;
            RTxTypedAMessages.Copy();
        }

        private void SubDeleteRoutine()
        {
            MyMessages.RemoveAt(LBxMyMessages.SelectedIndex);
        }
             
        private void BtnOneActions()
        {
            if (BtnChoiceOne.Text == "Add")
            {
                SubEnterMessage();
                SubUpdateDisplay();
            }

            else if (BtnChoiceOne.Text == "Copy")
            {
                SubCopyRoutine();
            }

            else if (LBxMyMessages.SelectedItem != null  &&  EditMode)
            { 
                MyMessages.RemoveAt(LBxMyMessages.SelectedIndex);
                SubEnterMessage();
                SubUpdateDisplay();
            }
        }

        private void BtnTwoActions()
        {
            if (BtnChoiceTwo.Text=="Copy")
            {
                SubCopyRoutine();
            }
            else if (BtnChoiceTwo.Text == "Delete")
            {
                SubDeleteRoutine();
                SubUpdateDisplay();
            }
        }

        private void RTxTypedAMessages_KeyDown(object sender, KeyEventArgs e)
        {
        
            
        }

        private void RTxTypedAMessages_KeyUp(object sender, KeyEventArgs e)
        {
               
            
        }

        private void SubUpdateDisplay()
        {
            LBxMyMessages.Items.Clear();
            foreach (String ReadInMessages in MyMessages)
            {
                LBxMyMessages.Items.Add(ReadInMessages);
            }
        }
    }
 
}
