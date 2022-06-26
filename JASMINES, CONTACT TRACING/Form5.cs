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
    public partial class F5 : Form
    {
        public F5()
        {
            InitializeComponent();
            var txtfiles = Directory.GetFiles(@"C:\Users\John Lloyd\Documents\CT app\All info");
            foreach (string file in txtfiles)
            {
                string contents = File.ReadAllText(file);
                LblSA.Text += contents + "\n";     
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
