using InvestigatorWorkstation.Forms.Employee;
using InvestigatorWorkstation.ViewModels;
using Services.Interfaces;
using Services.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InvestigatorWorkstation.Forms
{
    public partial class MainForm : Form
    {
        private readonly LoginForm _loginForm;
        private readonly IAuthService _authService;
        private readonly IEmployeeService _employeeService;

        public MainForm(LoginForm loginForm, IAuthService authService, IEmployeeService employeeService)
        {
            _loginForm = loginForm;
            _authService = authService;
            _employeeService = employeeService;

            InitializeComponent();
            SetActiveButton(CriminalReportButton);
        }

        #region Authorization
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
        #endregion

        #region Switching tabs
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

        private async void MainTabContainer_SelectedTabChanged(object sender, System.EventArgs e)
        {
            switch (MainTabContainer.SelectedTab.Name)
            {
                case "EmployeeTabPage":
                    {
                        var employees = await _employeeService.GetEmployees();
                        EmployeeGridView.DataSource = employees
                            .Select(x => (EmployeeViewModel)x)
                            .ToList();
                        EmployeeGridView.Update();
                        break;
                    };
                case "CriminalCaseTabPage":
                    {
                        break;
                    };
                case "CriminalReportTabPage":
                    {
                        break;
                    };
                case "QualificationTabPage":
                    {
                        break;
                    };
                case "CalendarTabPage":
                    {
                        break;
                    };
            }
        }
        #endregion
       
        private void DataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        #region EmployeeTab

        private async void AddEmployeeButton_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult;

            using var addEmployeeForm = new AddEmployeeForm();

            dialogResult = addEmployeeForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                await _employeeService.AddEmployee(addEmployeeForm.GetResult());

                var employees = await _employeeService.GetEmployees();

                EmployeeGridView.DataSource = employees
                    .Select(x => (EmployeeViewModel)x)
                    .ToList();

                EmployeeGridView.Refresh();
            }
        }

        private async void EditEmployeeButton_Click(object sender, System.EventArgs e)
        {
            var selectedEmployeeViewModel = (EmployeeViewModel) EmployeeGridView.SelectedRows[0].DataBoundItem;

            var selectedEmployeeDTO = await _employeeService.GetEmployee(selectedEmployeeViewModel.Id);

            DialogResult dialogResult;

            using var updateEmployeeForm = new UpdateEmployeeForm(selectedEmployeeDTO);

            dialogResult = updateEmployeeForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            { 
                var employees = await _employeeService.GetEmployees();

                EmployeeGridView.DataSource = employees
                    .Select(x => (EmployeeViewModel)x)
                    .ToList();
                 
                EmployeeGridView.Refresh();
            }
        }

        #endregion

    }
}
