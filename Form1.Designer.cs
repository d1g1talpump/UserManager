namespace UserManager
{
    partial class Form1
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
            tb_Title = new TextBox();
            tb_FirstName = new TextBox();
            tb_ = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            Title = new Label();
            FirstName = new Label();
            LastName = new Label();
            Role = new Label();
            Email = new Label();
            Password = new Label();
            ConfirmPassword = new Label();
            Submit = new Button();
            SuspendLayout();
            // 
            // tb_Title
            // 
            tb_Title.Location = new Point(363, 82);
            tb_Title.Name = "tb_Title";
            tb_Title.Size = new Size(296, 23);
            tb_Title.TabIndex = 0;
            // 
            // tb_FirstName
            // 
            tb_FirstName.Location = new Point(363, 111);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(296, 23);
            tb_FirstName.TabIndex = 1;
            // 
            // tb_
            // 
            tb_.Location = new Point(363, 140);
            tb_.Name = "tb_";
            tb_.Size = new Size(296, 23);
            tb_.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(363, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(296, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(363, 198);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(296, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(363, 227);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(296, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(363, 256);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(296, 23);
            textBox7.TabIndex = 6;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(328, 90);
            Title.Name = "Title";
            Title.Size = new Size(29, 15);
            Title.TabIndex = 7;
            Title.Text = "Title";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(296, 119);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(61, 15);
            FirstName.TabIndex = 8;
            FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(297, 148);
            LastName.Name = "LastName";
            LastName.Size = new Size(60, 15);
            LastName.TabIndex = 9;
            LastName.Text = "LastName";
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(327, 177);
            Role.Name = "Role";
            Role.Size = new Size(30, 15);
            Role.TabIndex = 10;
            Role.Text = "Role";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(321, 206);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 11;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(300, 235);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 12;
            Password.Text = "Password";
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.AutoSize = true;
            ConfirmPassword.Location = new Point(256, 264);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(101, 15);
            ConfirmPassword.TabIndex = 13;
            ConfirmPassword.Text = "ConfirmPassword";
            // 
            // Submit
            // 
            Submit.Location = new Point(328, 309);
            Submit.Name = "Submit";
            Submit.Size = new Size(149, 26);
            Submit.TabIndex = 14;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Submit);
            Controls.Add(ConfirmPassword);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Role);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(Title);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(tb_);
            Controls.Add(tb_FirstName);
            Controls.Add(tb_Title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Title;
        private TextBox tb_FirstName;
        private TextBox tb_;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label Title;
        private Label FirstName;
        private Label LastName;
        private Label Role;
        private Label Email;
        private Label Password;
        private Label ConfirmPassword;
        private Button Submit;
    }
}