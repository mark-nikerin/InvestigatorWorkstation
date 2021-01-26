using Services.Services;
using System.Drawing;
using System.Windows.Forms;

namespace InvestigatorWorkstation
{
    public partial class MainForm : Form
    {
        private readonly LoginForm _loginForm;

        public MainForm(LoginForm loginForm)
        {
            _loginForm = loginForm;
            InitializeComponent();
            SetActiveButton(CrimeReportsButton);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            Hide();
            while (CurrentUserService.GetCurrentUser() == null)
            {
                _loginForm.ShowDialog();
            }
            var currentUser = CurrentUserService.GetCurrentUser();
            UserNameLabel.Text = $"{currentUser.LastName} {currentUser.FirstName[0]}.{currentUser.MiddleName[0]}.";
            Show();
        }

        private void SidebarButton_Click(object sender, System.EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "CrimeReportsButton":
                    SetActiveButton(CrimeReportsButton);
                    TabContainer.SelectedIndex = 0;
                    break;
                case "CriminalCasesButton":
                    SetActiveButton(CriminalCasesButton);
                    TabContainer.SelectedIndex = 1;
                    break;
                case "CalendarButton":
                    SetActiveButton(CalendarButton);
                    TabContainer.SelectedIndex = 2;
                    break;
                case "EmployeesButton":
                    SetActiveButton(EmployeesButton);
                    break;
                case "QualificationsButton":
                    SetActiveButton(QualificationsButton);
                    break;
            }
        }

        private void SetActiveButton(Button button)
        {
            foreach (var control in splitContainer1.Panel1.Controls)
            {
                if (control is Button sidebarButton)
                {
                    sidebarButton.BackColor = Color.FromArgb(249, 249, 249);
                    sidebarButton.Font = new Font("Segoe UI", 13.0F, FontStyle.Regular);
                }
            }

            button.BackColor = Color.FromArgb(230, 239, 255);
            button.Font = new Font("Segoe UI", 13.0F, FontStyle.Bold);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
