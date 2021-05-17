﻿using System.Windows.Forms;
using Services.DTOs.Employee;

namespace InvestigatorWorkstation.Forms
{
    public partial class RankForm : Form
    {
        private RankDTO _rank;

        public RankForm(RankDTO rank = null)
        {
            InitializeComponent();
            _rank = rank; 

            if (rank != null)
            {
                RankLabel.Text = "Изменение звания";
                RankOkButton.Text = "Изменить";

                RankTermNumeric.Value = rank.Term;
                RankTitleTextBox.Text = rank.Name;
            }
        }

        public RankDTO GetResult()
        {
            return _rank;
        }

        private void RankOkButton_Click(object sender, System.EventArgs e)
        {
            if (_rank == null)
            {
                _rank = new RankDTO
                {
                    Name = RankTitleTextBox.Text,
                    Term = (int)RankTermNumeric.Value
                };
            }
            else
            {
                _rank.Name = RankTitleTextBox.Text;
                _rank.Term = (int)RankTermNumeric.Value;
            }

            DialogResult = DialogResult.OK;
        }

        private void RankCancelButton_Click(object sender, System.EventArgs e)
        {
            _rank = null;
            DialogResult = DialogResult.Cancel;
        }
    }
}