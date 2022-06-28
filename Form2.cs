using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void LgnBttn_Click(object sender, EventArgs e)
        {
            if (UrsnTxtBox.Text == "Nathaniel Finuliar" && PswrdTxtBox.Text == "HPAdmin01")
            {
                UrsnTxtBox.Text = "";
                PswrdTxtBox.Text = "";
                Form records = new Form3();
                this.Visible = false;
                records.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Harbor Point Admin Desk Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UrsnTxtBox.Text = "";
                PswrdTxtBox.Text = "";
            }
        }
    }
}
