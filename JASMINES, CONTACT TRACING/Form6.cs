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
    public partial class F6 : Form
    {
        public F6()
        {
            InitializeComponent();
            var dateFiles = Directory.GetFiles(@"C:\Users\John Lloyd\Documents\CT app\Dates");
            foreach (string file in dateFiles)
            {
                string dates = File.ReadAllText(file);
                lblFRBD.Text = lblFRBD.Text + dates +"\n";
            }
        }

        private void F6_Load(object sender, EventArgs e)
        {

        }
    }
}
