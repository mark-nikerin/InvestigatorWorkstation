namespace InvestigatorWorkstation
{
    using Services.Interfaces;
    using System;
    using System.Windows.Forms;

    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private static string CurrentUserName;

        public LoginForm(IAuthService authService)
        {
            _authService = authService;
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm(_authService);
            registerForm.Show();
        }

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            CurrentUserName = await _authService.AuthorizeUser(LoginTextBox.Text, PasswordTextBox.Text); 
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
