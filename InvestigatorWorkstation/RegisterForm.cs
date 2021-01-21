using Services.Interfaces;
using System;
using System.Windows.Forms;

namespace InvestigatorWorkstation
{
    public partial class RegisterForm : Form
    { 
        public RegisterForm(IAuthService authService)
        {
            InitializeComponent();
        } 

        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
           Hide();
        }
    }
}
