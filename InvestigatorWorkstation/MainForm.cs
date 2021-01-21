using System.Drawing;
using System.Windows.Forms;

namespace InvestigatorWorkstation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetButtonActive(CrimeReportsButton); 
        }
         
        private void CrimeReportsButton_Click(object sender, System.EventArgs e)
        {
            SetButtonActive(CrimeReportsButton);
            SetButtonInactive(CriminalCasesButton);
            SetButtonInactive(CalendarButton);
            TabContainer.SelectedIndex = 0;
        }

        private void CriminalCasesButton_Click(object sender, System.EventArgs e)
        {

            SetButtonActive(CriminalCasesButton);
            SetButtonInactive(CrimeReportsButton);
            SetButtonInactive(CalendarButton);
            TabContainer.SelectedIndex = 1;
        }

        private void CalendarButton_Click(object sender, System.EventArgs e)
        {
            SetButtonActive(CalendarButton);
            SetButtonInactive(CriminalCasesButton);
            SetButtonInactive(CrimeReportsButton);
            TabContainer.SelectedIndex = 2;
        }

        private void SetButtonActive(Button button)
        {
            button.BackColor = Color.FromArgb(230, 239, 255);
            button.Font = new Font("Segoe UI", 12.0F, FontStyle.Bold);
        }

        private void SetButtonInactive(Button button)
        {
            button.BackColor = Color.FromArgb(249, 249, 249);
            button.Font = new Font("Segoe UI", 13.0F, FontStyle.Regular);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
