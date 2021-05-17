
namespace InvestigatorWorkstation.Forms
{
    partial class RankForm
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
            this.RankTextGreyPanel = new System.Windows.Forms.Panel();
            this.RankLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RankOkButton = new System.Windows.Forms.Button();
            this.RankCancelButton = new System.Windows.Forms.Button();
            this.RankTermLabel = new System.Windows.Forms.Label();
            this.RankTitleLabel = new System.Windows.Forms.Label();
            this.RankTitleTextBox = new System.Windows.Forms.TextBox();
            this.RankTermNumeric = new System.Windows.Forms.NumericUpDown();
            this.RankTextGreyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RankTermNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // RankTextGreyPanel
            // 
            this.RankTextGreyPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RankTextGreyPanel.Controls.Add(this.RankLabel);
            this.RankTextGreyPanel.Location = new System.Drawing.Point(0, 19);
            this.RankTextGreyPanel.Margin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.RankTextGreyPanel.Name = "RankTextGreyPanel";
            this.RankTextGreyPanel.Size = new System.Drawing.Size(505, 49);
            this.RankTextGreyPanel.TabIndex = 128;
            // 
            // RankLabel
            // 
            this.RankLabel.BackColor = System.Drawing.Color.Transparent;
            this.RankLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RankLabel.Location = new System.Drawing.Point(0, 16);
            this.RankLabel.Margin = new System.Windows.Forms.Padding(0);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(505, 20);
            this.RankLabel.TabIndex = 65;
            this.RankLabel.Text = "Добавление звания";
            this.RankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.RankOkButton);
            this.panel1.Controls.Add(this.RankCancelButton);
            this.panel1.Location = new System.Drawing.Point(12, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 58);
            this.panel1.TabIndex = 131;
            // 
            // RankOkButton
            // 
            this.RankOkButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.RankOkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RankOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RankOkButton.ForeColor = System.Drawing.Color.Transparent;
            this.RankOkButton.Location = new System.Drawing.Point(288, 20);
            this.RankOkButton.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
            this.RankOkButton.Name = "RankOkButton";
            this.RankOkButton.Size = new System.Drawing.Size(89, 26);
            this.RankOkButton.TabIndex = 3;
            this.RankOkButton.Text = "Добавить";
            this.RankOkButton.UseVisualStyleBackColor = false;
            this.RankOkButton.Click += new System.EventHandler(this.RankOkButton_Click);
            // 
            // RankCancelButton
            // 
            this.RankCancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RankCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RankCancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.RankCancelButton.FlatAppearance.BorderSize = 0;
            this.RankCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RankCancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RankCancelButton.Location = new System.Drawing.Point(105, 20);
            this.RankCancelButton.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
            this.RankCancelButton.Name = "RankCancelButton";
            this.RankCancelButton.Size = new System.Drawing.Size(89, 26);
            this.RankCancelButton.TabIndex = 4;
            this.RankCancelButton.Text = "Отмена";
            this.RankCancelButton.UseVisualStyleBackColor = false;
            this.RankCancelButton.Click += new System.EventHandler(this.RankCancelButton_Click);
            // 
            // RankTermLabel
            // 
            this.RankTermLabel.AutoSize = true;
            this.RankTermLabel.Location = new System.Drawing.Point(348, 99);
            this.RankTermLabel.Name = "RankTermLabel";
            this.RankTermLabel.Size = new System.Drawing.Size(75, 15);
            this.RankTermLabel.TabIndex = 130;
            this.RankTermLabel.Text = "Срок звания";
            // 
            // RankTitleLabel
            // 
            this.RankTitleLabel.AutoSize = true;
            this.RankTitleLabel.Location = new System.Drawing.Point(61, 99);
            this.RankTitleLabel.Name = "RankTitleLabel";
            this.RankTitleLabel.Size = new System.Drawing.Size(46, 15);
            this.RankTitleLabel.TabIndex = 129;
            this.RankTitleLabel.Text = "Звание";
            // 
            // RankTitleTextBox
            // 
            this.RankTitleTextBox.Location = new System.Drawing.Point(61, 117);
            this.RankTitleTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.RankTitleTextBox.Name = "RankTitleTextBox";
            this.RankTitleTextBox.PlaceholderText = "Введите название";
            this.RankTitleTextBox.Size = new System.Drawing.Size(256, 23);
            this.RankTitleTextBox.TabIndex = 1;
            // 
            // RankTermNumeric
            // 
            this.RankTermNumeric.Location = new System.Drawing.Point(348, 117);
            this.RankTermNumeric.Name = "RankTermNumeric";
            this.RankTermNumeric.Size = new System.Drawing.Size(75, 23);
            this.RankTermNumeric.TabIndex = 2;
            // 
            // RankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(504, 238);
            this.Controls.Add(this.RankTermNumeric);
            this.Controls.Add(this.RankTextGreyPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RankTermLabel);
            this.Controls.Add(this.RankTitleLabel);
            this.Controls.Add(this.RankTitleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RankForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.RankTextGreyPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RankTermNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RankTextGreyPanel;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RankOkButton;
        private System.Windows.Forms.Button RankCancelButton;
        private System.Windows.Forms.Label RankTermLabel;
        private System.Windows.Forms.Label RankTitleLabel;
        private System.Windows.Forms.TextBox RankTitleTextBox;
        private System.Windows.Forms.NumericUpDown RankTermNumeric;
    }
}