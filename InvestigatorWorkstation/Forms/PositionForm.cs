using System.Windows.Forms;
using Services.DTOs.Employee;

namespace InvestigatorWorkstation.Forms
{
    public partial class PositionForm : Form
    {
        private PositionDTO _position;

        public PositionForm(PositionDTO position = null)
        {
            InitializeComponent();
            _position = position;

            if (position != null)
            {
                PositionLabel.Text = "Изменение должности";
                PositionOkButton.Text = "Изменить";

                PositionTitleTextBox.Text = position.Name;
            }
        }

        public PositionDTO GetResult()
        {
            return _position;
        }

        private void PositionOkButton_Click(object sender, System.EventArgs e)
        {
            if (_position == null)
            {
                _position = new PositionDTO
                {
                    Name = PositionTitleTextBox.Text
                };
            }
            else
            {
                _position.Name = PositionTitleTextBox.Text;
            }

            DialogResult = DialogResult.OK;
        }

        private void PositionCancelButton_Click(object sender, System.EventArgs e)
        {
            _position = null;
            DialogResult = DialogResult.Cancel;
        }
    }
}
