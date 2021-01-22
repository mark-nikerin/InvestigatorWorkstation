using System;
using Services.Interfaces;
using Services.DTOs.Employee;
using System.Windows.Forms;

namespace InvestigatorWorkstation
{
    public partial class RegisterForm : Form
    {
        public EmployeeDTO CurrentEmployee { get; private set; }

        private readonly IEmployeeService _employeeService;

        public RegisterForm(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
        } 

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            CurrentEmployee = new EmployeeDTO
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

            _employeeService.AddEmployee(CurrentEmployee);
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
           CurrentEmployee = null;
           Hide();
        }
    }
}
