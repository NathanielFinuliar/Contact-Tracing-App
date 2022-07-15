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
            filterAllInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo webcamcapture in filterAllInfo)
                CmboBox.Items.Add(webcamcapture.Name);

            CmboBox.SelectedIndex = 0;
            Capturedevice = new VideoCaptureDevice();
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
            file.WriteLine("last Name: " + LstNmeTxtBox);
            file.WriteLine("City: " + CtyTxtBox);
            file.WriteLine("Mobile Number: " + MobNoTxtBox);
            file.WriteLine("Are you currently experiencing any type of the  following symptoms:sore throat, body pains, headache and fever?");
            file.WriteLine(YaorNaTxtBox);
            file.Close();
        }
    }
}
