namespace InvestigatorWorkstation
{
    using Services.Interfaces;
    using System;
    using System.Windows.Forms;

    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private readonly RegisterForm _registerForm;
        private readonly MainForm _mainForm;

        private static string CurrentUserName;

        public LoginForm(IAuthService authService, RegisterForm registerForm, MainForm mainForm)
        {
            _authService = authService;
            _registerForm = registerForm;
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            _registerForm.ShowDialog();
            Enabled = true;
        }

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            CurrentUserName = await _authService.AuthorizeUser(LoginTextBox.Text, PasswordTextBox.Text);
            _mainForm.Show();
            Hide();
        }
    }
}
