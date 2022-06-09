namespace JASMINES__CONTACT_TRACING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Subbutt_Click(object sender, EventArgs e)
        {
            var Form2 = new Filloutform();
            Form2.Show();
            this.Hide();
        } 
          
        
    }
}