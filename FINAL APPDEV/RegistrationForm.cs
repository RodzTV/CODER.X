namespace CoinTracer
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Optional: Add initialization logic here
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            // Navigate back to the login form
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close(); // Close the current form
        }
    }
}
