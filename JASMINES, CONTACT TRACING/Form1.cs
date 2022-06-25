namespace JASMINES__CONTACT_TRACING
{
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();
        }

        private void Subbutt_Click(object sender, EventArgs e)
        {
            var Form2 = new F2();
            Form2.Show();
            this.Hide();
        } 
          
        
    }
}