namespace UserManager
{
    partial class CreateUser
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
            tb_LastName = new TextBox();
            tb_Role = new TextBox();
            tb_Email = new TextBox();
            tb_Password = new TextBox();
            tb_ConfirmPassword = new TextBox();
            Title = new Label();
            FirstName = new Label();
            LastName = new Label();
            Role = new Label();
            Email = new Label();
            Password = new Label();
            ConfirmPassword = new Label();
            Submit = new Button();
            l_emptyWarning = new Label();
            l_createResponseMsg = new Label();
            tb_Login = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // tb_Title
            // 
            tb_Title.Location = new Point(363, 87);
            tb_Title.Name = "tb_Title";
            tb_Title.Size = new Size(296, 23);
            tb_Title.TabIndex = 0;
            // 
            // tb_FirstName
            // 
            tb_FirstName.Location = new Point(363, 145);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(296, 23);
            tb_FirstName.TabIndex = 2;
            // 
            // tb_LastName
            // 
            tb_LastName.Location = new Point(363, 174);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(296, 23);
            tb_LastName.TabIndex = 3;
            // 
            // tb_Role
            // 
            tb_Role.Location = new Point(363, 203);
            tb_Role.Name = "tb_Role";
            tb_Role.Size = new Size(296, 23);
            tb_Role.TabIndex = 4;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(363, 232);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(296, 23);
            tb_Email.TabIndex = 5;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(363, 261);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(296, 23);
            tb_Password.TabIndex = 6;
            // 
            // tb_ConfirmPassword
            // 
            tb_ConfirmPassword.Location = new Point(363, 290);
            tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            tb_ConfirmPassword.Size = new Size(296, 23);
            tb_ConfirmPassword.TabIndex = 7;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(328, 95);
            Title.Name = "Title";
            Title.Size = new Size(29, 15);
            Title.TabIndex = 7;
            Title.Text = "Title";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(296, 153);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(61, 15);
            FirstName.TabIndex = 8;
            FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(297, 182);
            LastName.Name = "LastName";
            LastName.Size = new Size(60, 15);
            LastName.TabIndex = 9;
            LastName.Text = "LastName";
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(327, 211);
            Role.Name = "Role";
            Role.Size = new Size(30, 15);
            Role.TabIndex = 10;
            Role.Text = "Role";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(321, 240);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 11;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(300, 269);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 12;
            Password.Text = "Password";
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.AutoSize = true;
            ConfirmPassword.Location = new Point(256, 298);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(101, 15);
            ConfirmPassword.TabIndex = 13;
            ConfirmPassword.Text = "ConfirmPassword";
            // 
            // Submit
            // 
            Submit.Location = new Point(328, 343);
            Submit.Name = "Submit";
            Submit.Size = new Size(149, 26);
            Submit.TabIndex = 8;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // l_emptyWarning
            // 
            l_emptyWarning.AutoSize = true;
            l_emptyWarning.ForeColor = Color.IndianRed;
            l_emptyWarning.Location = new Point(328, 372);
            l_emptyWarning.Name = "l_emptyWarning";
            l_emptyWarning.Size = new Size(0, 15);
            l_emptyWarning.TabIndex = 15;
            l_emptyWarning.UseMnemonic = false;
            l_emptyWarning.Visible = false;
            // 
            // l_createResponseMsg
            // 
            l_createResponseMsg.AutoSize = true;
            l_createResponseMsg.Location = new Point(365, 62);
            l_createResponseMsg.Name = "l_createResponseMsg";
            l_createResponseMsg.Size = new Size(0, 15);
            l_createResponseMsg.TabIndex = 16;
            l_createResponseMsg.Visible = false;
            // 
            // tb_Login
            // 
            tb_Login.AutoSize = true;
            tb_Login.Location = new Point(320, 124);
            tb_Login.Name = "tb_Login";
            tb_Login.Size = new Size(37, 15);
            tb_Login.TabIndex = 18;
            tb_Login.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(363, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 23);
            textBox1.TabIndex = 1;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_Login);
            Controls.Add(textBox1);
            Controls.Add(l_createResponseMsg);
            Controls.Add(l_emptyWarning);
            Controls.Add(Submit);
            Controls.Add(ConfirmPassword);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Role);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(Title);
            Controls.Add(tb_ConfirmPassword);
            Controls.Add(tb_Password);
            Controls.Add(tb_Email);
            Controls.Add(tb_Role);
            Controls.Add(tb_LastName);
            Controls.Add(tb_FirstName);
            Controls.Add(tb_Title);
            Name = "CreateUser";
            Text = "CreateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Title;
        private TextBox tb_FirstName;
        private TextBox tb_LastName;
        private TextBox tb_Role;
        private TextBox tb_Email;
        private TextBox tb_Password;
        private TextBox tb_ConfirmPassword;
        private Label Title;
        private Label FirstName;
        private Label LastName;
        private Label Role;
        private Label Email;
        private Label Password;
        private Label ConfirmPassword;
        private Button Submit;
        private Label l_emptyWarning;
        private Label l_createResponseMsg;
        private Label tb_Login;
        private TextBox textBox1;
    }
}