namespace InvestigatorWorkstation
{
    using Services.Interfaces;
    using System;
    using System.Windows.Forms;

    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;

        public LoginForm(IAuthService authService)
        {
            _authService = authService;
            InitializeComponent();
        }

        //private void RegistrationButton_Click(object sender, EventArgs e)
        //{
        //    Enabled = false;
        //    _registerForm.ShowDialog();
        //    Enabled = true;
        //}

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _authService.AuthorizeUser(LoginTextBox.Text, PasswordTextBox.Text); 
                Hide();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Введён неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
