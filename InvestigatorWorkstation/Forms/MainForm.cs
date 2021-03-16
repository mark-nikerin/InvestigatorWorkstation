using InvestigatorWorkstation.Forms.CrimeReport;
using InvestigatorWorkstation.Forms.Employee;
using InvestigatorWorkstation.ViewModels;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Services.Interfaces;
using Services.Interfaces.CrimeReport;
using Services.Interfaces.Employee;
using Services.Services;
using System;
using System.Collections;
using System.Collections.Generic;
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

        private static IDictionary<string, (DataGridViewColumn, ListSortDirection)> _gridViewSortings = 
            new Dictionary<string, (DataGridViewColumn, ListSortDirection)>();

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

        #region Helpers

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            MainTabContainer.SelectedTab.Hide();
            switch ((sender as Button)?.Name)
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
                case "CriminalButton":
                    SetActiveButton(CriminalButton);
                    MainTabContainer.SelectedIndex = 5;
                    break;
                case "RanksAndPositionsButton":
                    SetActiveButton(RanksAndPositionsButton);
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

                        SortGridView(EmployeeGridView);

                        break;
                    }
                case "CriminalCaseTabPage":
                    {
                        break;
                    }
                case "CrimeReportTabPage":
                    {
                        var crimeReports = await _crimeReportService.GetCrimeReports();
                        CrimeReportGridView.DataSource = new SortableBindingList<CrimeReportViewModel>(crimeReports
                            .Select(x => (CrimeReportViewModel)x)
                            .ToList());

                        SortGridView(CrimeReportGridView);

                        break;
                    }
                case "CalendarTabPage":
                    {
                        break;
                    }
                case "RanksAndPositionsTabPage":
                    {
                        var ranks = await _employeeRankService.GetRanks();
                        RankGridView.DataSource = new SortableBindingList<RankViewModel>(ranks
                            .Select(x => (RankViewModel)x)
                            .ToList());

                        SortGridView(RankGridView);

                        var positions = await _employeePositionService.GetPositions();
                        PositionGridView.DataSource = new SortableBindingList<PositionViewModel>(positions
                            .Select(x => (PositionViewModel)x)
                            .ToList());

                        SortGridView(PositionGridView);

                        break;
                    }
            }

            MainTabContainer.SelectedTab.Show();
        }

        private void DataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) => e.PaintParts &= ~DataGridViewPaintParts.Focus;

        private void PictureButtonOnHoverIn(object sender, EventArgs e) => (sender as PictureBox).BackColor = Color.WhiteSmoke;

        private void PictureButtonOnHoverOut(object sender, EventArgs e) => (sender as PictureBox).BackColor = Color.Transparent;

        private void SortGridView(DataGridView dataGridView)
        {
            if (!_gridViewSortings.TryGetValue(dataGridView.Name, out var lastSorting))
            {
                if (dataGridView.SortedColumn == null) return;

                _gridViewSortings.Add(dataGridView.Name, lastSorting);
            }

            var (lastSortedColumn, lastSortOrder) = _gridViewSortings[dataGridView.Name];

            var sortedColumn = dataGridView.SortedColumn ?? lastSortedColumn;

            if (dataGridView.SortOrder != SortOrder.None)
            {
                lastSortOrder = dataGridView.SortOrder == SortOrder.Ascending
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending;
            }

            _gridViewSortings[dataGridView.Name] = (sortedColumn, lastSortOrder);

            var newSortColumn = dataGridView.Columns[sortedColumn.Name];
            dataGridView.Sort(newSortColumn, lastSortOrder);
            newSortColumn.HeaderCell.SortGlyphDirection =
                             lastSortOrder == ListSortDirection.Ascending ?
                             SortOrder.Ascending : SortOrder.Descending;

            dataGridView.Update();
        }

        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SortGridView(sender as DataGridView);
        }

        #endregion

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
                CriminalButton.Location = new Point
                {
                    X = EmployeeButton.Location.X,
                    Y = EmployeeButton.Location.Y + (2 * (EmployeeButton.Height - 1))
                };
                RanksAndPositionsButton.Location = new Point
                {
                    X = EmployeeButton.Location.X,
                    Y = EmployeeButton.Location.Y + (3 * (EmployeeButton.Height - 1))
                };
            }
            else
            {
                EmployeeButton.Hide();
                AuthorityButton.Location = EmployeeButton.Location;
                CriminalButton.Location = new Point
                {
                    X = EmployeeButton.Location.X,
                    Y = EmployeeButton.Location.Y + (1 * (EmployeeButton.Height - 1))
                };
                RanksAndPositionsButton.Location = new Point
                {
                    X = EmployeeButton.Location.X,
                    Y = EmployeeButton.Location.Y + (2 * (EmployeeButton.Height - 1))
                };
            }
        }

        #endregion

        #region EmployeeTab
         
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
                 
                SortGridView(EmployeeGridView);
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
                 
                SortGridView(EmployeeGridView);
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
        }
      
        #endregion

        #region CrimeReportTab

        private async void AddCrimeReportButton_Click(object sender, EventArgs e)
        {
            using var addCrimeReportForm = new AddCrimeReportForm(null);

            var dialogResult = addCrimeReportForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                await _crimeReportService.AddCrimeReport(addCrimeReportForm.GetResult());

                var crimeReports = await _crimeReportService.GetCrimeReports();

                CrimeReportGridView.DataSource = new SortableBindingList<CrimeReportViewModel>(crimeReports
                    .Select(x => (CrimeReportViewModel)x)
                    .ToList());

                SortGridView(CrimeReportGridView);
            }
        }

        private async void DeleteCrimeReportButton_Click(object sender, EventArgs e)
        {
            var selectedCrimeReportViewModel = (CrimeReportViewModel)CrimeReportGridView.SelectedRows[0].DataBoundItem;
            await _crimeReportService.RemoveCrimeReport(selectedCrimeReportViewModel.Id);

            var crimeReports = await _crimeReportService.GetCrimeReports();

            CrimeReportGridView.DataSource = new SortableBindingList<CrimeReportViewModel>(crimeReports
                .Select(x => (CrimeReportViewModel)x)
                .ToList());
        }

        #endregion

        private void AddCriminalCaseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
