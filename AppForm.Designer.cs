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
            LoginBox.Location = new Point(59, 58);
            LoginBox.Margin = new Padding(5, 6, 5, 6);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(209, 35);
            LoginBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(59, 146);
            PasswordBox.Margin = new Padding(5, 6, 5, 6);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(209, 35);
            PasswordBox.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(59, 22);
            labelLogin.Margin = new Padding(5, 0, 5, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(68, 30);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(59, 114);
            labelPassword.Margin = new Padding(5, 0, 5, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(82, 30);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "пароль";
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(90, 193);
            LogInButton.Margin = new Padding(5, 6, 5, 6);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(129, 46);
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
            checkPass.Location = new Point(169, 114);
            checkPass.Margin = new Padding(5, 6, 5, 6);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(99, 34);
            checkPass.TabIndex = 5;
            checkPass.Text = "скрыть";
            checkPass.UseVisualStyleBackColor = true;
            checkPass.CheckedChanged += checkPass_CheckedChanged;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 277);
            Controls.Add(LogInButton);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            Controls.Add(checkPass);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 6, 5, 6);
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
