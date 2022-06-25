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
            StreamWriter doc = new StreamWriter(@"C:\Users\John Lloyd\Documents\CT app\" + txtLN.Text + ".txt", true);
            doc.WriteLine("First Name: " + txtFN.Text);
            doc.WriteLine("Middle Name: " + txtMN.Text);
            doc.WriteLine("Last Name: " + txtLN.Text);
            doc.WriteLine("Age: " + txtAGE.Text);
            doc.WriteLine("Gender: " + txtGDR.Text);
            doc.WriteLine("Address: " + txtADR.Text);
            doc.WriteLine("Birthdate: " + txtBDY.Text);
            doc.WriteLine("Cellphone Number: " + txtCN.Text);
            doc.WriteLine("Provinve: " + txtPRV.Text);
            doc.WriteLine("City: " + txtCTY.Text);
            doc.WriteLine("Barangay: " + txtBRG.Text);
            doc.WriteLine("Vaccinated: ? Yes or No " + txtVYN.Text);
            doc.WriteLine("Temperature: " + txtTMP.Text);
            doc.WriteLine("Email Adress: " + txtED.Text); 
            doc.Close();

            MessageBox.Show("Thankyou!, You are now Regitered. Stay Safe!", "Contract Tracing");
            txtFN.Text = "";
            txtMN.Text = "";
            txtLN.Text = "";
            txtAGE.Text = "";
            txtGDR.Text = "";
            txtADR.Text = "";
            txtBDY.Text = "";
            txtCN.Text = "";
            txtPRV.Text = "";
            txtCTY.Text = "";
            txtBRG.Text = "";
            txtVYN.Text = "";
            txtTMP.Text = "";
            txtED.Text = "";
            txtDT.Text = "";
        }

        private void BackButt_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit Application", MessageBoxButtons.YesNo);
            {
                Application.Exit(); 
            }
        }

        private void buttADMN_Click(object sender, EventArgs e)
        {

        }
    }
}
