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
    public partial class Filloutform : Form
    {
        public Filloutform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SubMbutt_Click(object sender, EventArgs e)
        {
            StreamWriter doc = new StreamWriter(@"C:\Users\John Lloyd\Documents\CT app", true);
            doc.WriteLine("First Name: " + FirstNbutt.Text);
            doc.WriteLine("Middle Name: " + MiddleNButt.Text);
            doc.WriteLine("Last Name: " + LastNButt.Text);
            doc.WriteLine("Age: " + AgeButt.Text);
            doc.WriteLine("Gender: " + GendrButt.Text);
            doc.WriteLine("Address: " + AdressButt.Text);
        }
    }
}
