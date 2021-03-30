using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Services.DTOs.CrimeReport;

namespace InvestigatorWorkstation.Forms.CrimeReport
{
    public partial class AddCrimeReportForm : Form
    {
        private CrimeReportDTO _crimeReport;

        private const string QualificationStringPattern = "Статья {0} Часть {1} Пункт {2};";

        public AddCrimeReportForm()
        {
            InitializeComponent();
            foreach(var control in Controls)
            {
                if (control is TextBox || control is DateTimePicker || control is ComboBox)
                {
                    var textbox = control as Control;
                    textbox.KeyUp += ControlPressEnter;
                    textbox.KeyDown += AvoidBeepOnPressEnter;
                }
            }
        }

        public CrimeReportDTO GetResult()
        {
            return _crimeReport;
        }

        private void AddCrimeReportButton_Click(object sender, EventArgs e)
        {
            var qualificationStringBuilder = new StringBuilder();
            var qualificationNumber = 0;

            foreach (var control in flowLayoutPanel1.Controls)
            {
                if (control is Panel panel)
                {
                    qualificationNumber++;
                    var article = (panel.Controls[$"ArticleTextBox{qualificationNumber}"] as TextBox)?.Text;
                    var part = (panel.Controls[$"ArticleTextBox{qualificationNumber}"] as TextBox)?.Text;
                    var point = (panel.Controls[$"ArticleTextBox{qualificationNumber}"] as TextBox)?.Text;

                    if (article == null && part == null && point == null)
                        continue;

                    qualificationStringBuilder.AppendFormat(QualificationStringPattern, article, part, point).AppendLine(); 
                }
            }

            _crimeReport = new CrimeReportDTO
            {
                RegistrationNumber = RegistryNumberTextBox.Text,
                RegistrationBookNumber = RegistryBookNumberTextBox.Text,
                RegistrationDate = RegistrationDatePicker.Value,
                Fable = FableRichTextBox.Text, 
                Qualification = qualificationStringBuilder.ToString()
                // TODO добавить квалификации и органы УФСБ
            };
            DialogResult = DialogResult.OK;
        }

        private void CancelAddCrimeReportButton_Click(object sender, EventArgs e)
        {
            _crimeReport = null;
            DialogResult = DialogResult.Cancel;
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

        private void AddQualificationPictureBox_Click(object sender, EventArgs e)
        {
            var qualificationNumber = flowLayoutPanel1.Controls.Count;
            var newQualificationPanel = new Panel()
            {
                Width = QualificatonPanel1.Width,
                Height = QualificatonPanel1.Height,
                Name = $"QualificationPanel{qualificationNumber}"
            };

            var articleLabel = new Label()
            {
                Text = ArticleLabel1.Text,
                Name = $"ArticleLabel{qualificationNumber}",
                Width = ArticleLabel1.Width,
                Height = ArticleLabel1.Height,
                Margin = ArticleLabel1.Margin,
                Padding = ArticleLabel1.Padding,
                Location = ArticleLabel1.Location
            };
            var partLabel = new Label()
            {
                Text = PartLabel1.Text,
                Name = $"PartLabel1{qualificationNumber}",
                Width = PartLabel1.Width,
                Height = PartLabel1.Height,
                Margin = PartLabel1.Margin,
                Padding = PartLabel1.Padding,
                Location = PartLabel1.Location
            };
            var pointLabel = new Label()
            {
                Text = PointLabel1.Text,
                Name = $"PointLabel1{qualificationNumber}",
                Width = PointLabel1.Width,
                Height = PointLabel1.Height,
                Margin = PointLabel1.Margin,
                Padding = PointLabel1.Padding,
                Location = PointLabel1.Location
            };
            var articleTextBox = new TextBox()
            {
                Name = $"ArticleTextBox{qualificationNumber}",
                Width = ArticleTextBox1.Width,
                Height = ArticleTextBox1.Height,
                Margin = ArticleTextBox1.Margin,
                Padding = ArticleTextBox1.Padding,
                Location = ArticleTextBox1.Location
            };
            var partTextBox = new TextBox()
            {
                Name = $"PartTextBox{qualificationNumber}",
                Width = PartTextBox1.Width,
                Height = PartTextBox1.Height,
                Margin = PartTextBox1.Margin,
                Padding = PartTextBox1.Padding,
                Location = PartTextBox1.Location
            };
            var pointTextBox = new TextBox()
            {
                Name = $"PointTextBox{qualificationNumber}",
                Width = PointTextBox1.Width,
                Height = PointTextBox1.Height,
                Margin = PointTextBox1.Margin,
                Padding = PointTextBox1.Padding,
                Location = PointTextBox1.Location
            };
            var ukrfLabel = new Label()
            {
                Name = $"ukrfLabel{qualificationNumber}",
                Width = ukrfLabel1.Width,
                Height = ukrfLabel1.Height,
                Margin = ukrfLabel1.Margin,
                Padding = ukrfLabel1.Padding,
                Location = ukrfLabel1.Location,
                Text = ukrfLabel1.Text
            };

            newQualificationPanel.Controls.AddRange(new Control[]
            {
                articleLabel,
                articleTextBox,
                partLabel,
                partTextBox,
                pointLabel,
                pointTextBox,
                ukrfLabel
            });

            flowLayoutPanel1.Controls.Add(newQualificationPanel);

            flowLayoutPanel1.Controls.SetChildIndex(newQualificationPanel, flowLayoutPanel1.Controls.Count - 2);

            flowLayoutPanel1.Invalidate();
        }

        private void DeleteQualificationPictureBox_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.RemoveByKey($"QualificationPanel{flowLayoutPanel1.Controls.Count - 1}");
            flowLayoutPanel1.Invalidate();
        }

        private void PictureButtonOnHoverIn(object sender, EventArgs e) => (sender as PictureBox).BackColor = Color.WhiteSmoke;

        private void PictureButtonOnHoverOut(object sender, EventArgs e) => (sender as PictureBox).BackColor = Color.Transparent;

        private void ControlPressEnter(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void AvoidBeepOnPressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
