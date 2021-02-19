
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.RankAppointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RankComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.CancelAddEmployeeButton = new System.Windows.Forms.Button();
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
            this.AddCrimeReportTextGreyPanel.Location = new System.Drawing.Point(-3, 44);
            this.AddCrimeReportTextGreyPanel.Margin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.AddCrimeReportTextGreyPanel.Name = "AddCrimeReportTextGreyPanel";
            this.AddCrimeReportTextGreyPanel.Size = new System.Drawing.Size(676, 49);
            this.AddCrimeReportTextGreyPanel.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 76;
            this.label1.Text = "Номер регистрационной книги";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(269, 164);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.PlaceholderText = "Введите номер рег. книги";
            this.FirstNameTextBox.Size = new System.Drawing.Size(173, 23);
            this.FirstNameTextBox.TabIndex = 75;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(65, 164);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.PlaceholderText = "Введите рег. номер";
            this.LastNameTextBox.Size = new System.Drawing.Size(173, 23);
            this.LastNameTextBox.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "Дата регистрации";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(63, 146);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(146, 15);
            this.login.TabIndex = 74;
            this.login.Text = "Регистрационный номер";
            // 
            // RankAppointmentDateTimePicker
            // 
            this.RankAppointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RankAppointmentDateTimePicker.Location = new System.Drawing.Point(473, 164);
            this.RankAppointmentDateTimePicker.Name = "RankAppointmentDateTimePicker";
            this.RankAppointmentDateTimePicker.Size = new System.Drawing.Size(127, 23);
            this.RankAppointmentDateTimePicker.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 28, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 15);
            this.label3.TabIndex = 105;
            this.label3.Text = "Зарегистрировано в УФСБ?";
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(65, 249);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 3, 24, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 23);
            this.radioButton1.TabIndex = 106;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Да";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.radioButton2.Location = new System.Drawing.Point(65, 295);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 20, 24, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 19);
            this.radioButton2.TabIndex = 107;
            this.radioButton2.Text = "Нет";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(137, 295);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Введите название органа регистрации";
            this.textBox1.Size = new System.Drawing.Size(463, 23);
            this.textBox1.TabIndex = 108;
            // 
            // RankComboBox
            // 
            this.RankComboBox.DisplayMember = "Name";
            this.RankComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RankComboBox.FormattingEnabled = true;
            this.RankComboBox.Location = new System.Drawing.Point(137, 249);
            this.RankComboBox.Name = "RankComboBox";
            this.RankComboBox.Size = new System.Drawing.Size(463, 23);
            this.RankComboBox.TabIndex = 109;
            this.RankComboBox.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 28, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 15);
            this.label4.TabIndex = 110;
            this.label4.Text = "Квалификация по статье УК РФ";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 367);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(535, 23);
            this.comboBox1.TabIndex = 111;
            this.comboBox1.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 421);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 28, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 112;
            this.label5.Text = "Краткая фабула";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.richTextBox1.Location = new System.Drawing.Point(65, 439);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(535, 105);
            this.richTextBox1.TabIndex = 113;
            this.richTextBox1.Text = "Добавьте описание";
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddEmployeeButton.Location = new System.Drawing.Point(364, 587);
            this.AddEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(89, 26);
            this.AddEmployeeButton.TabIndex = 115;
            this.AddEmployeeButton.Text = "Добавить";
            this.AddEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // CancelAddEmployeeButton
            // 
            this.CancelAddEmployeeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelAddEmployeeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.CancelAddEmployeeButton.FlatAppearance.BorderSize = 0;
            this.CancelAddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddEmployeeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelAddEmployeeButton.Location = new System.Drawing.Point(206, 587);
            this.CancelAddEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
            this.CancelAddEmployeeButton.Name = "CancelAddEmployeeButton";
            this.CancelAddEmployeeButton.Size = new System.Drawing.Size(89, 26);
            this.CancelAddEmployeeButton.TabIndex = 114;
            this.CancelAddEmployeeButton.Text = "Отмена";
            this.CancelAddEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // AddCrimeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 641);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.CancelAddEmployeeButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RankComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RankAppointmentDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.login);
            this.Controls.Add(this.LastNameTextBox);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.DateTimePicker RankAppointmentDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox RankComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button CancelAddEmployeeButton;
    }
}