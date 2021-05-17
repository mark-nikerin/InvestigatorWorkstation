using InvestigatorWorkstation.Forms.CrimeReport;
using InvestigatorWorkstation.Forms.Employee;
using InvestigatorWorkstation.ViewModels;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Services.DTOs.CrimeReport;
using Services.Interfaces;
using Services.Interfaces.CrimeReport;
using Services.Interfaces.Employee;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IAuthorityService _authorityService;
        private double baseCalendarColumnProportion;
        private List<string> currentCalendarDays = new List<string>();

        private static IDictionary<string, (DataGridViewColumn, ListSortDirection)> _gridViewSortings = 
            new Dictionary<string, (DataGridViewColumn, ListSortDirection)>();

        public MainForm(
            LoginForm loginForm,
            IAuthService authService,
            IEmployeeService employeeService,
            IEmployeePositionService employeePositionService,
            IEmployeeRankService employeeRankService,
            ICrimeReportService crimeReportService, 
            IAuthorityService authorityService)
        {
            _loginForm = loginForm;
            _authService = authService;
            _employeeService = employeeService;
            _employeePositionService = employeePositionService;
            _employeeRankService = employeeRankService;
            _crimeReportService = crimeReportService;
            _authorityService = authorityService;

            InitializeComponent();
            SetActiveButton(CrimeReportButton);
            MainTabContainer.ItemSize = new Size(0, 1);
            MainTabContainer.SizeMode = TabSizeMode.Fixed;
            SetDates(DateTime.Now);
            baseCalendarColumnProportion = (double) CalendarSplitContainer.Panel1.Width / CalendarSplitContainer.Panel1.Controls["FlowPanelDay0"].Width;
        }

        #region Helpers

        private async void SidebarButton_Click(object sender, EventArgs e)
        {
            MainTabContainer.SelectedTab.Hide();
            switch ((sender as Button)?.Name)
            {
                case "CalendarButton":
                    {
                        SetActiveButton(CalendarButton);
                        MainTabContainer.SelectedIndex = 0;

                        await UpdateCalendar();

                        break;
                    }
                case "CrimeReportButton":
                    {
                        SetActiveButton(CrimeReportButton);
                        MainTabContainer.SelectedIndex = 1;

                        var crimeReports = await _crimeReportService.GetCrimeReports();
                        CrimeReportGridView.DataSource = new SortableBindingList<CrimeReportViewModel>(crimeReports
                            .Select(x => (CrimeReportViewModel)x)
                            .ToList());

                        SortGridView(CrimeReportGridView);
                        break;
                    }
                case "CriminalCaseButton":
                    SetActiveButton(CriminalCaseButton);
                    MainTabContainer.SelectedIndex = 2;
                    break;
                case "EmployeeButton":
                    {
                        SetActiveButton(EmployeeButton);
                        MainTabContainer.SelectedIndex = 3;

                        var employees = await _employeeService.GetEmployees();
                        EmployeeGridView.DataSource = new SortableBindingList<EmployeeViewModel>(employees
                            .Select(x => (EmployeeViewModel)x)
                            .ToList());

                        SortGridView(EmployeeGridView);
                        break;
                    }
                case "AuthorityButton":
                    {
                        SetActiveButton(AuthorityButton);
                        MainTabContainer.SelectedIndex = 4;

                        var authorities = await _authorityService.GetAuthorities();
                        AuthorityGridView.DataSource = new SortableBindingList<AuthorityViewModel>(authorities
                            .Select(x => (AuthorityViewModel)x)
                            .ToList());

                        SortGridView(AuthorityGridView);
                        break;
                    }
                case "CriminalButton":
                    SetActiveButton(CriminalButton);
                    MainTabContainer.SelectedIndex = 5;
                    break;
                case "RanksAndPositionsButton":
                    {
                        SetActiveButton(RanksAndPositionsButton);
                        MainTabContainer.SelectedIndex = 6;

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

                UserNameLabel.Text = $"{currentUser.LastName} {currentUser.FirstName[0]}. {currentUser.MiddleName[0]}.";
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
                AddCrimeReportButton.Visible = true;
            }
            else
            {
                AddCrimeReportButton.Visible = false;
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
            var authorities = await _authorityService.GetAuthorities();
            var employees = await _employeeService.GetEmployees();

            using var addCrimeReportForm = new AddCrimeReportForm(authorities.ToList(), employees);

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

        #region AuthorityTab

        private async void AddAuthorityButton_Click(object sender, EventArgs e)
        {
            using var addAuthorityForm = new AddAuthorityForm();

            var dialogResult = addAuthorityForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                await _authorityService.AddAuthority(addAuthorityForm.GetResult());

                var authorities = await _authorityService.GetAuthorities();

                AuthorityGridView.DataSource = new SortableBindingList<AuthorityViewModel>(authorities
                    .Select(x => (AuthorityViewModel)x)
                    .ToList());

                SortGridView(AuthorityGridView);
            }
        }

        private async void RemoveAuthorityButton_Click(object sender, EventArgs e)
        {
            var selectedAuthorityViewModel = (AuthorityViewModel)AuthorityGridView.SelectedRows[0].DataBoundItem;
            await _authorityService.RemoveAuthority(selectedAuthorityViewModel.Id);

            var authorities = await _authorityService.GetAuthorities();

            AuthorityGridView.DataSource = new SortableBindingList<AuthorityViewModel>(authorities
                .Select(x => (AuthorityViewModel)x)
                .ToList());
        }

        #endregion

        #region Ranks

        private async void AddRankPictureButton_Click(object sender, EventArgs e)
        {
            using var addRankForm = new RankForm();

            var dialogResult = addRankForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                await _employeeRankService.AddRank(addRankForm.GetResult());

                var ranks = await _employeeRankService.GetRanks();

                RankGridView.DataSource = new SortableBindingList<RankViewModel>(ranks
                    .Select(x => (RankViewModel)x)
                    .ToList());

                SortGridView(RankGridView);
            }
        }

        private async void DeleteRankPictureButton_Click(object sender, EventArgs e)
        {
            var selectedRankViewModel = (RankViewModel)RankGridView.SelectedRows[0].DataBoundItem;
            await _employeeRankService.RemoveRank(selectedRankViewModel.Id);

            var ranks = await _employeeRankService.GetRanks();

            RankGridView.DataSource = new SortableBindingList<RankViewModel>(ranks
                .Select(x => (RankViewModel)x)
                .ToList());
        }

        private async void EditRankPictureButton_Click(object sender, EventArgs e)
        {
            var selectedRankViewModel = (RankViewModel)RankGridView.SelectedRows[0].DataBoundItem;
            var selectedRankDTO = await _employeeRankService.GetRank(selectedRankViewModel.Id);

            using var editRankForm = new RankForm(selectedRankDTO);

            var dialogResult = editRankForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                await _employeeRankService.UpdateRank(selectedRankDTO.Id, editRankForm.GetResult());

                var ranks = await _employeeRankService.GetRanks();

                RankGridView.DataSource = new SortableBindingList<RankViewModel>(ranks
                    .Select(x => (RankViewModel)x)
                    .ToList());

                SortGridView(RankGridView);
            }
        }

        #endregion

        #region Positions

        private async void AddPositionPictureButton_Click(object sender, EventArgs e)
        {
            using var addPositionForm = new PositionForm();

            var dialogResult = addPositionForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                await _employeePositionService.AddPosition(addPositionForm.GetResult());

                var positions = await _employeePositionService.GetPositions();

                PositionGridView.DataSource = new SortableBindingList<PositionViewModel>(positions
                    .Select(x => (PositionViewModel)x)
                    .ToList());

                SortGridView(PositionGridView);
            }
        }

        private async void EditPositionPictureButton_Click(object sender, EventArgs e)
        {
            var selectedPositionViewModel = (PositionViewModel)PositionGridView.SelectedRows[0].DataBoundItem;
            var selectedPositionDTO = await _employeePositionService.GetPosition(selectedPositionViewModel.Id);

            using var editPositionForm = new PositionForm(selectedPositionDTO);

            var dialogResult = editPositionForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                await _employeePositionService.UpdatePosition(selectedPositionDTO.Id, editPositionForm.GetResult());

                var positions = await _employeePositionService.GetPositions();

                PositionGridView.DataSource = new SortableBindingList<PositionViewModel>(positions
                    .Select(x => (PositionViewModel)x)
                    .ToList());

                SortGridView(PositionGridView);
            }
        }

        private async void DeletePositionPictureButton_Click(object sender, EventArgs e)
        {
            var selectedPositionViewModel = (PositionViewModel)PositionGridView.SelectedRows[0].DataBoundItem;
            await _employeePositionService.RemovePosition(selectedPositionViewModel.Id);

            var positions = await _employeePositionService.GetPositions();

            PositionGridView.DataSource = new SortableBindingList<PositionViewModel>(positions
                .Select(x => (PositionViewModel)x)
                .ToList());
        }

        #endregion

        #region Calendar

        private void SetDates(DateTime? startDate = null)
        {
            currentCalendarDays = new List<string>();
            var date = startDate ?? DateTime.Now;
            for (var i = 0; i < 5; i++)
            {
                currentCalendarDays.Add(date.ToString("dd MM yyyy"));

                var dayTitle = (Label) CalendarSplitContainer.Panel1.Controls[$"labelDay{i}"];
                dayTitle.Text = date.ToString("ddd, dd MMMM ");

                dayTitle.Font = date.ToString("dd MM yyyy").Equals(DateTime.Now.ToString("dd MM yyyy"))
                        ? new Font(dayTitle.Font, FontStyle.Bold)
                        : new Font(dayTitle.Font, FontStyle.Regular);

                date = date.AddDays(1);
                dayTitle.Refresh();
            }
        }

        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        { 
            await UpdateCalendar(e.Start);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            if (MainTabContainer.SelectedIndex != 0)
                return;

            var calendarColumnWidth = CalendarSplitContainer.Panel1.Controls["FlowPanelDay0"].Width;
            var calendarColumnNewWidth = (int)(CalendarSplitContainer.Panel1.Width / baseCalendarColumnProportion);
            var diff = calendarColumnNewWidth - calendarColumnWidth;

            for (var i = 0; i < 5; i++)
            {
                var column = (FlowLayoutPanel)CalendarSplitContainer.Panel1.Controls[$"FlowPanelDay{i}"];
                var dayTitle = (Label)CalendarSplitContainer.Panel1.Controls[$"labelDay{i}"];

                foreach (Panel item in column.Controls)
                {
                    item.Width = calendarColumnNewWidth;
                }

                column.Width = calendarColumnNewWidth;
                dayTitle.Width = calendarColumnNewWidth;

                if (i == 0) continue;

                column.Location = new Point { X = column.Location.X + i * diff, Y = column.Location.Y };
                dayTitle.Location = new Point { X = dayTitle.Location.X + i * diff, Y = dayTitle.Location.Y };
            }
        }

        private Panel CreateCalendarTaskPanel(CrimeReportDTO model, bool withNames = false)
        {
            var panel = new Panel();

            var registryNumberLabel = new Label();
            registryNumberLabel.AutoSize = true;
            registryNumberLabel.Text = $"Рег. Номер {model.RegistrationNumber}";

            panel.Controls.Add(registryNumberLabel);

            if (withNames)
            {
                var assigneeLabel = new Label();
                assigneeLabel.AutoSize = true;
                assigneeLabel.Text = $"{model.Employee.FullName}";
                panel.Controls.Add(assigneeLabel);
                assigneeLabel.Location = new Point { X = registryNumberLabel.Location.X, Y = registryNumberLabel.Location.Y + 20 };
                assigneeLabel.Refresh();
            }

            var diff = model.DueDate.Subtract(DateTime.Now);
            panel.BackColor = diff.Days switch
            {
                var x when (x >= 0 && x < 2) => Color.Red,
                var x when (x >= 2 && x < 4) => Color.Orange,
                var x when (x >= 4 && x < 6) => Color.Yellow,
                var x when (x >= 6) => Color.LightBlue,
                var x when (x < 0) => Color.LightGray,
                _ => Color.LightGray
            };

            panel.Width = CalendarSplitContainer.Panel1.Controls["FlowPanelDay0"].Width;

            return panel;
        }

        private async Task UpdateCalendar(DateTime? startDate = null)
        {
            SetDates(startDate);

            var crimeReports = await _crimeReportService.GetCrimeReports();

            var withNames = CurrentUserService.IsAdmin();

            for (var i = 0; i < 5; i++)
            {
                var column = (FlowLayoutPanel)CalendarSplitContainer.Panel1.Controls[$"FlowPanelDay{i}"];
                column.Controls.Clear();
            }

            foreach (var crimeReport in crimeReports)
            {
                var currentCalendarDay = currentCalendarDays.FirstOrDefault(x => x.Equals(crimeReport.DueDate.ToString("dd MM yyyy")));

                if (string.IsNullOrEmpty(currentCalendarDay))
                    continue;

                var calendarPanelTask = CreateCalendarTaskPanel(crimeReport, withNames);

                var index = currentCalendarDays.IndexOf(currentCalendarDay);

                var calendarColumn = (FlowLayoutPanel)CalendarSplitContainer.Panel1.Controls[$"FlowPanelDay{index}"];

                calendarColumn.Controls.Add(calendarPanelTask);
            }
        }

        #endregion

        private void AddCriminalCaseButton_Click(object sender, EventArgs e)
        {

        }

    }
}
