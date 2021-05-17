
namespace InvestigatorWorkstation.Forms
{
    partial class PositionForm
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
            this.PositionLabel = new System.Windows.Forms.Label();
            this.PositionTextGreyPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PositionOkButton = new System.Windows.Forms.Button();
            this.PositionCancelButton = new System.Windows.Forms.Button();
            this.PositionTitleLabel = new System.Windows.Forms.Label();
            this.PositionTitleTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextGreyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PositionLabel
            // 
            this.PositionLabel.BackColor = System.Drawing.Color.Transparent;
            this.PositionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PositionLabel.Location = new System.Drawing.Point(0, 16);
            this.PositionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(389, 20);
            this.PositionLabel.TabIndex = 65;
            this.PositionLabel.Text = "Добавление должности";
            this.PositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositionTextGreyPanel
            // 
            this.PositionTextGreyPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PositionTextGreyPanel.Controls.Add(this.PositionLabel);
            this.PositionTextGreyPanel.Location = new System.Drawing.Point(0, 19);
            this.PositionTextGreyPanel.Margin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.PositionTextGreyPanel.Name = "PositionTextGreyPanel";
            this.PositionTextGreyPanel.Size = new System.Drawing.Size(389, 49);
            this.PositionTextGreyPanel.TabIndex = 133;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.PositionOkButton);
            this.panel1.Controls.Add(this.PositionCancelButton);
            this.panel1.Location = new System.Drawing.Point(20, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 58);
            this.panel1.TabIndex = 135;
            // 
            // PositionOkButton
            // 
            this.PositionOkButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.PositionOkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PositionOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionOkButton.ForeColor = System.Drawing.Color.Transparent;
            this.PositionOkButton.Location = new System.Drawing.Point(216, 22);
            this.PositionOkButton.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
            this.PositionOkButton.Name = "PositionOkButton";
            this.PositionOkButton.Size = new System.Drawing.Size(89, 26);
            this.PositionOkButton.TabIndex = 3;
            this.PositionOkButton.Text = "Добавить";
            this.PositionOkButton.UseVisualStyleBackColor = false;
            this.PositionOkButton.Click += new System.EventHandler(this.PositionOkButton_Click);
            // 
            // PositionCancelButton
            // 
            this.PositionCancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PositionCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PositionCancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.PositionCancelButton.FlatAppearance.BorderSize = 0;
            this.PositionCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionCancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PositionCancelButton.Location = new System.Drawing.Point(49, 22);
            this.PositionCancelButton.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
            this.PositionCancelButton.Name = "PositionCancelButton";
            this.PositionCancelButton.Size = new System.Drawing.Size(89, 26);
            this.PositionCancelButton.TabIndex = 4;
            this.PositionCancelButton.Text = "Отмена";
            this.PositionCancelButton.UseVisualStyleBackColor = false;
            this.PositionCancelButton.Click += new System.EventHandler(this.PositionCancelButton_Click);
            // 
            // PositionTitleLabel
            // 
            this.PositionTitleLabel.AutoSize = true;
            this.PositionTitleLabel.Location = new System.Drawing.Point(61, 99);
            this.PositionTitleLabel.Name = "PositionTitleLabel";
            this.PositionTitleLabel.Size = new System.Drawing.Size(69, 15);
            this.PositionTitleLabel.TabIndex = 134;
            this.PositionTitleLabel.Text = "Должность";
            // 
            // PositionTitleTextBox
            // 
            this.PositionTitleTextBox.Location = new System.Drawing.Point(61, 117);
            this.PositionTitleTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 28, 3);
            this.PositionTitleTextBox.Name = "PositionTitleTextBox";
            this.PositionTitleTextBox.PlaceholderText = "Введите название";
            this.PositionTitleTextBox.Size = new System.Drawing.Size(256, 23);
            this.PositionTitleTextBox.TabIndex = 132;
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(390, 238);
            this.Controls.Add(this.PositionTextGreyPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PositionTitleLabel);
            this.Controls.Add(this.PositionTitleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 277);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(406, 277);
            this.Name = "PositionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PositionTextGreyPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Panel PositionTextGreyPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PositionOkButton;
        private System.Windows.Forms.Button PositionCancelButton;
        private System.Windows.Forms.Label PositionTitleLabel;
        private System.Windows.Forms.TextBox PositionTitleTextBox;
    }
}