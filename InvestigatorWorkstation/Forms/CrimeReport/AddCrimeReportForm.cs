using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Services.DTOs.CrimeReport;
using Services.DTOs.Qualification;

namespace InvestigatorWorkstation.Forms.CrimeReport
{
    public partial class AddCrimeReportForm : Form
    {
        private CrimeReportDTO _crimeReport { get; set; }

        public AddCrimeReportForm(IEnumerable<QualificationDTO> qualifications)
        {
            InitializeComponent();
            QualificationComboBox.DataSource = qualifications;
        }

        public CrimeReportDTO GetResult()
        {
            return _crimeReport;
        }

        private void AddCrimeReportButton_Click(object sender, EventArgs e)
        {
            _crimeReport = new CrimeReportDTO
            {
                RegistrationNumber = RegistryNumberTextBox.Text,
                RegistrationBookNumber = RegistryBookNumberTextBox.Text,
                RegistrationDate = RegistrationDatePicker.Value,
                Fable = FableRichTextBox.Text, 
                // TODO добавить квалификации и органы УФСБ
            };
            DialogResult = DialogResult.OK;
        }

        private void CancelAddCrimeReportButton_Click(object sender, EventArgs e)
        {
            _crimeReport = null;
            DialogResult = DialogResult.Cancel;
        }

        private void YesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            YesRadioButton.ForeColor = YesRadioButton.Checked
                ? SystemColors.ControlText
                : SystemColors.GrayText;

            RegisteredAuthorityComboBox.Enabled = YesRadioButton.Checked;
        }

        private void NoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NoRadioButton.ForeColor = NoRadioButton.Checked
                ? SystemColors.ControlText
                : SystemColors.GrayText;

            CustomRegistrationAuthorityTextBox.Enabled = NoRadioButton.Checked;

        }

        private void FableRichTextBox_OnClick(object sender, EventArgs e)
        {
            if (FableRichTextBox.Text.Equals("Добавьте описание", StringComparison.OrdinalIgnoreCase))
            {
                FableRichTextBox.ForeColor = SystemColors.ControlText;
                FableRichTextBox.Text = "";
                FableRichTextBox.Refresh();
            }
        }
    }
}
