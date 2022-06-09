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
            StreamWriter doc = new StreamWriter(@"C:\Users\John Lloyd\Documents\CT app\Record.txt", true);
            doc.WriteLine("First Name: " + FirstNbutt.Text);
            doc.WriteLine("Middle Name: " + MiddleNButt.Text);
            doc.WriteLine("Last Name: " + LastNButt.Text);
            doc.WriteLine("Age: " + AgeButt.Text);
            doc.WriteLine("Gender: " + GendrButt.Text);
            doc.WriteLine("Address: " + AdressButt.Text);
            doc.WriteLine("Birthdate: " + BirthDButt.Text);
            doc.WriteLine("Cellphone Number: " + CellPButt.Text);
            doc.WriteLine("Provinve: " + ProvButt.Text);
            doc.WriteLine("City: " + CityButt.Text);
            doc.WriteLine("Barangay: " + BrgyButt.Text);
            doc.WriteLine("Vaccinated: ? Yes or No " + VaccYORButt.Text);
            doc.WriteLine("Temperature: " + TempButt.Text);
            doc.WriteLine("Email Adress: " + EmailAButt.Text);
            doc.Close();

            MessageBox.Show("Thankyou!, You are now Regitered. Stay Safe!", "Contract Tracing");
            FirstNbutt.Text = "";
            MiddleNButt.Text = "";
            LastNButt.Text = "";
            AgeButt.Text = "";
            GendrButt.Text = "";
            AdressButt.Text = "";
            BirthDButt.Text = "";
            CellPButt.Text = "";
            ProvButt.Text = "";
            CityButt.Text = "";
            BrgyButt.Text = "";
            VaccYORButt.Text = "";
            TempButt.Text = "";
            EmailAButt.Text = "";
        }

        private void BackButt_Click(object sender, EventArgs e)
        {
           
        }
    }
}
