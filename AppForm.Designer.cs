namespace college_lms_winforms_client
{
    partial class AppForm
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
            LoginBox = new TextBox();
            PasswordBox = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            LogInButton = new Button();
            checkPass = new CheckBox();
            SuspendLayout();
            // 
            // LoginBox
            // 
            LoginBox.Location = new Point(124, 104);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(100, 23);
            LoginBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(124, 148);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(100, 23);
            PasswordBox.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(124, 86);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(40, 15);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(124, 130);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(47, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "пароль";
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(136, 177);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(75, 23);
            LogInButton.TabIndex = 4;
            LogInButton.Text = "войти";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // checkPass
            // 
            checkPass.AutoSize = true;
            checkPass.Checked = true;
            checkPass.CheckState = CheckState.Checked;
            checkPass.Location = new Point(230, 152);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(15, 14);
            checkPass.TabIndex = 5;
            checkPass.UseVisualStyleBackColor = true;
            checkPass.CheckedChanged += checkPass_CheckedChanged;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 276);
            Controls.Add(checkPass);
            Controls.Add(LogInButton);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AppForm";
            Text = "journal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Label labelLogin;
        private Label labelPassword;
        private Button LogInButton;
        private CheckBox checkPass;
    }
}
