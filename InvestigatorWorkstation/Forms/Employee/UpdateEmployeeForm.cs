using System.Collections.Generic;
using System.Windows.Forms;
using Services.DTOs.Employee;

namespace InvestigatorWorkstation.Forms.Employee
{
    public partial class UpdateEmployeeForm : Form
    {
        private EmployeeDTO _currentEmployee { get; set; }
        private IEnumerable<PositionDTO> _positions;
        private IEnumerable<RankDTO> _ranks;

        public UpdateEmployeeForm(EmployeeDTO employeeDTO, IEnumerable<PositionDTO> positions, IEnumerable<RankDTO> ranks)
        {
            _currentEmployee = employeeDTO;
            _positions = positions;
            _ranks = ranks;

            InitializeComponent();

            #region Fill fields
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

            PositionComboBox.DataSource = positions;
            PositionComboBox.SelectedValue = employeeDTO.Position.Id;
            PositionOrderDateTimePicker.Value = employeeDTO.Rank.OrderDate;
            PositionAppointmentDateTimePicker.Value = employeeDTO.Position.AppointmentDate;
            PositionOrderNumberTextBox.Text = employeeDTO.Position.OrderNumber.ToString();

            RankComboBox.DataSource = ranks;
            RankComboBox.SelectedValue = employeeDTO.Rank.Id;
            RankOrderDateTimePicker.Value = employeeDTO.Rank.OrderDate;
            RankAppointmentDateTimePicker.Value = employeeDTO.Rank.AppointmentDate;
            RankOrderNumberTextBox.Text = employeeDTO.Rank.OrderNumber.ToString();
            RankTermNumeric.Value = employeeDTO.Rank.Term;
            #endregion

        }

        private void UpdateEmployeeButton_Click(object sender, System.EventArgs e)
        {
            _currentEmployee.FirstName = FirstNameTextBox.Text;
            _currentEmployee.MiddleName = MiddleNameTextBox.Text;
            _currentEmployee.LastName = LastNameTextBox.Text;
            _currentEmployee.BirthDate = BirthDateTimePicker.Value;
            _currentEmployee.ContractDate = ContractDateTimePicker.Value;
            _currentEmployee.CertificationTerm = CertificationTermDateTimePicker.Value;
            _currentEmployee.JoinServiceDate = JoinServiceDateTimePicker.Value;
            _currentEmployee.QualificationUpdateDate = QualificationUpdateDateTimePicker.Value;
            _currentEmployee.Rank.Id = (int)RankComboBox.SelectedValue;
            _currentEmployee.Rank.Name = RankComboBox.SelectedText;
            _currentEmployee.Rank.OrderDate = RankOrderDateTimePicker.Value;
            _currentEmployee.Rank.AppointmentDate = RankAppointmentDateTimePicker.Value;
            _currentEmployee.Rank.OrderNumber = int.Parse(RankOrderNumberTextBox.Text);
            _currentEmployee.Rank.Term = (int)RankTermNumeric.Value;
            _currentEmployee.Position.Id = (int)PositionComboBox.SelectedValue;
            _currentEmployee.Position.Name = PositionComboBox.SelectedText;
            _currentEmployee.Position.OrderDate = PositionOrderDateTimePicker.Value;
            _currentEmployee.Position.AppointmentDate = PositionAppointmentDateTimePicker.Value;
            _currentEmployee.Position.OrderNumber = int.Parse(PositionOrderNumberTextBox.Text);
            _currentEmployee.Login = LoginTextBox.Text;
            _currentEmployee.Password = PasswordTextBox.Text;

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
