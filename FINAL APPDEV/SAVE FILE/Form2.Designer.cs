namespace CoinTracer
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            pictureBox1 = new PictureBox();
            RegistractionLabel = new Label();
            label1 = new Label();
            NameLabel = new Label();
            label3 = new Label();
            PhoneNoLabel = new Label();
            EmailLabel = new Label();
            AddressLabel = new Label();
            BirthdayLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            YearComboBox = new ComboBox();
            MonthComboBox2 = new ComboBox();
            DayComboBox = new ComboBox();
            GenderComboBox = new ComboBox();
            GenderLabel = new Label();
            AddressTextBox4 = new TextBox();
            PhoneNoTextBox = new TextBox();
            EmailTestBox = new TextBox();
            Submitbnt = new Button();
            USERNAMEBOX = new TextBox();
            USERNAME = new Label();
            PASSWORDBOX = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(431, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // RegistractionLabel
            // 
            RegistractionLabel.AutoSize = true;
            RegistractionLabel.Font = new Font("Bell MT", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistractionLabel.ForeColor = Color.DarkCyan;
            RegistractionLabel.Location = new Point(23, 89);
            RegistractionLabel.Name = "RegistractionLabel";
            RegistractionLabel.Size = new Size(402, 52);
            RegistractionLabel.TabIndex = 1;
            RegistractionLabel.Text = "Registraction Form";
            RegistractionLabel.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 239);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = Color.DarkCyan;
            NameLabel.Location = new Point(35, 231);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(85, 33);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(35, 653);
            label3.Name = "label3";
            label3.Size = new Size(0, 33);
            label3.TabIndex = 4;
            // 
            // PhoneNoLabel
            // 
            PhoneNoLabel.AutoSize = true;
            PhoneNoLabel.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNoLabel.ForeColor = Color.DarkCyan;
            PhoneNoLabel.Location = new Point(340, 535);
            PhoneNoLabel.Name = "PhoneNoLabel";
            PhoneNoLabel.Size = new Size(141, 33);
            PhoneNoLabel.TabIndex = 5;
            PhoneNoLabel.Text = "Phone No.";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = Color.DarkCyan;
            EmailLabel.Location = new Point(35, 535);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(85, 33);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressLabel.ForeColor = Color.DarkCyan;
            AddressLabel.Location = new Point(35, 428);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(113, 33);
            AddressLabel.TabIndex = 7;
            AddressLabel.Text = "Address";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BirthdayLabel.ForeColor = Color.DarkCyan;
            BirthdayLabel.Location = new Point(35, 330);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(120, 33);
            BirthdayLabel.TabIndex = 9;
            BirthdayLabel.Text = "Birthday";
            BirthdayLabel.Click += label8_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(34, 36, 49);
            textBox1.Font = new Font("Bodoni MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(35, 267);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 47);
            textBox1.TabIndex = 10;
            textBox1.Text = "First Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(34, 36, 49);
            textBox2.Font = new Font("Bodoni MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.InactiveBorder;
            textBox2.Location = new Point(442, 267);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 47);
            textBox2.TabIndex = 11;
            textBox2.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(34, 36, 49);
            textBox3.Font = new Font("Bodoni MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.InactiveBorder;
            textBox3.Location = new Point(248, 267);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 47);
            textBox3.TabIndex = 12;
            textBox3.Text = "Middle Name";
            // 
            // YearComboBox
            // 
            YearComboBox.BackColor = Color.FromArgb(34, 36, 49);
            YearComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            YearComboBox.ForeColor = SystemColors.InactiveBorder;
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Items.AddRange(new object[] { "1900  ", "1901  ", "1902  ", "1903  ", "1904  ", "1905  ", "1906  ", "1907  ", "1908  ", "1909  ", "1910  ", "1911  ", "1912  ", "1913  ", "1914  ", "1915  ", "1916  ", "1917  ", "1918  ", "1919  ", "1920  ", "1921  ", "1922  ", "1923  ", "1924  ", "1925  ", "1926  ", "1927  ", "1928  ", "1929  ", "1930  ", "1931  ", "1932  ", "1933  ", "1934  ", "1935  ", "1936  ", "1937  ", "1938  ", "1939  ", "1940  ", "1941  ", "1942  ", "1943  ", "1944  ", "1945  ", "1946  ", "1947  ", "1948  ", "1949  ", "1950  ", "1951  ", "1952  ", "1953  ", "1954  ", "1955  ", "1956  ", "1957  ", "1958  ", "1959  ", "1960  ", "1961  ", "1962  ", "1963  ", "1964  ", "1965  ", "1966  ", "1967  ", "1968  ", "1969  ", "1970  ", "1971  ", "1972  ", "1973  ", "1974  ", "1975  ", "1976  ", "1977  ", "1978  ", "1979  ", "1980  ", "1981  ", "1982  ", "1983  ", "1984  ", "1985  ", "1986  ", "1987  ", "1988  ", "1989  ", "1990  ", "1991  ", "1992  ", "1993  ", "1994  ", "1995  ", "1996  ", "1997  ", "1998  ", "1999  ", "2000  ", "2001  ", "2002  ", "2003  ", "2004  ", "2005  ", "2006  ", "2007  ", "2008  ", "2009  ", "2010  ", "2011  ", "2012  ", "2013  ", "2014  ", "2015  ", "2016  ", "2017  ", "2018  ", "2019  ", "2020  ", "2021  ", "2022  ", "2023  ", "2024  ", "2025  " });
            YearComboBox.Location = new Point(35, 378);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(132, 36);
            YearComboBox.TabIndex = 13;
            YearComboBox.Text = "  YEAR";
            // 
            // MonthComboBox2
            // 
            MonthComboBox2.BackColor = Color.FromArgb(34, 36, 49);
            MonthComboBox2.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            MonthComboBox2.ForeColor = SystemColors.InactiveBorder;
            MonthComboBox2.FormattingEnabled = true;
            MonthComboBox2.Items.AddRange(new object[] { "January  ", "February  ", "March  ", "April  ", "May  ", "June  ", "July  ", "August  ", "September  ", "October  ", "November  ", "December  " });
            MonthComboBox2.Location = new Point(183, 378);
            MonthComboBox2.Name = "MonthComboBox2";
            MonthComboBox2.Size = new Size(158, 36);
            MonthComboBox2.TabIndex = 14;
            MonthComboBox2.Text = "MONTH";
            // 
            // DayComboBox
            // 
            DayComboBox.BackColor = Color.FromArgb(34, 36, 49);
            DayComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            DayComboBox.ForeColor = SystemColors.InactiveBorder;
            DayComboBox.FormattingEnabled = true;
            DayComboBox.Items.AddRange(new object[] { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10  ", "11  ", "12  ", "13  ", "14  ", "15  ", "16  ", "17  ", "18  ", "19  ", "20  ", "21  ", "22  ", "23  ", "24  ", "25  ", "26  ", "27  ", "28  ", "29  ", "30  ", "31  " });
            DayComboBox.Location = new Point(360, 378);
            DayComboBox.Name = "DayComboBox";
            DayComboBox.Size = new Size(104, 36);
            DayComboBox.TabIndex = 15;
            DayComboBox.Text = "DAY";
            // 
            // GenderComboBox
            // 
            GenderComboBox.BackColor = Color.FromArgb(34, 36, 49);
            GenderComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            GenderComboBox.ForeColor = SystemColors.InactiveBorder;
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Male  ", "Female  ", "Other  ", "Prefer not to say  " });
            GenderComboBox.Location = new Point(490, 378);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(177, 36);
            GenderComboBox.TabIndex = 16;
            GenderComboBox.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenderLabel.ForeColor = Color.DarkCyan;
            GenderLabel.Location = new Point(490, 330);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(105, 33);
            GenderLabel.TabIndex = 17;
            GenderLabel.Text = "Gender";
            // 
            // AddressTextBox4
            // 
            AddressTextBox4.BackColor = Color.FromArgb(34, 36, 49);
            AddressTextBox4.Font = new Font("Bodoni MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressTextBox4.ForeColor = SystemColors.InactiveBorder;
            AddressTextBox4.Location = new Point(35, 464);
            AddressTextBox4.Multiline = true;
            AddressTextBox4.Name = "AddressTextBox4";
            AddressTextBox4.Size = new Size(632, 47);
            AddressTextBox4.TabIndex = 18;
            AddressTextBox4.TextChanged += textBox4_TextChanged;
            // 
            // PhoneNoTextBox
            // 
            PhoneNoTextBox.BackColor = Color.FromArgb(34, 36, 49);
            PhoneNoTextBox.Font = new Font("Bodoni MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNoTextBox.ForeColor = SystemColors.InactiveBorder;
            PhoneNoTextBox.Location = new Point(340, 571);
            PhoneNoTextBox.Multiline = true;
            PhoneNoTextBox.Name = "PhoneNoTextBox";
            PhoneNoTextBox.Size = new Size(327, 47);
            PhoneNoTextBox.TabIndex = 19;
            // 
            // EmailTestBox
            // 
            EmailTestBox.BackColor = Color.FromArgb(34, 36, 49);
            EmailTestBox.Font = new Font("Bodoni MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailTestBox.ForeColor = SystemColors.InactiveBorder;
            EmailTestBox.Location = new Point(35, 571);
            EmailTestBox.Multiline = true;
            EmailTestBox.Name = "EmailTestBox";
            EmailTestBox.Size = new Size(270, 47);
            EmailTestBox.TabIndex = 20;
            // 
            // Submitbnt
            // 
            Submitbnt.BackgroundImageLayout = ImageLayout.Stretch;
            Submitbnt.FlatStyle = FlatStyle.Flat;
            Submitbnt.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submitbnt.ForeColor = Color.DarkCyan;
            Submitbnt.Location = new Point(35, 859);
            Submitbnt.Name = "Submitbnt";
            Submitbnt.Size = new Size(632, 56);
            Submitbnt.TabIndex = 21;
            Submitbnt.Text = "Submit";
            Submitbnt.UseVisualStyleBackColor = true;
            Submitbnt.Click += RegistrationForm_Load_1;
            // 
            // USERNAMEBOX
            // 
            USERNAMEBOX.BackColor = Color.FromArgb(34, 36, 49);
            USERNAMEBOX.Font = new Font("Bodoni MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            USERNAMEBOX.ForeColor = SystemColors.InactiveBorder;
            USERNAMEBOX.Location = new Point(35, 680);
            USERNAMEBOX.Multiline = true;
            USERNAMEBOX.Name = "USERNAMEBOX";
            USERNAMEBOX.Size = new Size(632, 47);
            USERNAMEBOX.TabIndex = 23;
            // 
            // USERNAME
            // 
            USERNAME.AutoSize = true;
            USERNAME.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            USERNAME.ForeColor = Color.DarkCyan;
            USERNAME.Location = new Point(35, 644);
            USERNAME.Name = "USERNAME";
            USERNAME.Size = new Size(174, 33);
            USERNAME.TabIndex = 22;
            USERNAME.Text = "USERNAME";
            // 
            // PASSWORDBOX
            // 
            PASSWORDBOX.BackColor = Color.FromArgb(34, 36, 49);
            PASSWORDBOX.Font = new Font("Bodoni MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PASSWORDBOX.ForeColor = SystemColors.InactiveBorder;
            PASSWORDBOX.Location = new Point(35, 782);
            PASSWORDBOX.Multiline = true;
            PASSWORDBOX.Name = "PASSWORDBOX";
            PASSWORDBOX.PasswordChar = '*';
            PASSWORDBOX.Size = new Size(632, 47);
            PASSWORDBOX.TabIndex = 25;
            PASSWORDBOX.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(35, 746);
            label4.Name = "label4";
            label4.Size = new Size(177, 33);
            label4.TabIndex = 24;
            label4.Text = "PASSWORD";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(704, 947);
            Controls.Add(PASSWORDBOX);
            Controls.Add(label4);
            Controls.Add(USERNAMEBOX);
            Controls.Add(USERNAME);
            Controls.Add(Submitbnt);
            Controls.Add(EmailTestBox);
            Controls.Add(PhoneNoTextBox);
            Controls.Add(AddressTextBox4);
            Controls.Add(GenderLabel);
            Controls.Add(GenderComboBox);
            Controls.Add(DayComboBox);
            Controls.Add(MonthComboBox2);
            Controls.Add(YearComboBox);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(BirthdayLabel);
            Controls.Add(AddressLabel);
            Controls.Add(EmailLabel);
            Controls.Add(PhoneNoLabel);
            Controls.Add(label3);
            Controls.Add(NameLabel);
            Controls.Add(label1);
            Controls.Add(RegistractionLabel);
            Controls.Add(pictureBox1);
            Name = "RegistrationForm";
            Text = "Registration Form";
            Load += RegistrationForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label RegistractionLabel;
        private Label label1;
        private Label NameLabel;
        private Label label3;
        private Label PhoneNoLabel;
        private Label EmailLabel;
        private Label AddressLabel;
        private Label BirthdayLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox YearComboBox;
        private ComboBox MonthComboBox2;
        private ComboBox DayComboBox;
        private ComboBox GenderComboBox;
        private Label GenderLabel;
        private TextBox AddressTextBox4;
        private TextBox PhoneNoTextBox;
        private TextBox EmailTestBox;
        private Button Submitbnt;
        private TextBox textBox4;
        private Label label2;
        private TextBox USERNAMEBOX;
        private Label USERNAME;
        private TextBox textBox5;
        private Label label4;
        private TextBox PASSWORDBOX;
    }
}