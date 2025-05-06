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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle changes in the UserNameBOX  
            if (UserNameBOX.Text == "USERNAME")
            {
                UserNameBOX.ForeColor = SystemColors.InactiveBorder;
            }
            else
            {
                UserNameBOX.ForeColor = Color.White;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Handle changes in the PassWordbox  
            if (PassWordbox.Text == "Password")
            {
                PassWordbox.ForeColor = SystemColors.InactiveBorder;
            }
            else
            {
                PassWordbox.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Handle the Login button click  
            string username = UserNameBOX.Text;
            string password = PassWordbox.Text;

            if (username == "USERNAME" || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a valid username.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password == "Password" || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a valid password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simulate login logic (replace with actual authentication logic)  
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle the CoinTracerLogo click (optional)  
            MessageBox.Show("Welcome to CoinTracer!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            // Navigate to the RegistrationForm  
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide(); // Optionally hide the current form  
        }
    }
}