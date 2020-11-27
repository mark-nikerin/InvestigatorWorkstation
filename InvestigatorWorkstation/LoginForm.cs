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

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            CurrentUserName = await _authService.AuthorizeUser(textBox_login.Text, textBox_password.Text); 
            this.Hide();
            MainForm mainForm = new MainForm(CurrentUserName);
            mainForm.Show();
        } 
    }
}
