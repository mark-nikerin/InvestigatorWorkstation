namespace InvestigatorWorkstation.Forms
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
            LoginTextBox.KeyUp += ControlPressEnter;
            LoginTextBox.KeyDown += AvoidBeepOnPressEnter;
            PasswordTextBox.KeyUp += ControlPressEnter;
            PasswordTextBox.KeyDown += AvoidBeepOnPressEnter;
        } 

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

        private void ControlPressEnter(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void AvoidBeepOnPressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
