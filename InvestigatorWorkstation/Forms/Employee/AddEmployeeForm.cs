using System;
using Services.DTOs.Employee;
using System.Windows.Forms;

namespace InvestigatorWorkstation.Forms.Employee
{
    public partial class AddEmployeeForm : Form
    {
        private EmployeeDTO _currentEmployee { get; set; }

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            _currentEmployee = new EmployeeDTO
            {
                Id = 0,
                FirstName = FirstNameTextBox.Text,
                MiddleName = MiddleNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                BirthDate = BirthDateTimePicker.Value,
                ContractDate = ContractDateTimePicker.Value,
                CertificationTerm = CertificationTermDateTimePicker.Value,
                JoinServiceDate = JoinServiceDateTimePicker.Value,
                QualificationUpdateDate = QualificationUpdateDateTimePicker.Value,
                Rank = new RankDTO
                {
                    Name = "",
                    OrderDate = RankOrderDateTimePicker.Value,
                    AppointmentDate = RankAppointmentDateTimePicker.Value,
                    OrderNumber = int.Parse(RankOrderNumberTextBox.Text),
                    Term = (int)RankTermNumeric.Value
                },
                Position = new PositionDTO
                {
                    Name = "",
                    OrderDate = PositionOrderDateTimePicker.Value,
                    AppointmentDate = PositionAppointmentDateTimePicker.Value,
                    OrderNumber = int.Parse(PositionOrderNumberTextBox.Text)
                },
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text
            };

            DialogResult = DialogResult.OK;
        }

        public EmployeeDTO GetResult()
        {
            return _currentEmployee;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _currentEmployee = null;
            DialogResult = DialogResult.Cancel;
        } 
    }
}
