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

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            // Handle registration logic
            string username = UserNameBOX.Text;
            string password = PassWordbox.Text;
            string confirmPassword = ConfirmPassWordbox.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simulate registration logic (replace with actual database or API logic)
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate back to the login form
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close(); // Close the current form
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (ShowPasswordCheckBox.Checked)
            {
                PassWordbox.PasswordChar = '\0'; // Show password
                ConfirmPassWordbox.PasswordChar = '\0'; // Show confirm password
            }
            else
            {
                PassWordbox.PasswordChar = '*'; // Hide password
                ConfirmPassWordbox.PasswordChar = '*'; // Hide confirm password
            }
        }

        private void InitializeComponent()
        {
            this.UserNameBOX = new TextBox();
            this.PassWordbox = new TextBox();
            this.ConfirmPassWordbox = new TextBox();
            this.RegisterBTN = new Button();
            this.BackBTN = new Button();
            this.ShowPasswordCheckBox = new CheckBox();
            this.SuspendLayout();
            // 
            // UserNameBOX
            // 
            this.UserNameBOX.Location = new Point(100, 50);
            this.UserNameBOX.Name = "UserNameBOX";
            this.UserNameBOX.Size = new Size(250, 31);
            this.UserNameBOX.TabIndex = 0;
            this.UserNameBOX.PlaceholderText = "Enter Username";
            // 
            // PassWordbox
            // 
            this.PassWordbox.Location = new Point(100, 100);
            this.PassWordbox.Name = "PassWordbox";
            this.PassWordbox.Size = new Size(250, 31);
            this.PassWordbox.TabIndex = 1;
            this.PassWordbox.PlaceholderText = "Enter Password";
            this.PassWordbox.PasswordChar = '*';
            // 
            // ConfirmPassWordbox
            // 
            this.ConfirmPassWordbox.Location = new Point(100, 150);
            this.ConfirmPassWordbox.Name = "ConfirmPassWordbox";
            this.ConfirmPassWordbox.Size = new Size(250, 31);
            this.ConfirmPassWordbox.TabIndex = 2;
            this.ConfirmPassWordbox.PlaceholderText = "Confirm Password";
            this.ConfirmPassWordbox.PasswordChar = '*';
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Location = new Point(100, 250);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new Size(250, 40);
            this.RegisterBTN.TabIndex = 3;
            this.RegisterBTN.Text = "Register";
            this.RegisterBTN.UseVisualStyleBackColor = true;
            this.RegisterBTN.Click += new EventHandler(this.RegisterBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.Location = new Point(10, 10);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new Size(75, 30);
            this.BackBTN.TabIndex = 4;
            this.BackBTN.Text = "Back";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new EventHandler(this.BackBTN_Click);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.Location = new Point(100, 200);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new Size(250, 30);
            this.ShowPasswordCheckBox.TabIndex = 5;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(450, 350);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.ConfirmPassWordbox);
            this.Controls.Add(this.PassWordbox);
            this.Controls.Add(this.UserNameBOX);
            this.Name = "RegistrationForm";
            this.Text = "User Registration";
            this.Load += new EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox UserNameBOX;
        private TextBox PassWordbox;
        private TextBox ConfirmPassWordbox;
        private Button RegisterBTN;
        private Button BackBTN;
        private CheckBox ShowPasswordCheckBox;
    }
}
