using System.Windows.Forms;

namespace InvestigatorWorkstation
{
    public partial class MainForm : Form
    {
        public MainForm(string username)
        {
            InitializeComponent(); 
            this.label1.Text = $"Здравствуйте, {username}!";
        }
    }
}
