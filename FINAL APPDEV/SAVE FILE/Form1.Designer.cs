namespace CoinTracer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            UserNameBOX = new TextBox();
            PassWordbox = new TextBox();
            CoinTracerLogo = new PictureBox();
            USERNAMELOGO = new PictureBox();
            PASSWORDLOGO = new PictureBox();
            LoginBNT = new Button();
            RegisterBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)CoinTracerLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)USERNAMELOGO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PASSWORDLOGO).BeginInit();
            SuspendLayout();
            // 
            // UserNameBOX
            // 
            UserNameBOX.BackColor = Color.FromArgb(34, 36, 49);
            UserNameBOX.ForeColor = SystemColors.InactiveBorder;
            UserNameBOX.Location = new Point(139, 286);
            UserNameBOX.Multiline = true;
            UserNameBOX.Name = "UserNameBOX";
            UserNameBOX.Size = new Size(302, 44);
            UserNameBOX.TabIndex = 0;
            UserNameBOX.Text = "USERNAME";
            UserNameBOX.TextChanged += textBox1_TextChanged;
            // 
            // PassWordbox
            // 
            PassWordbox.BackColor = Color.FromArgb(34, 36, 49);
            PassWordbox.ForeColor = SystemColors.InactiveBorder;
            PassWordbox.Location = new Point(139, 370);
            PassWordbox.Multiline = true;
            PassWordbox.Name = "PassWordbox";
            PassWordbox.PasswordChar = '*';
            PassWordbox.Size = new Size(302, 44);
            PassWordbox.TabIndex = 1;
            PassWordbox.Text = "Password";
            PassWordbox.TextChanged += textBox2_TextChanged;
            // 
            // CoinTracerLogo
            // 
            CoinTracerLogo.Image = (Image)resources.GetObject("CoinTracerLogo.Image");
            CoinTracerLogo.Location = new Point(139, 27);
            CoinTracerLogo.Name = "CoinTracerLogo";
            CoinTracerLogo.Size = new Size(302, 197);
            CoinTracerLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            CoinTracerLogo.TabIndex = 2;
            CoinTracerLogo.TabStop = false;
            CoinTracerLogo.Click += pictureBox1_Click;
            // 
            // USERNAMELOGO
            // 
            USERNAMELOGO.Image = (Image)resources.GetObject("USERNAMELOGO.Image");
            USERNAMELOGO.Location = new Point(93, 286);
            USERNAMELOGO.Name = "USERNAMELOGO";
            USERNAMELOGO.Size = new Size(40, 44);
            USERNAMELOGO.SizeMode = PictureBoxSizeMode.StretchImage;
            USERNAMELOGO.TabIndex = 3;
            USERNAMELOGO.TabStop = false;
            // 
            // PASSWORDLOGO
            // 
            PASSWORDLOGO.Image = (Image)resources.GetObject("PASSWORDLOGO.Image");
            PASSWORDLOGO.Location = new Point(93, 370);
            PASSWORDLOGO.Name = "PASSWORDLOGO";
            PASSWORDLOGO.Size = new Size(40, 44);
            PASSWORDLOGO.SizeMode = PictureBoxSizeMode.StretchImage;
            PASSWORDLOGO.TabIndex = 4;
            PASSWORDLOGO.TabStop = false;
            // 
            // LoginBNT
            // 
            LoginBNT.FlatStyle = FlatStyle.Flat;
            LoginBNT.ForeColor = Color.LightBlue;
            LoginBNT.Location = new Point(139, 456);
            LoginBNT.Name = "LoginBNT";
            LoginBNT.Size = new Size(302, 45);
            LoginBNT.TabIndex = 5;
            LoginBNT.Text = "LOGIN";
            LoginBNT.UseVisualStyleBackColor = true;
            LoginBNT.Click += button1_Click;
            // 
            // RegisterBTN
            // 
            RegisterBTN.FlatStyle = FlatStyle.Flat;
            RegisterBTN.ForeColor = SystemColors.GradientActiveCaption;
            RegisterBTN.Location = new Point(139, 530);
            RegisterBTN.Name = "RegisterBTN";
            RegisterBTN.Size = new Size(302, 52);
            RegisterBTN.TabIndex = 6;
            RegisterBTN.Text = "Register";
            RegisterBTN.UseVisualStyleBackColor = true;
            RegisterBTN.Click += RegisterBTN_Click;
            // 
            // USERLOGIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(548, 704);
            Controls.Add(RegisterBTN);
            Controls.Add(LoginBNT);
            Controls.Add(PASSWORDLOGO);
            Controls.Add(USERNAMELOGO);
            Controls.Add(CoinTracerLogo);
            Controls.Add(PassWordbox);
            Controls.Add(UserNameBOX);
            Name = "USERLOGIN";
            Text = "USER LOGIN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CoinTracerLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)USERNAMELOGO).EndInit();
            ((System.ComponentModel.ISupportInitialize)PASSWORDLOGO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameBOX;
        private TextBox PassWordbox;
        private PictureBox CoinTracerLogo;
        private PictureBox USERNAMELOGO;
        private PictureBox PASSWORDLOGO;
        private Button LoginBNT;
        private Button RegisterBTN;
    }
}
