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
            StreamWriter file = new StreamWriter(@"C:\Users\nathan\contact-tracing\Mall Visit Report\" + FNTxtBox.Text + LNTxtBox.Text + ".txt", true);
            file.WriteLine("Date of Visit: " + DteTmePcker.Text);
            file.WriteLine("Time of Visit: " + HrsTxtBox.Text + ColonLbl.Text + MinTxtBox.Text + AMPMTxtBox.Text);
            file.WriteLine("");
            file.WriteLine("Body Temperature: " + BodTempTxtBox.Text + DegreesCelciusLbl.Text);
            file.WriteLine("Location: " + LcnTxtbox.Text);
            String vac = "";
            if (NoVacrb.Checked == true)
            {
                vac = NoVacrb.Text;
            }
            else if (FullVacrb.Checked == true)
            {
                vac = FullVacrb.Text;
            }
            else if (Boostedrb.Checked == true)
            {
                vac = Boostedrb.Text;
            }
            file.WriteLine("Vaccination Status: " + vac);
            file.WriteLine("");
            file.WriteLine("PERSONAL INFO");
            file.WriteLine("First Name: " + FNTxtBox.Text);
            file.WriteLine("Middle Initial: " + MITxtBox.Text);
            file.WriteLine("Last Name: " + LNTxtBox.Text);
            file.WriteLine("Age: " + AgeNmericUpDwn.Text);
            string Sex = "";
            if (Malerb.Checked == true)
            {
                Sex = Malerb.Text;
            }
            else
            {
                Sex = Femalerb.Text;
            }
            file.WriteLine("Sex: " + Sex);
            file.WriteLine("");
            file.WriteLine("CURRENT ADDRESS");
            file.WriteLine("House No.: " + HNTxtBox.Text);
            file.WriteLine("Street: " + StrtTxtBox.Text);
            file.WriteLine("Barangay: " + BrgyTxtBox.Text);
            file.WriteLine("City: " + CityTxtBox.Text);
            file.WriteLine("Province: " + PrvnceTxtBox.Text);
            file.WriteLine("");
            file.WriteLine("CONTACT INFO");
            file.WriteLine("Phone Number: " + PhnNTxtBox.Text);
            file.WriteLine("Email Address: " + EMTxtBox.Text);
            file.WriteLine("");
            file.WriteLine("HEALTH RELATED QUESTION");
            file.WriteLine("Have you recently been in another public and / or crowded location?");
            file.WriteLine(YesNoMybeTxtBox.Text);
            string Symptoms = "";
            if (Yesrb.Checked == true)
            {
                Symptoms = Yesrb.Text;
            }
            else
            {
                Symptoms = Norb.Text;
            }
            file.WriteLine("Are you currently experiencing any type of the ff: symptoms: sore throat, body pains,head ache and fever?");
            file.WriteLine(Symptoms);
            file.Close();
            {
                try
                {
                    DialogResult iSubmit;
                    iSubmit = MessageBox.Show("I Understand that by clicking the submit button, I am agreeing to the Harbor Point Mall Privacy Policy.", "Visitor Contact Tracing",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (iSubmit == DialogResult.OK)
                    {
                        MessageBox.Show("Thankyou for answering", "Visitor Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DteTmePcker.Text = HrsTxtBox.Text = ColonLbl.Text = MinTxtBox.Text = AMPMTxtBox.Text =
                        BodTempTxtBox.Text = LcnTxtbox.Text = vac = FNTxtBox.Text = MITxtBox.Text = LNTxtBox.Text =
                        AgeNmericUpDwn.Text = Sex = HNTxtBox.Text = StrtTxtBox.Text = BrgyTxtBox.Text =
                        CityTxtBox.Text = PrvnceTxtBox.Text = PhnNTxtBox.Text = EMTxtBox.Text = YesNoMybeTxtBox.Text = Symptoms = "";
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
            SbmtBttn.Enabled = ChckBx.Checked;
        }

        private void AbtBttn_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Nathaniel Finuliar makes this Contact Tracing Form. This Contacting Trace is inclusively for Visitors who enter Harbor Point by Ayala Malls.",
                    "What is this Contact Tracing Form?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AdmnBttn_Click(object sender, EventArgs e)
        {
            Form2 logIn = new Form2();
            logIn.ShowDialog();  
        }

        private void HrsTxtBox_Leave(object sender, EventArgs e)
        {
            if (HrsTxtBox.Text == "") 
            {
                HrsTxtBox.Text = "10";
                HrsTxtBox.ForeColor = Color.DarkGray;
            }
        }

        private void HrsTxtBox_Enter(object sender, EventArgs e)
        {
            if (HrsTxtBox.Text == "10")
            {
                HrsTxtBox.Text = null;
                HrsTxtBox.ForeColor = Color.Black;
            }
        }

        private void MinTxtBox_Leave(object sender, EventArgs e)
        {
            if (MinTxtBox.Text == "")
            {
                MinTxtBox.Text = "00";
                MinTxtBox.ForeColor = Color.DarkGray;
            }
        }

        private void MinTxtBox_Enter(object sender, EventArgs e)
        {
            if (MinTxtBox.Text == "00")
            {
                MinTxtBox.Text = null;
                MinTxtBox.ForeColor = Color.Black;
            }
        }

        private void AMPMTxtBox_Leave(object sender, EventArgs e)
        {
            if (AMPMTxtBox.Text == "")
            {
                AMPMTxtBox.Text = "AM";
                AMPMTxtBox.ForeColor = Color.DarkGray;
            }
        }

        private void AMPMTxtBox_Enter(object sender, EventArgs e)
        {
            if (AMPMTxtBox.Text == "AM")
            {
                AMPMTxtBox.Text = null;
                AMPMTxtBox.ForeColor = Color.Black;
            }
        }
    }
}
