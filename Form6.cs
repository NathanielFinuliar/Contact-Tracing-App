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
using System.IO;

namespace Contact_Tracing_App
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void ClckGenBttn_Click(object sender, EventArgs e)
        { 
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData infos = qr.CreateQrCode(RecrdPicRchTxtBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode gcode = new QRCode(infos);
            QrCdePcBox.Image = gcode.GetGraphic(10);
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
            StreamWriter file = new StreamWriter(@"C:\Users\nathan\contact-tracing\Mall Visit Report\QR Code Report\" + FrstNmeTxtBox.Text + LstNmeTxtBox.Text + ".txt");
            file.WriteLine("TRACE TOGETHER");
            file.WriteLine("");
            file.WriteLine("Date Check-In: " + DtePcker.Text + CommaLbl.Text);
            file.WriteLine("Time Check-In: " + TmePcker.Text + CommaLbl.Text);
            file.WriteLine("");
            file.WriteLine("First Name: " + FrstNmeTxtBox.Text + CommaLbl.Text);
            file.WriteLine("Last Name: " + LstNmeTxtBox.Text + CommaLbl.Text);
            file.WriteLine("City: " + CtyTxtBox.Text + CommaLbl.Text);
            file.WriteLine("Mobile Number: " + MobNoTxtBox.Text + CommaLbl.Text);
            file.WriteLine("");
            file.WriteLine("Are you currently experiencing any type of symptomps like sore throat/ body pains/ headache and fever?: " + YaorNaTxtBox.Text);

            file.Close();
            {
                try
                {
                    DialogResult iSubmit;
                    iSubmit = MessageBox.Show("TRACE TOGETHER, SAFER TOGETHER.", "Visitor Contact Tracing",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (iSubmit == DialogResult.OK)
                    {
                        MessageBox.Show("Thankyou for doing your part in keeping Philippines Safe!", "TRACE TOGETHER Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                FrstNmeTxtBox.Text = "";
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
                LstNmeTxtBox.Text = "";
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
                CtyTxtBox.Text = "";
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
                MobNoTxtBox.Text = "";
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
                YaorNaTxtBox.Text = "";
                YaorNaTxtBox.ForeColor = Color.Black;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Do_Checked();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                CmboBox.Items.Add(filterInfo.Name);
            CmboBox.SelectedIndex = 0;

        }

        private void StrtBttn_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[CmboBox.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            Tmer.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ScanPicBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void Tmer_Tick(object sender, EventArgs e)
        {
            if (ScanPicBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)ScanPicBox.Image);
                if (result != null)
                {
                    QrCTxtBox.Text = result.ToString();
                    Tmer.Stop(); 
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }  
        }

        private void SbmitBttn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Keep Safe Distance and Always Wear your Face Mask", "TRACE TOGETHER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Welcome to Harbor Point Mall!", "TRACE TOGETHER", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string myString = QrCTxtBox.Text;
            string[] str = myString.Split(',');
            DtePcker.Text = str[0].Substring(str[0].IndexOf(':') + 1);
            TmePcker.Text = str[1].Substring(str[1].IndexOf(':') + 1);
            FrstNmeTxtBox.Text = str[2].Substring(str[2].IndexOf(':') + 1);
            LstNmeTxtBox.Text = str[3].Substring(str[3].IndexOf(':') + 1);
            CtyTxtBox.Text = str[4].Substring(str[4].IndexOf(':') + 1);
            MobNoTxtBox.Text = str[5].Substring(str[5].IndexOf(':') + 1);
            YaorNaTxtBox.Text = str[6].Substring(str[6].IndexOf(':') + 1);
        }
    }
}
