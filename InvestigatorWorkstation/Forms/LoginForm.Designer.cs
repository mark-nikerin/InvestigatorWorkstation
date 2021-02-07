
namespace InvestigatorWorkstation.Forms
{
    partial class LoginForm
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
            this.WhitePanel = new System.Windows.Forms.Panel();
            this.LogInButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextGreyPanel = new System.Windows.Forms.Panel();
            this.LoginTextLabel = new System.Windows.Forms.Label();
            this.ProgramNameLabel = new System.Windows.Forms.Label();
            this.WhitePanel.SuspendLayout();
            this.LoginTextGreyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WhitePanel
            // 
            this.WhitePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WhitePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhitePanel.Controls.Add(this.LogInButton);
            this.WhitePanel.Controls.Add(this.PasswordLabel);
            this.WhitePanel.Controls.Add(this.LoginLabel);
            this.WhitePanel.Controls.Add(this.PasswordTextBox);
            this.WhitePanel.Controls.Add(this.LoginTextBox);
            this.WhitePanel.Location = new System.Drawing.Point(241, 113);
            this.WhitePanel.Name = "WhitePanel";
            this.WhitePanel.Size = new System.Drawing.Size(272, 257);
            this.WhitePanel.TabIndex = 0;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.ForeColor = System.Drawing.Color.Transparent;
            this.LogInButton.Location = new System.Drawing.Point(74, 204);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(126, 26);
            this.LogInButton.TabIndex = 7;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(37, 133);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(49, 15);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(37, 79);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(41, 15);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(39, 151);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "Введите пароль";
            this.PasswordTextBox.Size = new System.Drawing.Size(191, 23);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(39, 97);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "Введите логин";
            this.LoginTextBox.Size = new System.Drawing.Size(191, 23);
            this.LoginTextBox.TabIndex = 2;
            this.LoginTextBox.TabStop = false;
            // 
            // LoginTextGreyPanel
            // 
            this.LoginTextGreyPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginTextGreyPanel.Controls.Add(this.LoginTextLabel);
            this.LoginTextGreyPanel.Location = new System.Drawing.Point(242, 132);
            this.LoginTextGreyPanel.Name = "LoginTextGreyPanel";
            this.LoginTextGreyPanel.Size = new System.Drawing.Size(270, 37);
            this.LoginTextGreyPanel.TabIndex = 1;
            // 
            // LoginTextLabel
            // 
            this.LoginTextLabel.AutoSize = true;
            this.LoginTextLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginTextLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginTextLabel.Location = new System.Drawing.Point(88, 11);
            this.LoginTextLabel.Name = "LoginTextLabel";
            this.LoginTextLabel.Size = new System.Drawing.Size(92, 15);
            this.LoginTextLabel.TabIndex = 0;
            this.LoginTextLabel.Text = "Вход в систему";
            // 
            // ProgramNameLabel
            // 
            this.ProgramNameLabel.AutoSize = true;
            this.ProgramNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgramNameLabel.Location = new System.Drawing.Point(181, 56);
            this.ProgramNameLabel.Name = "ProgramNameLabel";
            this.ProgramNameLabel.Size = new System.Drawing.Size(393, 21);
            this.ProgramNameLabel.TabIndex = 1;
            this.ProgramNameLabel.Text = "Автоматизированное рабочее место следователя";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginTextGreyPanel);
            this.Controls.Add(this.ProgramNameLabel);
            this.Controls.Add(this.WhitePanel);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ Следователя - Вход";
            this.WhitePanel.ResumeLayout(false);
            this.WhitePanel.PerformLayout();
            this.LoginTextGreyPanel.ResumeLayout(false);
            this.LoginTextGreyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WhitePanel;
        private System.Windows.Forms.Panel LoginTextGreyPanel;
        private System.Windows.Forms.Label LoginTextLabel;
        private System.Windows.Forms.Label ProgramNameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
    }
}