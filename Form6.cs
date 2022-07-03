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
using System.IO;


namespace Contact_Tracing_App
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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
    }
}
