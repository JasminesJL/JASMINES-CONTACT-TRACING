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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtSADFC_Click(object sender, EventArgs e)
        {
            Form5 all = new Form5();    
            all.ShowDialog();   
        }

        private void ButtFRD_Click(object sender, EventArgs e)
        {

        }
    }
}
