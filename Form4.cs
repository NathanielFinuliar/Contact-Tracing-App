using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_App
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            var allrecords = Directory.GetFiles(@"C:\Users\nathan\contact-tracing\Mall Visit Report\");
            foreach (var file in allrecords)
            {
                string allcontent = File.ReadAllText(file);
                allrecordslbl.Text = allrecordslbl.Text + allcontent + "\n";
            }
        }
    }
}
