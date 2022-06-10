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
            file.WriteLine("Date of Visit: " + MMTxtBox.Text + DDTxtBox.Text + YYTxtBox.Text);
            file.WriteLine("Time of Visit: " + ToVTxtBox.Text);
            file.WriteLine("Body Temperature: " + BodTempTxtBox.Text);
            file.WriteLine("Age: " + AgeTxtBox.Text);
            file.WriteLine("Gender: " + GndrTxtBox.Text);
            file.WriteLine("Mobile Number: " + MblNTxtBox.Text);
            file.WriteLine("Email Address: " + EMTxtBox.Text);
            file.WriteLine("House No.: " + HNTxtBox.Text);
            file.WriteLine("Street: " + StrtTxtBox.Text);
            file.WriteLine("Barangay: " + BrgyTxtBox.Text);
            file.WriteLine("City: " + CityTxtBox.Text);
            file.WriteLine("Province: " + PrvnceTxtBox.Text);
            file.WriteLine("Seating/TableNo./Location " + LtnTxtBox.Text);
            file.Close();
            {
                try
                {
                    DialogResult iSubmit;
                    iSubmit = MessageBox.Show("Confirm if you want to Submit", "Visitor Contact Tracing",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (iSubmit == DialogResult.OK)
                    {
                        MessageBox.Show("Thankyou for answering", "Visitor Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FNTxtBox.Text = MNTxtBox.Text = LNTxtBox.Text = SFTxtBox.Text = MMTxtBox.Text = DDTxtBox.Text = YYTxtBox.Text =
                        ToVTxtBox.Text = BodTempTxtBox.Text = AgeTxtBox.Text = GndrTxtBox.Text = MblNTxtBox.Text = EMTxtBox.Text =
                        HNTxtBox.Text = StrtTxtBox.Text = BrgyTxtBox.Text = CityTxtBox.Text = PrvnceTxtBox.Text = LtnTxtBox.Text = "";
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
