using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class ContactTracing : Form
    {
        public ContactTracing()
        {
            InitializeComponent();
        }

        private void SbmtBttn_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\nathan\contact-tracing\Contact-Tracing.txt", true);
            file.WriteLine("First Name: " + FNTxtBox.Text);
            file.WriteLine("Middle Name: " + MNTxtBox.Text);
            file.WriteLine("Last Name: " + LNTxtBox.Text);
            file.WriteLine("Suffix: " + SFTxtBox.Text);
            file.Close();
        }
        private void ContactTracing_Load(object sender, EventArgs e)
        {
            Do_Checked();
        }
        private void ChckBxLabl_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }
        private void Do_Checked()
        {
            SbmtBttn.Enabled = ChckBxLabl.Checked;
        }
    }
}
