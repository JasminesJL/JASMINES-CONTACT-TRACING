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
    public partial class F3 : Form
    {
        public F3()
        {
            InitializeComponent();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void ButtLOGIN_Click(object sender, EventArgs e)
        {
            if (txtUN.Text == "AdminJL" && txtPW.Text == "0402")
            {
                F4 info = new();   
                info.ShowDialog();
            }
            
            else
            {
                MessageBox.Show("The USER NAME or PASSWORD you entered is incorrect, try again");
                txtUN.Clear();  
                txtPW.Clear();
                txtUN.Focus();  
            }
        }

        private void LblEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
