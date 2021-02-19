
namespace InvestigatorWorkstation.Forms.CrimeReport
{
    partial class AddCrimeReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddCrimeReportLabel = new System.Windows.Forms.Label();
            this.AddCrimeReportTextGreyPanel = new System.Windows.Forms.Panel();
            this.RegistryBookNumberLabel = new System.Windows.Forms.Label();
            this.RegistryBookNumberTextBox = new System.Windows.Forms.TextBox();
            this.RegistryNumberTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationDateLabel = new System.Windows.Forms.Label();
            this.RegistryNumberLabel = new System.Windows.Forms.Label();
            this.RegistrationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.IsRegistrationAuthorityRegistred = new System.Windows.Forms.Label();
            this.YesRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomRegistrationAuthorityTextBox = new System.Windows.Forms.TextBox();
            this.RegisteredAuthorityComboBox = new System.Windows.Forms.ComboBox();
            this.QualificationLabel = new System.Windows.Forms.Label();
            this.QualificationComboBox = new System.Windows.Forms.ComboBox();
            this.FableLabel = new System.Windows.Forms.Label();
            this.FableRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddCrimeReportButton = new System.Windows.Forms.Button();
            this.CancelAddCrimeReportButton = new System.Windows.Forms.Button();
            this.AddCrimeReportTextGreyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCrimeReportLabel
            // 
            this.AddCrimeReportLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddCrimeReportLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCrimeReportLabel.Location = new System.Drawing.Point(12, 16);
            this.AddCrimeReportLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AddCrimeReportLabel.Name = "AddCrimeReportLabel";
            this.AddCrimeReportLabel.Size = new System.Drawing.Size(654, 20);
            this.AddCrimeReportLabel.TabIndex = 65;
            this.AddCrimeReportLabel.Text = "Добавление нового сообщения";
            this.AddCrimeReportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCrimeReportTextGreyPanel
            // 
            this.AddCrimeReportTextGreyPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddCrimeReportTextGreyPanel.Controls.Add(this.AddCrimeReportLabel);
            this.AddCrimeReportTextGreyPanel.Location = new System.Drawing.Point(-2, 16);
            this.AddCrimeReportTextGreyPanel.Margin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.AddCrimeReportTextGreyPanel.Name = "AddCrimeReportTextGreyPanel";
            this.AddCrimeReportTextGreyPanel.Size = new System.Drawing.Size(676, 49);
            this.AddCrimeReportTextGreyPanel.TabIndex = 66;
            // 
            // RegistryBookNumberLabel
            // 
            this.RegistryBookNumberLabel.AutoSize = true;
            this.RegistryBookNumberLabel.Location = new System.Drawing.Point(268, 118);
            this.RegistryBookNumberLabel.Name = "RegistryBookNumberLabel";
            this.RegistryBookNumberLabel.Size = new System.Drawing.Size(181, 15);
            this.RegistryBookNumberLabel.TabIndex = 76;
            this.RegistryBookNumberLabel.Text = "Номер регистрационной книги";
            // 
            // RegistryBookNumberTextBox
            // 
            this.RegistryBookNumberTextBox.Location = new System.Drawing.Point(270, 136);
            this.RegistryBookNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.RegistryBookNumberTextBox.Name = "RegistryBookNumberTextBox";
            this.RegistryBookNumberTextBox.PlaceholderText = "Введите номер рег. книги";
            this.RegistryBookNumberTextBox.Size = new System.Drawing.Size(173, 23);
            this.RegistryBookNumberTextBox.TabIndex = 75;
            // 
            // RegistryNumberTextBox
            // 
            this.RegistryNumberTextBox.Location = new System.Drawing.Point(66, 136);
            this.RegistryNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.RegistryNumberTextBox.Name = "RegistryNumberTextBox";
            this.RegistryNumberTextBox.PlaceholderText = "Введите рег. номер";
            this.RegistryNumberTextBox.Size = new System.Drawing.Size(173, 23);
            this.RegistryNumberTextBox.TabIndex = 73;
            // 
            // RegistrationDateLabel
            // 
            this.RegistrationDateLabel.AutoSize = true;
            this.RegistrationDateLabel.Location = new System.Drawing.Point(472, 118);
            this.RegistrationDateLabel.Name = "RegistrationDateLabel";
            this.RegistrationDateLabel.Size = new System.Drawing.Size(105, 15);
            this.RegistrationDateLabel.TabIndex = 78;
            this.RegistrationDateLabel.Text = "Дата регистрации";
            // 
            // RegistryNumberLabel
            // 
            this.RegistryNumberLabel.AutoSize = true;
            this.RegistryNumberLabel.Location = new System.Drawing.Point(64, 118);
            this.RegistryNumberLabel.Name = "RegistryNumberLabel";
            this.RegistryNumberLabel.Size = new System.Drawing.Size(146, 15);
            this.RegistryNumberLabel.TabIndex = 74;
            this.RegistryNumberLabel.Text = "Регистрационный номер";
            // 
            // RegistrationDatePicker
            // 
            this.RegistrationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RegistrationDatePicker.Location = new System.Drawing.Point(474, 136);
            this.RegistrationDatePicker.Name = "RegistrationDatePicker";
            this.RegistrationDatePicker.Size = new System.Drawing.Size(127, 23);
            this.RegistrationDatePicker.TabIndex = 104;
            // 
            // IsRegistrationAuthorityRegistred
            // 
            this.IsRegistrationAuthorityRegistred.AutoSize = true;
            this.IsRegistrationAuthorityRegistred.Location = new System.Drawing.Point(66, 190);
            this.IsRegistrationAuthorityRegistred.Margin = new System.Windows.Forms.Padding(3, 28, 3, 0);
            this.IsRegistrationAuthorityRegistred.Name = "IsRegistrationAuthorityRegistred";
            this.IsRegistrationAuthorityRegistred.Size = new System.Drawing.Size(158, 15);
            this.IsRegistrationAuthorityRegistred.TabIndex = 105;
            this.IsRegistrationAuthorityRegistred.Text = "Зарегистрировано в УФСБ?";
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.Checked = true;
            this.YesRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesRadioButton.Location = new System.Drawing.Point(66, 221);
            this.YesRadioButton.Margin = new System.Windows.Forms.Padding(3, 3, 24, 3);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(45, 23);
            this.YesRadioButton.TabIndex = 106;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "Да";
            this.YesRadioButton.UseVisualStyleBackColor = true;
            this.YesRadioButton.CheckedChanged += new System.EventHandler(this.YesRadioButton_CheckedChanged);
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoRadioButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.NoRadioButton.Location = new System.Drawing.Point(66, 267);
            this.NoRadioButton.Margin = new System.Windows.Forms.Padding(3, 20, 24, 3);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(45, 19);
            this.NoRadioButton.TabIndex = 107;
            this.NoRadioButton.Text = "Нет";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            this.NoRadioButton.CheckedChanged += new System.EventHandler(this.NoRadioButton_CheckedChanged);
            // 
            // CustomRegistrationAuthorityTextBox
            // 
            this.CustomRegistrationAuthorityTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomRegistrationAuthorityTextBox.Enabled = false;
            this.CustomRegistrationAuthorityTextBox.Location = new System.Drawing.Point(138, 267);
            this.CustomRegistrationAuthorityTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.CustomRegistrationAuthorityTextBox.Name = "CustomRegistrationAuthorityTextBox";
            this.CustomRegistrationAuthorityTextBox.PlaceholderText = "Введите название органа регистрации";
            this.CustomRegistrationAuthorityTextBox.Size = new System.Drawing.Size(463, 23);
            this.CustomRegistrationAuthorityTextBox.TabIndex = 108;
            // 
            // RegisteredAuthorityComboBox
            // 
            this.RegisteredAuthorityComboBox.DisplayMember = "Name";
            this.RegisteredAuthorityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RegisteredAuthorityComboBox.FormattingEnabled = true;
            this.RegisteredAuthorityComboBox.Location = new System.Drawing.Point(138, 221);
            this.RegisteredAuthorityComboBox.Name = "RegisteredAuthorityComboBox";
            this.RegisteredAuthorityComboBox.Size = new System.Drawing.Size(463, 23);
            this.RegisteredAuthorityComboBox.TabIndex = 109;
            this.RegisteredAuthorityComboBox.ValueMember = "Id";
            // 
            // QualificationLabel
            // 
            this.QualificationLabel.AutoSize = true;
            this.QualificationLabel.Location = new System.Drawing.Point(64, 321);
            this.QualificationLabel.Margin = new System.Windows.Forms.Padding(3, 28, 3, 0);
            this.QualificationLabel.Name = "QualificationLabel";
            this.QualificationLabel.Size = new System.Drawing.Size(178, 15);
            this.QualificationLabel.TabIndex = 110;
            this.QualificationLabel.Text = "Квалификация по статье УК РФ";
            // 
            // QualificationComboBox
            // 
            this.QualificationComboBox.DisplayMember = "Name";
            this.QualificationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.QualificationComboBox.FormattingEnabled = true;
            this.QualificationComboBox.Location = new System.Drawing.Point(66, 339);
            this.QualificationComboBox.Name = "QualificationComboBox";
            this.QualificationComboBox.Size = new System.Drawing.Size(535, 23);
            this.QualificationComboBox.TabIndex = 111;
            this.QualificationComboBox.ValueMember = "Id";
            // 
            // FableLabel
            // 
            this.FableLabel.AutoSize = true;
            this.FableLabel.Location = new System.Drawing.Point(64, 393);
            this.FableLabel.Margin = new System.Windows.Forms.Padding(3, 28, 3, 0);
            this.FableLabel.Name = "FableLabel";
            this.FableLabel.Size = new System.Drawing.Size(94, 15);
            this.FableLabel.TabIndex = 112;
            this.FableLabel.Text = "Краткая фабула";
            // 
            // FableRichTextBox
            // 
            this.FableRichTextBox.BackColor = System.Drawing.Color.White;
            this.FableRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FableRichTextBox.DetectUrls = false;
            this.FableRichTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FableRichTextBox.Location = new System.Drawing.Point(66, 411);
            this.FableRichTextBox.Name = "FableRichTextBox";
            this.FableRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.FableRichTextBox.Size = new System.Drawing.Size(535, 105);
            this.FableRichTextBox.TabIndex = 113;
            this.FableRichTextBox.Text = "Добавьте описание";
            this.FableRichTextBox.Click += new System.EventHandler(this.FableRichTextBox_OnClick);
            // 
            // AddCrimeReportButton
            // 
            this.AddCrimeReportButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddCrimeReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCrimeReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCrimeReportButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddCrimeReportButton.Location = new System.Drawing.Point(365, 559);
            this.AddCrimeReportButton.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
            this.AddCrimeReportButton.Name = "AddCrimeReportButton";
            this.AddCrimeReportButton.Size = new System.Drawing.Size(89, 26);
            this.AddCrimeReportButton.TabIndex = 115;
            this.AddCrimeReportButton.Text = "Добавить";
            this.AddCrimeReportButton.UseVisualStyleBackColor = false;
            this.AddCrimeReportButton.Click += new System.EventHandler(this.AddCrimeReportButton_Click);
            // 
            // CancelAddCrimeReportButton
            // 
            this.CancelAddCrimeReportButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelAddCrimeReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelAddCrimeReportButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.CancelAddCrimeReportButton.FlatAppearance.BorderSize = 0;
            this.CancelAddCrimeReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddCrimeReportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelAddCrimeReportButton.Location = new System.Drawing.Point(207, 559);
            this.CancelAddCrimeReportButton.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
            this.CancelAddCrimeReportButton.Name = "CancelAddCrimeReportButton";
            this.CancelAddCrimeReportButton.Size = new System.Drawing.Size(89, 26);
            this.CancelAddCrimeReportButton.TabIndex = 114;
            this.CancelAddCrimeReportButton.Text = "Отмена";
            this.CancelAddCrimeReportButton.UseVisualStyleBackColor = false;
            this.CancelAddCrimeReportButton.Click += new System.EventHandler(this.CancelAddCrimeReportButton_Click);
            // 
            // AddCrimeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 621);
            this.Controls.Add(this.AddCrimeReportButton);
            this.Controls.Add(this.CancelAddCrimeReportButton);
            this.Controls.Add(this.FableRichTextBox);
            this.Controls.Add(this.FableLabel);
            this.Controls.Add(this.QualificationComboBox);
            this.Controls.Add(this.QualificationLabel);
            this.Controls.Add(this.RegisteredAuthorityComboBox);
            this.Controls.Add(this.CustomRegistrationAuthorityTextBox);
            this.Controls.Add(this.NoRadioButton);
            this.Controls.Add(this.YesRadioButton);
            this.Controls.Add(this.IsRegistrationAuthorityRegistred);
            this.Controls.Add(this.RegistrationDatePicker);
            this.Controls.Add(this.RegistrationDateLabel);
            this.Controls.Add(this.RegistryBookNumberLabel);
            this.Controls.Add(this.RegistryBookNumberTextBox);
            this.Controls.Add(this.RegistryNumberLabel);
            this.Controls.Add(this.RegistryNumberTextBox);
            this.Controls.Add(this.AddCrimeReportTextGreyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCrimeReportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AddCrimeReportTextGreyPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddCrimeReportLabel;
        private System.Windows.Forms.Panel AddCrimeReportTextGreyPanel;
        private System.Windows.Forms.Label RegistryBookNumberLabel;
        private System.Windows.Forms.TextBox RegistryBookNumberTextBox;
        private System.Windows.Forms.TextBox RegistryNumberTextBox;
        private System.Windows.Forms.Label RegistrationDateLabel;
        private System.Windows.Forms.Label RegistryNumberLabel;
        private System.Windows.Forms.DateTimePicker RegistrationDatePicker;
        private System.Windows.Forms.Label IsRegistrationAuthorityRegistred;
        private System.Windows.Forms.RadioButton YesRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.TextBox CustomRegistrationAuthorityTextBox;
        private System.Windows.Forms.ComboBox RegisteredAuthorityComboBox;
        private System.Windows.Forms.Label QualificationLabel;
        private System.Windows.Forms.ComboBox QualificationComboBox;
        private System.Windows.Forms.Label FableLabel;
        private System.Windows.Forms.RichTextBox FableRichTextBox;
        private System.Windows.Forms.Button AddCrimeReportButton;
        private System.Windows.Forms.Button CancelAddCrimeReportButton;
    }
}