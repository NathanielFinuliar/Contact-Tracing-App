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
                Form admindesk = new Form3();
                this.Visible = false;
                admindesk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Harbor Point Admin Desk Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UrsnTxtBox.Text = "";
                PswrdTxtBox.Text = "";
            }
        }

        private void UrsnTxtBox_Leave(object sender, EventArgs e)
        {
            if (UrsnTxtBox.Text == "")
            {
                UrsnTxtBox.Text = "admin123";
                UrsnTxtBox.ForeColor = Color.NavajoWhite;
            }
        }

        private void UrsnTxtBox_Enter(object sender, EventArgs e)
        {
            if (UrsnTxtBox.Text == "admin123")
            {
                UrsnTxtBox.Text = null;
                UrsnTxtBox.ForeColor = Color.White;
            }
        }

        private void PswrdTxtBox_Leave(object sender, EventArgs e)
        {
            if (PswrdTxtBox.Text == "")
            {
                PswrdTxtBox.Text = "enteryourpass";
                PswrdTxtBox.ForeColor = Color.NavajoWhite;
            }
        }

        private void PswrdTxtBox_Enter(object sender, EventArgs e)
        {
            if (PswrdTxtBox.Text == "enteryourpass")
            {
                PswrdTxtBox.Text = null;
                PswrdTxtBox.ForeColor = Color.White;
            }
        }
    }
}
