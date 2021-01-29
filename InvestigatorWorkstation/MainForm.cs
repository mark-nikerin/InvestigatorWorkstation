using Services.Interfaces;
using Services.Services;
using System.Drawing;
using System.Windows.Forms;

namespace InvestigatorWorkstation
{
    public partial class MainForm : Form
    {
        private readonly LoginForm _loginForm;
        private readonly IAuthService _authService;

        public MainForm(LoginForm loginForm, IAuthService authService)
        {
            _loginForm = loginForm;
            _authService = authService;
            InitializeComponent();
            SetActiveButton(CriminalReportButton);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            //Hide();

            //if (CurrentUserService.GetCurrentUser() == null)
            //{
            //    _loginForm.ShowDialog();
            //}

            //var currentUser = CurrentUserService.GetCurrentUser();
            //if (currentUser == null)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    UserNameLabel.Text = currentUser.FirstName;
            //    EmployeeButton.Enabled = CurrentUserService.IsAdmin();
            //    Show();
            //}
        }

        private void SidebarButton_Click(object sender, System.EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "CriminalReportButton":
                    SetActiveButton(CriminalReportButton);
                    MainTabContainer.SelectedIndex = 0;
                    break;
                case "CriminalCaseButton":
                    SetActiveButton(CriminalCaseButton);
                    MainTabContainer.SelectedIndex = 1;
                    break;
                case "CalendarButton":
                    SetActiveButton(CalendarButton);
                    MainTabContainer.SelectedIndex = 2;
                    break;
                case "EmployeeButton":
                    SetActiveButton(EmployeeButton);
                    MainTabContainer.SelectedIndex = 3;
                    break;
                case "QualificationButton":
                    SetActiveButton(QualificationButton);
                    MainTabContainer.SelectedIndex = 4;
                    break;
            }
        }

        private void SetActiveButton(Button button)
        {
            foreach (var control in MainSplitContainer.Panel1.Controls)
            {
                if (control is Button sidebarButton)
                {
                    sidebarButton.BackColor = Color.FromArgb(249, 249, 249);
                    sidebarButton.Font = new Font("Segoe UI", 12.0F, FontStyle.Regular);
                }
            }

            button.BackColor = Color.FromArgb(230, 239, 255);
            button.Font = new Font("Segoe UI", 12.0F, FontStyle.Bold);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void LogoutLabel_Click(object sender, System.EventArgs e)
        { 
            _authService.UnauthorizeUser();
            Hide();

            if (CurrentUserService.GetCurrentUser() == null)
            {
                _loginForm.ShowDialog();
            }

            var currentUser = CurrentUserService.GetCurrentUser();
            if (currentUser == null)
            {
                Application.Exit();
            }
            else
            {
                UserNameLabel.Text = currentUser.FirstName;
                EmployeeButton.Enabled = CurrentUserService.IsAdmin();
                Show();
            }
        }
    }
}
