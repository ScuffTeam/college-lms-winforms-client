namespace college_lms_winforms_client
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            PasswordBox.UseSystemPasswordChar = checkPass.Checked;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;

            if (login == "admin" && password == "123") // ������ ��������
            {
                MessageBox.Show("���� ��������", "������ ��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("���� �� ��������", "������������ ������ ��� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = checkPass.Checked;
        }
    }
}
