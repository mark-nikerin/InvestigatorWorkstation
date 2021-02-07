using System.Windows.Forms;
using Services.DTOs.Employee;

namespace InvestigatorWorkstation.Forms.Employee
{
    public partial class UpdateEmployeeForm : Form
    {
        private EmployeeDTO _currentEmployee { get; set; }

        public UpdateEmployeeForm(EmployeeDTO employeeDTO)
        {
            _currentEmployee = employeeDTO;
            InitializeComponent();
            FirstNameTextBox.Text = employeeDTO.FirstName;
            MiddleNameTextBox.Text = employeeDTO.MiddleName;
            LastNameTextBox.Text = employeeDTO.LastName;
            BirthDateTimePicker.Value = employeeDTO.BirthDate;
            ContractDateTimePicker.Value = employeeDTO.ContractDate;
            PersonalNumberTextBox.Text = employeeDTO.Number.ToString();
            QualificationUpdateDateTimePicker.Value = employeeDTO.QualificationUpdateDate;
            CertificationTermDateTimePicker.Value = employeeDTO.CertificationTerm;
            JoinServiceDateTimePicker.Value = employeeDTO.JoinServiceDate;
            LoginTextBox.Text = employeeDTO.Login;
            PositionComboBox.SelectedItem = employeeDTO.Position.Name;
            PositionOrderDateTimePicker.Value = employeeDTO.Rank.OrderDate;
            PositionAppointmentDateTimePicker.Value = employeeDTO.Position.AppointmentDate;
            PositionOrderNumberTextBox.Text = employeeDTO.Position.OrderNumber.ToString();
            RankComboBox.SelectedItem = employeeDTO.Rank.Name;
            RankOrderDateTimePicker.Value = employeeDTO.Rank.OrderDate;
            RankAppointmentDateTimePicker.Value = employeeDTO.Rank.AppointmentDate;
            RankOrderNumberTextBox.Text = employeeDTO.Rank.OrderNumber.ToString();
            RankTermNumeric.Value = employeeDTO.Rank.Term;
        }

        private void UpdateEmployeeButton_Click(object sender, System.EventArgs e)
        { 
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
    }
}
