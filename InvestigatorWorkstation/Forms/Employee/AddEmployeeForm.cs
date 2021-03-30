using System;
using Services.DTOs.Employee;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace InvestigatorWorkstation.Forms.Employee
{
    public partial class AddEmployeeForm : Form
    {
        private EmployeeDTO _employee { get; set; }

        public AddEmployeeForm(IEnumerable<PositionDTO> positions, IEnumerable<RankDTO> ranks)
        {
            InitializeComponent();
            PositionComboBox.DataSource = positions; 
            RankComboBox.DataSource = ranks;

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

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            _employee = new EmployeeDTO
            {
                FirstName = FirstNameTextBox.Text,
                MiddleName = MiddleNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                BirthDate = BirthDateTimePicker.Value,
                ContractDate = ContractDateTimePicker.Value,
                CertificationTerm = CertificationTermDateTimePicker.Value,
                JoinServiceDate = JoinServiceDateTimePicker.Value,
                QualificationUpdateDate = QualificationUpdateDateTimePicker.Value,
                Rank = new RankWithInfoDTO
                {
                    Id = (int)RankComboBox.SelectedValue,
                    Name = RankComboBox.SelectedText,
                    OrderDate = RankOrderDateTimePicker.Value,
                    AppointmentDate = RankAppointmentDateTimePicker.Value,
                    OrderNumber = RankOrderNumberTextBox.Text,
                },
                Position = new PositionWithInfoDTO
                {
                    Id = (int)PositionComboBox.SelectedValue,
                    Name = PositionComboBox.SelectedText,
                    OrderDate = PositionOrderDateTimePicker.Value,
                    AppointmentDate = PositionAppointmentDateTimePicker.Value,
                    OrderNumber = PositionOrderNumberTextBox.Text
                },
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                IsAdmin = IsAdminCheckBox.Checked
            };

            DialogResult = DialogResult.OK;
        }

        public EmployeeDTO GetResult()
        {
            return _employee;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _employee = null;
            DialogResult = DialogResult.Cancel;
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
