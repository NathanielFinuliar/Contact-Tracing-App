using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using QRCoder;
using System.Text;
using System.IO;

namespace Contact_Tracing_App
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void ClckGenBttn_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData infos = qr.CreateQrCode(RecrdPicRchTxtBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode gcode = new QRCode(infos);
            QrCdePcBox.Image = gcode.GetGraphic(10);
        }

        FilterInfoCollection filterAllInfo;
        VideoCaptureDevice Capturedevice;

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void StrtBttn_Click(object sender, EventArgs e)
        {
            Capturedevice = new VideoCaptureDevice(filterAllInfo[CmboBox.SelectedIndex].MonikerString);
            Capturedevice.NewFrame += new NewFrameEventHandler(CaptureDevice_NewFrame);
            Capturedevice.Start();
            Tmer.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ScanPicBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Capturedevice.IsRunning)
                Capturedevice.Stop();
        }

        private void Tmer_Tick(object sender, EventArgs e)
        {
            if (ScanPicBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result outcome = barcodeReader.Decode((Bitmap)ScanPicBox.Image);
                if (outcome != null)
                {
                    QrCTxtBox.Text = outcome.ToString();
                    Tmer.Stop();
                    StreamWriter report = new StreamWriter(@"C:\Users\nathan\contact-tracing\Mall Visit Report\QR Code" + "  Contact Tracing" + ".txt");
                    report.WriteLine(outcome.ToString());
                    report.Close();
                }
            }
        }
        private void OpFlbttn_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    RecrdPicRchTxtBox.Text = filetext;
                }
            }
        }

        private void SbtBttn_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\nathan\contact-tracing\Mall Visit Report\QR Code Report\" + FrstNmeTxtBox.Text + LstNmeTxtBox.Text + ".txt", true);
            file.WriteLine("TRACE TOGETHER");
            file.WriteLine("");
            file.WriteLine("First Name: " + FrstNmeTxtBox.Text);
            file.WriteLine("last Name: " + LstNmeTxtBox.Text);
            file.WriteLine("City: " + CtyTxtBox.Text);
            file.WriteLine("Mobile Number: " + MobNoTxtBox.Text);
            file.WriteLine("Are you currently experiencing any type of the  following symptoms:sore throat, body pains, headache and fever?");
            file.WriteLine(YaorNaTxtBox.Text);
            file.Close();
            {
                try
                {
                    DialogResult iSubmit;
                    iSubmit = MessageBox.Show("TRACE TOGETHER, SAFER TOGETHER.", "Visitor Contact Tracing",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (iSubmit == DialogResult.OK)
                    {
                        MessageBox.Show("Thankyou for doing your part in keeping Philippines Safe", "TRACE TOGETHER Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrstNmeTxtBox.Text = LstNmeTxtBox.Text = CtyTxtBox.Text = MobNoTxtBox.Text = YaorNaTxtBox.Text = "";
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void TraceTogether_Load(object sender, EventArgs e)
        {
            Do_Checked();
        }
        private void ChckBox_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }
        private void Do_Checked()
        {
            SbtBttn.Enabled = ChckBox.Checked;
        }

        private void FrstNmeTxtBox_Leave(object sender, EventArgs e)
        {
            if (FrstNmeTxtBox.Text == "")
            {
                FrstNmeTxtBox.Text = "First Name";
                FrstNmeTxtBox.ForeColor = Color.DarkGray;
            }
        }

        private void FrstNmeTxtBox_Enter(object sender, EventArgs e)
        {
            if (FrstNmeTxtBox.Text == "First Name")
            {
                FrstNmeTxtBox.Text = null;
                FrstNmeTxtBox.ForeColor = Color.Black;
            }
        }

        private void LstNmeTxtBox_Leave(object sender, EventArgs e)
        {
            if (LstNmeTxtBox.Text == "")
            {
                LstNmeTxtBox.Text = "Last Name";
                LstNmeTxtBox.ForeColor = Color.DarkGray;
            }
        }

        private void LstNmeTxtBox_Enter(object sender, EventArgs e)
        {
            if (LstNmeTxtBox.Text == "Last Name")
            {
                LstNmeTxtBox.Text = null;
                LstNmeTxtBox.ForeColor = Color.Black;
            }
        }

        private void CtyTxtBox_Leave(object sender, EventArgs e)
        {
            if (CtyTxtBox.Text == "")
            {
                CtyTxtBox.Text = "City";
                CtyTxtBox.ForeColor = Color.DarkGray;
            }
        }

        private void CtyTxtBox_Enter(object sender, EventArgs e)
        {
            if (CtyTxtBox.Text == "City")
            {
                CtyTxtBox.Text = null;
                CtyTxtBox.ForeColor = Color.Black;
            }
        }

        private void MobNoTxtBox_Leave(object sender, EventArgs e)
        {
            if (MobNoTxtBox.Text == "")
            {
                MobNoTxtBox.Text = "Mobile Number";
                MobNoTxtBox.ForeColor = Color.DarkGray;
            }
        }

        private void MobNoTxtBox_Enter(object sender, EventArgs e)
        {
            if (MobNoTxtBox.Text == "Mobile Number")
            {
                MobNoTxtBox.Text = null;
                MobNoTxtBox.ForeColor = Color.Black;
            }
        }

        private void YaorNaTxtBox_Leave(object sender, EventArgs e)
        {
            if (YaorNaTxtBox.Text == "")
            {
                YaorNaTxtBox.Text = "Yes or No";
                YaorNaTxtBox.ForeColor = Color.DarkGray;
            }
        }

        private void YaorNaTxtBox_Enter(object sender, EventArgs e)
        {
            if (YaorNaTxtBox.Text == "Yes or No")
            {
                YaorNaTxtBox.Text = null;
                YaorNaTxtBox.ForeColor = Color.Black;
            }
        }
    }
}
