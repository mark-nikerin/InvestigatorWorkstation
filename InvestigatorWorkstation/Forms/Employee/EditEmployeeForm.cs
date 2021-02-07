using System;
using Services.DTOs.Employee;
using System.Windows.Forms;

namespace InvestigatorWorkstation
{
    public partial class EditEmployeeForm : Form
    {
        private EmployeeDTO _currentEmployee { get; set; }

        public EditEmployeeForm(EmployeeDTO employeeDTO)
        {
            InitializeComponent();
            FirstNameTextBox.Text = employeeDTO.FirstName;
            MiddleNameTextBox.Text = employeeDTO.MiddleName;
            LastNameTextBox.Text = employeeDTO.LastName;
            BirthDateTimePicker.Value = employeeDTO.BirthDate;
            ContractDateTimePicker.Value = employeeDTO.ContractDate;
            CertificationTermDateTimePicker.Value = employeeDTO.CertificationTerm;
            JoinServiceDateTimePicker.Value = employeeDTO.JoinServiceDate;
            QualificationUpdateDateTimePicker.Value = employeeDTO.QualificationUpdateDate;
            LoginTextBox.Text = employeeDTO.Login;
            PasswordTextBox.Text = employeeDTO.Password;

            RankAppointmentDateTimePicker.Value = employeeDTO.Rank.AppointmentDate;
            PositionAppointmentDateTimePicker.Value = employeeDTO.Position.AppointmentDate;
            RankOrderNumberTextBox.Text = employeeDTO.Rank.OrderNumber.ToString();
            PositionOrderNumberTextBox.Text = employeeDTO.Position.ToString();
            RankOrderDateTimePicker.Value = employeeDTO.Rank.OrderDate;
            PositionOrderDateTimePicker.Value = employeeDTO.Position.OrderDate;
        } 

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _currentEmployee = null;
            DialogResult = DialogResult.Cancel;
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            _currentEmployee.FirstName = FirstNameTextBox.Text;
            _currentEmployee.MiddleName = MiddleNameTextBox.Text;
            _currentEmployee.LastName = LastNameTextBox.Text;
            _currentEmployee.BirthDate = BirthDateTimePicker.Value;
            _currentEmployee.ContractDate = ContractDateTimePicker.Value;
            _currentEmployee.CertificationTerm = CertificationTermDateTimePicker.Value;
            _currentEmployee.JoinServiceDate = JoinServiceDateTimePicker.Value;
            _currentEmployee.QualificationUpdateDate = QualificationUpdateDateTimePicker.Value;
            _currentEmployee.Login = LoginTextBox.Text;
            _currentEmployee.Password = PasswordTextBox.Text;
            _currentEmployee.Rank = new RankDTO
            {
                Name = "",
                OrderDate = RankOrderDateTimePicker.Value,
                AppointmentDate = RankAppointmentDateTimePicker.Value,
                OrderNumber = int.Parse(RankOrderNumberTextBox.Text),
                Term = (int)RankTermNumeric.Value
            };
            _currentEmployee.Position = new PositionDTO
            {
                Name = "",
                OrderDate = PositionOrderDateTimePicker.Value,
                AppointmentDate = PositionAppointmentDateTimePicker.Value,
                OrderNumber = int.Parse(PositionOrderNumberTextBox.Text)
            };

            DialogResult = DialogResult.OK;
        }

        public EmployeeDTO GetResult()
        {
            return _currentEmployee;
        }
    }
}
