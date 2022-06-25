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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void buttLOGIN_Click(object sender, EventArgs e)
        {
            if (txtUN.Text == "AdminJL" && txtPW.Text == "0402")
            {
                new Form4().Show();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("The USER NAME or PASSWORD you entered is incorrect, try again");
                txtUN.Clear();  
                txtPW.Clear();
                txtUN.Focus();  
            }
        }

        private void lblEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
