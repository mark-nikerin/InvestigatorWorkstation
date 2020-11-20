
namespace InvestigatorWorkstation
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
            this.panel_white = new System.Windows.Forms.Panel();
            this.LogInButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.panel_grey = new System.Windows.Forms.Panel();
            this.title2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel_white.SuspendLayout();
            this.panel_grey.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_white
            // 
            this.panel_white.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_white.Controls.Add(this.LogInButton);
            this.panel_white.Controls.Add(this.registrationButton);
            this.panel_white.Controls.Add(this.password);
            this.panel_white.Controls.Add(this.login);
            this.panel_white.Controls.Add(this.textBox_password);
            this.panel_white.Controls.Add(this.textBox_login);
            this.panel_white.Controls.Add(this.panel_grey);
            this.panel_white.Location = new System.Drawing.Point(241, 113);
            this.panel_white.Name = "panel_white";
            this.panel_white.Size = new System.Drawing.Size(272, 291);
            this.panel_white.TabIndex = 0;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.ForeColor = System.Drawing.Color.Transparent;
            this.LogInButton.Location = new System.Drawing.Point(159, 183);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(71, 26);
            this.LogInButton.TabIndex = 7;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationButton.Location = new System.Drawing.Point(73, 249);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(126, 26);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(37, 133);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(49, 15);
            this.password.TabIndex = 5;
            this.password.Text = "Пароль";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(37, 79);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(41, 15);
            this.login.TabIndex = 4;
            this.login.Text = "Логин";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(39, 151);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(191, 23);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(39, 97);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(191, 23);
            this.textBox_login.TabIndex = 2;
            // 
            // panel_grey
            // 
            this.panel_grey.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_grey.Controls.Add(this.title2);
            this.panel_grey.Location = new System.Drawing.Point(0, 20);
            this.panel_grey.Name = "panel_grey";
            this.panel_grey.Size = new System.Drawing.Size(272, 37);
            this.panel_grey.TabIndex = 1;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.title2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title2.Location = new System.Drawing.Point(88, 11);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(92, 15);
            this.title2.TabIndex = 0;
            this.title2.Text = "Вход в систему";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(181, 56);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(393, 21);
            this.title.TabIndex = 1;
            this.title.Text = "Автоматизированное рабочее место следователя";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel_white);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel_white.ResumeLayout(false);
            this.panel_white.PerformLayout();
            this.panel_grey.ResumeLayout(false);
            this.panel_grey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_white;
        private System.Windows.Forms.Panel panel_grey;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
    }
}