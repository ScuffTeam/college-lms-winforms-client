namespace college_lms_winforms_client
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            PasswordBox.UseSystemPasswordChar = checkPass.Checked;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;

            if (login == "admin" && password == "123") // Пример проверки
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                Hide();
                mainForm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("вход не выполнен", "неправильный пароль или логин", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = checkPass.Checked;
        }
    }
}
