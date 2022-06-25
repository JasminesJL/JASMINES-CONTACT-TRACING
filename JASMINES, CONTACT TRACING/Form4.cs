using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JASMINES__CONTACT_TRACING
{
    public partial class F4 : Form
    {
        public F4()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtSADFC_Click(object sender, EventArgs e)
        {
            F5 all = new F5();
            all.ShowDialog();
        }

        private void ButtFRD_Click(object sender, EventArgs e)
        {
            List<string> dates = new List<string>();
            string Date = txtDTF.Text;
            int dateResult = 0;
            var txtfiles = Directory.EnumerateFiles(@"C:\Users\John Lloyd\Documents\CT app");
            foreach (string file in txtfiles)
            {
                string contents = File.ReadAllText(file);
                if (contents.Contains(Date))
                {
                    dates.Add(contents);
                    continue;
                }

            }
            if (dateResult == 0)
            {
                MessageBox.Show("No records found");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\John Lloyd\Documents\CT app\Date" + txtDTF.Text + ".txt");
                foreach (string contents in dates)
                {
                    var lastItem = dates.LastOrDefault();
                    file.WriteLine(lastItem);
                }
                file.Close();
                MessageBox.Show("Found " + dateResult + "records on the selected date");
                MessageBox.Show("This will be save in the Contact Tracing folder");
                F6 date = new F6(); 
                date.ShowDialog();  
            }
        }
    }
}
