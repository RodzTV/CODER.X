namespace CoinTracer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Add any initialization logic here
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            // Navigate to the RegistrationForm
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide(); // Optionally hide the current form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Login button functionality (if implemented)
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle changes in the UserNameBOX (if implemented)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Handle changes in the PassWordbox (if implemented)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle the CoinTracerLogo click (if implemented)
        }
    }
}
