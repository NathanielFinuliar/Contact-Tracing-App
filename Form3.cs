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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void DisplayAllBttn_Click(object sender, EventArgs e)
        {
            Form4 alldata = new Form4();
            alldata.ShowDialog();
        }

        private void FilterDateBttn_Click(object sender, EventArgs e)
        {
            {
                List<string> dates = new List<string>();
                string Date = FlterDte.Text;
                int ResultsofDate = 0;
                var txtFiles = Directory.EnumerateFiles(@"C:\Users\nathan\contact-tracing\Mall Visit Report");
                foreach (string file in txtFiles)
                {
                    string alldata = File.ReadAllText(file);
                    if (alldata.Contains(Date))
                    {
                        dates.Add(alldata);
                        ResultsofDate++;
                        continue;
                    }
                }
                if (ResultsofDate == 0)
                {
                    MessageBox.Show("No records found on your chosen date");
                }
                else
                {
                    StreamWriter file = new StreamWriter(@"C:\Users\nathan\contact-tracing\Mall Visit Report\Date\filterdate.txt");
                    foreach (string show in dates)
                    {
                        file.WriteLine(show);
                    }
                    file.Close();
                    MessageBox.Show("We Found " + ResultsofDate + " records on your chosen date");
                    if (MessageBox.Show("Do you want to proceed of filtering?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form5 bydate = new Form5();
                        bydate.ShowDialog();
                    }
                }
            }
        }
    }
}

