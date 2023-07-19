namespace UserManager
{
    partial class Login
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
            l_WelcomeTitle = new Label();
            l_Login = new Label();
            l_Password = new Label();
            b_SubmitLogin = new Button();
            tb_Login = new TextBox();
            tb_Password = new TextBox();
            SuspendLayout();
            // 
            // l_WelcomeTitle
            // 
            l_WelcomeTitle.AutoSize = true;
            l_WelcomeTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            l_WelcomeTitle.Location = new Point(173, 18);
            l_WelcomeTitle.Name = "l_WelcomeTitle";
            l_WelcomeTitle.Size = new Size(153, 45);
            l_WelcomeTitle.TabIndex = 0;
            l_WelcomeTitle.Text = "Welcome";
            // 
            // l_Login
            // 
            l_Login.AutoSize = true;
            l_Login.Location = new Point(29, 219);
            l_Login.Name = "l_Login";
            l_Login.Size = new Size(37, 15);
            l_Login.TabIndex = 1;
            l_Login.Text = "Login";
            // 
            // l_Password
            // 
            l_Password.AutoSize = true;
            l_Password.Location = new Point(9, 248);
            l_Password.Name = "l_Password";
            l_Password.Size = new Size(57, 15);
            l_Password.TabIndex = 2;
            l_Password.Text = "Password";
            // 
            // b_SubmitLogin
            // 
            b_SubmitLogin.Location = new Point(251, 269);
            b_SubmitLogin.Name = "b_SubmitLogin";
            b_SubmitLogin.Size = new Size(75, 23);
            b_SubmitLogin.TabIndex = 3;
            b_SubmitLogin.Text = "Ok";
            b_SubmitLogin.UseVisualStyleBackColor = true;
            b_SubmitLogin.Click += b_SubmitLogin_Click;
            // 
            // tb_Login
            // 
            tb_Login.Location = new Point(72, 211);
            tb_Login.Name = "tb_Login";
            tb_Login.Size = new Size(254, 23);
            tb_Login.TabIndex = 4;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(72, 240);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(254, 23);
            tb_Password.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_Password);
            Controls.Add(tb_Login);
            Controls.Add(b_SubmitLogin);
            Controls.Add(l_Password);
            Controls.Add(l_Login);
            Controls.Add(l_WelcomeTitle);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_WelcomeTitle;
        private Label l_Login;
        private Label l_Password;
        private Button b_SubmitLogin;
        private TextBox tb_Login;
        private TextBox tb_Password;
    }
}