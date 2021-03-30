using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Services.DTOs.Employee;

namespace InvestigatorWorkstation.Forms.Employee
{
    public partial class UpdateEmployeeForm : Form
    {
        private EmployeeDTO _currentEmployee { get; set; } 

        public UpdateEmployeeForm(EmployeeDTO employeeDTO, IEnumerable<PositionDTO> positions, IEnumerable<RankDTO> ranks)
        {
            _currentEmployee = employeeDTO;

            InitializeComponent();

            #region Fill fields
            FirstNameTextBox.Text = employeeDTO.FirstName;
            MiddleNameTextBox.Text = employeeDTO.MiddleName;
            LastNameTextBox.Text = employeeDTO.LastName;
            BirthDateTimePicker.Value = employeeDTO.BirthDate;
            ContractDateTimePicker.Value = employeeDTO.ContractDate;
            PersonalNumberTextBox.Text = employeeDTO.Number;
            QualificationUpdateDateTimePicker.Value = employeeDTO.QualificationUpdateDate;
            CertificationTermDateTimePicker.Value = employeeDTO.CertificationTerm;
            JoinServiceDateTimePicker.Value = employeeDTO.JoinServiceDate;

            PositionComboBox.DataSource = positions;
            PositionComboBox.SelectedValue = employeeDTO.Position.Id;
            PositionOrderDateTimePicker.Value = employeeDTO.Rank.OrderDate;
            PositionAppointmentDateTimePicker.Value = employeeDTO.Position.AppointmentDate;
            PositionOrderNumberTextBox.Text = employeeDTO.Position.OrderNumber;

            RankComboBox.DataSource = ranks;
            RankComboBox.SelectedValue = employeeDTO.Rank.Id;
            RankOrderDateTimePicker.Value = employeeDTO.Rank.OrderDate;
            RankAppointmentDateTimePicker.Value = employeeDTO.Rank.AppointmentDate;
            RankOrderNumberTextBox.Text = employeeDTO.Rank.OrderNumber;
            RankTermTextBox.Text = employeeDTO.Rank.TermEndDate.ToString();

            LoginTextBox.Text = employeeDTO.Login;
            PasswordTextBox.Text = employeeDTO.Password;
            IsAdminCheckBox.Checked = employeeDTO.IsAdmin;
            #endregion

            foreach (var control in Controls)
            {
                if (control is TextBox || control is DateTimePicker || control is ComboBox)
                {
                    var textbox = control as Control;
                    textbox.KeyUp += ControlPressEnter;
                    textbox.KeyDown += AvoidBeepOnPressEnter;
                }
            }

        }

        private void UpdateEmployeeButton_Click(object sender, System.EventArgs e)
        {
            _currentEmployee.FirstName = FirstNameTextBox.Text;
            _currentEmployee.MiddleName = MiddleNameTextBox.Text;
            _currentEmployee.LastName = LastNameTextBox.Text;
            _currentEmployee.BirthDate = BirthDateTimePicker.Value;
            _currentEmployee.ContractDate = ContractDateTimePicker.Value;
            _currentEmployee.Number = PersonalNumberTextBox.Text;
            _currentEmployee.QualificationUpdateDate = QualificationUpdateDateTimePicker.Value;
            _currentEmployee.CertificationTerm = CertificationTermDateTimePicker.Value;
            _currentEmployee.JoinServiceDate = JoinServiceDateTimePicker.Value;

            var selectedRank = (RankDTO)RankComboBox.SelectedItem;
            _currentEmployee.Rank.Id = selectedRank.Id;
            _currentEmployee.Rank.Name = selectedRank.Name;
            _currentEmployee.Rank.OrderDate = RankOrderDateTimePicker.Value;
            _currentEmployee.Rank.AppointmentDate = RankAppointmentDateTimePicker.Value;
            _currentEmployee.Rank.OrderNumber = RankOrderNumberTextBox.Text;
            _currentEmployee.Rank.Term = selectedRank.Term;
            _currentEmployee.Rank.TermEndDate = RankAppointmentDateTimePicker.Value.AddDays(selectedRank.Term);

            var selectedPosition = (PositionDTO)PositionComboBox.SelectedItem;
            _currentEmployee.Position.Id = selectedPosition.Id;
            _currentEmployee.Position.Name = selectedPosition.Name;
            _currentEmployee.Position.OrderDate = PositionOrderDateTimePicker.Value;
            _currentEmployee.Position.AppointmentDate = PositionAppointmentDateTimePicker.Value;
            _currentEmployee.Position.OrderNumber = PositionOrderNumberTextBox.Text;

            _currentEmployee.Login = LoginTextBox.Text;
            _currentEmployee.Password = PasswordTextBox.Text;
            _currentEmployee.IsAdmin = IsAdminCheckBox.Checked;

            DialogResult = DialogResult.OK;
        }

        private void CancelUpdateEmployeeButton_Click(object sender, System.EventArgs e)
        {
            _currentEmployee = null;
            DialogResult = DialogResult.Cancel;
        }

        public EmployeeDTO GetResult()
        {
            return _currentEmployee;
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

        private void RankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTermEndDate();
        }

        private void RankAppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateTermEndDate();
        }

        private void UpdateTermEndDate()
        {
            var rank = (RankDTO)RankComboBox.SelectedItem;

            var appointmentDate = RankAppointmentDateTimePicker.Value;

            if (rank?.Term != null && appointmentDate != default)
            {
                var termEndDate = appointmentDate.AddYears(rank.Term);
                RankTermTextBox.Text = termEndDate.ToShortDateString();
            }
            else
            {
                RankTermTextBox.Text = " - ";
            }
            RankTermTextBox.Refresh();
        }

    }
}
