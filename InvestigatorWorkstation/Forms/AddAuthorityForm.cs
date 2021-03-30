using System;
using System.Windows.Forms;
using Services.DTOs;

namespace InvestigatorWorkstation.Forms
{
    public partial class AddAuthorityForm : Form
    {
        private AuthorityDTO _authority;

        public AddAuthorityForm()
        {
            InitializeComponent();
        }

        public AuthorityDTO GetResult()
        {
            return _authority;
        }

        private void AddAuthorityButton_Click(object sender, EventArgs e)
        {
            _authority = new AuthorityDTO
            {
                Title = AuthorityTitleTextBox.Text,
                Address = AuthorityAddressTextBox.Text,
                PhoneNumber = AuthorityPhoneNumberTextBox.Text,
                Subdivision = AuthoritySubdivisionTextBox.Text
            };

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _authority = null;
            DialogResult = DialogResult.Cancel;
        }
    }
}
