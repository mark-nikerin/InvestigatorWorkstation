using InvestigatorWorkstation.Forms.Employee;
using InvestigatorWorkstation.ViewModels;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Services.Interfaces;
using Services.Interfaces.CrimeReport;
using Services.Interfaces.Employee;
using Services.Services;
using System;
using System.ComponentModel;
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
        private readonly IEmployeePositionService _employeePositionService;
        private readonly IEmployeeRankService _employeeRankService;
        private readonly ICrimeReportService _crimeReportService;

        public MainForm(
            LoginForm loginForm, 
            IAuthService authService, 
            IEmployeeService employeeService,
            IEmployeePositionService employeePositionService,
            IEmployeeRankService employeeRankService,
            ICrimeReportService crimeReportService)
        {
            _loginForm = loginForm;
            _authService = authService;
            _employeeService = employeeService;
            _employeePositionService = employeePositionService;
            _employeeRankService = employeeRankService;
            _crimeReportService = crimeReportService;

            InitializeComponent();
            SetActiveButton(CrimeReportButton);
            MainTabContainer.ItemSize = new Size(0, 1);
            MainTabContainer.SizeMode = TabSizeMode.Fixed;
        }

        #region Authorization
        private void MainForm_Load(object sender, EventArgs e)
        { 

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
                UpdateControlsByUserRole(CurrentUserService.IsAdmin());

                UserNameLabel.Text = currentUser.FirstName; 
                Show();
            }
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
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
                UpdateControlsByUserRole(CurrentUserService.IsAdmin());

                UserNameLabel.Text = currentUser.FirstName; 
                Show();
            }
        }

        private void UpdateControlsByUserRole(bool isAdmin)
        {
            MainTabContainer.SelectedTab = CalendarTabPage;
            SetActiveButton(CalendarButton);

            if (isAdmin)
            {
                EmployeeButton.Show();

                AuthorityButton.Location = new Point
                {
                    X = EmployeeButton.Location.X,
                    Y = EmployeeButton.Location.Y + EmployeeButton.Height - 1
                };

                QualificationButton.Location = new Point
                {
                    X = EmployeeButton.Location.X,
                    Y = EmployeeButton.Location.Y + (2 * (EmployeeButton.Height - 1))
                };

                CriminalButton.Location = new Point
                {
                    X = EmployeeButton.Location.X,
                    Y = EmployeeButton.Location.Y + (3 * (EmployeeButton.Height - 1))
                };
            }
            else
            {
                EmployeeButton.Hide();
                AuthorityButton.Location = EmployeeButton.Location;
                QualificationButton.Location = new Point
                {
                    X = EmployeeButton.Location.X,
                    Y = EmployeeButton.Location.Y + EmployeeButton.Height - 1
                };
                CriminalButton.Location = new Point
                {
                    X = EmployeeButton.Location.X,
                    Y = EmployeeButton.Location.Y + (2 * (EmployeeButton.Height - 1))
                };
            }
        }

        #endregion

        #region Switching tabs
        private void SidebarButton_Click(object sender, EventArgs e)
        {
            MainTabContainer.SelectedTab.Hide();
            switch (((Button)sender).Name)
            {
                case "CalendarButton":
                    SetActiveButton(CalendarButton);
                    MainTabContainer.SelectedIndex = 0;
                    break;
                case "CrimeReportButton":
                    SetActiveButton(CrimeReportButton);
                    MainTabContainer.SelectedIndex = 1;
                    break;
                case "CriminalCaseButton":
                    SetActiveButton(CriminalCaseButton);
                    MainTabContainer.SelectedIndex = 2;
                    break;
                case "EmployeeButton": 
                    SetActiveButton(EmployeeButton);
                    MainTabContainer.SelectedIndex = 3;
                    break;
                case "AuthorityButton":
                    SetActiveButton(AuthorityButton);
                    MainTabContainer.SelectedIndex = 4;
                    break;
                case "QualificationButton":
                    SetActiveButton(QualificationButton);
                    MainTabContainer.SelectedIndex = 5;
                    break;
                case "CriminalButton":
                    SetActiveButton(CriminalButton);
                    MainTabContainer.SelectedIndex = 6;
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

        private async void MainTabContainer_SelectedTabChanged(object sender, EventArgs e)
        {
            switch (MainTabContainer.SelectedTab.Name)
            {
                case "EmployeeTabPage":
                    {
                        var employees = await _employeeService.GetEmployees();
                        EmployeeGridView.DataSource = new SortableBindingList<EmployeeViewModel>(employees
                            .Select(x => (EmployeeViewModel)x)
                            .ToList());

                        EmployeeGridViewSort();
                         
                        break;
                    }
                case "CriminalCaseTabPage":
                    { 
                        break;
                    }
                case "CrimeReportTabPage":
                    {
                        var crimeReports = await _crimeReportService.GetCrimeReports();
                        CrimeReportGridView.DataSource = crimeReports
                            .Select(x => (CrimeReportViewModel)x)
                            .ToList();
                          
                        break;
                    }
                case "QualificationTabPage":
                    {
                        break;
                    }
                case "CalendarTabPage":
                    {
                        break;
                    }
            }

            MainTabContainer.SelectedTab.Show();
        }
        #endregion
        
        #region EmployeeTab

        #region ButtonEvents

        private async void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var positions = await _employeePositionService.GetPositions();
            var ranks = await _employeeRankService.GetRanks();

            using var addEmployeeForm = new AddEmployeeForm(positions, ranks);

            var dialogResult = addEmployeeForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                await _employeeService.AddEmployee(addEmployeeForm.GetResult());

                var employees = await _employeeService.GetEmployees();

                EmployeeGridView.DataSource = new SortableBindingList<EmployeeViewModel>(employees
                    .Select(x => (EmployeeViewModel)x)
                    .ToList());
                 
                EmployeeGridViewSort();
            }
        }

        private async void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            var selectedRowId = EmployeeGridView.SelectedRows[0].Index;
            var selectedEmployeeViewModel = (EmployeeViewModel)EmployeeGridView.SelectedRows[0].DataBoundItem;

            var selectedEmployeeDTO = await _employeeService.GetEmployee(selectedEmployeeViewModel.Id);

            var positions = await _employeePositionService.GetPositions();
            var ranks = await _employeeRankService.GetRanks();

            using var updateEmployeeForm = new UpdateEmployeeForm(selectedEmployeeDTO, positions, ranks);

            var dialogResult = updateEmployeeForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                await _employeeService.UpdateEmployee(selectedEmployeeDTO.Id, updateEmployeeForm.GetResult());

                var employees = await _employeeService.GetEmployees();

                EmployeeGridView.DataSource = new SortableBindingList<EmployeeViewModel>(employees
                    .Select(x => (EmployeeViewModel)x)
                    .ToList());
                EmployeeGridView.Rows[selectedRowId].Selected = true;
                 
                EmployeeGridViewSort();
            }
        }

        private async void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            var selectedEmployeeViewModel = (EmployeeViewModel)EmployeeGridView.SelectedRows[0].DataBoundItem;
            await _employeeService.RemoveEmployee(selectedEmployeeViewModel.Id);

            var employees = await _employeeService.GetEmployees();

            EmployeeGridView.DataSource = new SortableBindingList<EmployeeViewModel>(employees
                .Select(x => (EmployeeViewModel)x)
                .ToList()); 

            EmployeeGridViewSort();
        }

        #endregion

        private void EmployeeGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EmployeeGridViewSort();
        }

        private DataGridViewColumn lastSortedColumn;
        private ListSortDirection direction;

        private void EmployeeGridViewSort()
        {
            if (EmployeeGridView.SortedColumn == null && lastSortedColumn == null) return;

            lastSortedColumn = EmployeeGridView.SortedColumn ?? lastSortedColumn;

            if (EmployeeGridView.SortOrder != SortOrder.None)
            {
                direction = EmployeeGridView.SortOrder == SortOrder.Ascending
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending;
            }

            var newSortColumn = EmployeeGridView.Columns[lastSortedColumn.Name];
            EmployeeGridView.Sort(newSortColumn, direction);
            newSortColumn.HeaderCell.SortGlyphDirection =
                             direction == ListSortDirection.Ascending ?
                             SortOrder.Ascending : SortOrder.Descending;
             
            EmployeeGridView.Update();
        }

        #endregion

        #region Helpers

        private void DataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) => e.PaintParts &= ~DataGridViewPaintParts.Focus;

        private void PictureButtonOnHoverIn(object sender, EventArgs e) => (sender as PictureBox).BackColor = Color.WhiteSmoke;

        private void PictureButtonOnHoverOut(object sender, EventArgs e) => (sender as PictureBox).BackColor = Color.Transparent;

        #endregion
         
    }
}
