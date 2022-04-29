using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYCLOCKV1
{
    public partial class frmAboutBox : Form
    {
        public frmAboutBox()
        {
            InitializeComponent();
        }

        private void frmAboutBox_Load(object sender, EventArgs e)
        {
            // Enables button
            BtnOK.Enabled = true;
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Closes program messagebox
            this.Close();
        }

      
    }
}
