using System;
using Services.DTOs.Employee;
using System.Windows.Forms;
using System.Collections.Generic;

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
                    OrderNumber = int.Parse(RankOrderNumberTextBox.Text),
                    Term = (int)RankTermNumeric.Value
                },
                Position = new PositionWithInfoDTO
                {
                    Id = (int)PositionComboBox.SelectedValue,
                    Name = PositionComboBox.SelectedText,
                    OrderDate = PositionOrderDateTimePicker.Value,
                    AppointmentDate = PositionAppointmentDateTimePicker.Value,
                    OrderNumber = int.Parse(PositionOrderNumberTextBox.Text)
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
    }
}
