namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class MiscellaneousDeletePopup
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
            miscellaneousDeleteNoBtn = new Button();
            miscellaneousDeleteYesBtn = new Button();
            miscellaneousDeleteLabel = new Label();
            SuspendLayout();
            // 
            // miscellaneousDeleteNoBtn
            // 
            miscellaneousDeleteNoBtn.BackColor = Color.FromArgb(191, 97, 106);
            miscellaneousDeleteNoBtn.FlatStyle = FlatStyle.Popup;
            miscellaneousDeleteNoBtn.Location = new Point(36, 83);
            miscellaneousDeleteNoBtn.Name = "miscellaneousDeleteNoBtn";
            miscellaneousDeleteNoBtn.Size = new Size(101, 38);
            miscellaneousDeleteNoBtn.TabIndex = 0;
            miscellaneousDeleteNoBtn.Text = "No";
            miscellaneousDeleteNoBtn.UseVisualStyleBackColor = false;
            // 
            // miscellaneousDeleteYesBtn
            // 
            miscellaneousDeleteYesBtn.BackColor = Color.FromArgb(145, 188, 143);
            miscellaneousDeleteYesBtn.FlatStyle = FlatStyle.Popup;
            miscellaneousDeleteYesBtn.Location = new Point(178, 83);
            miscellaneousDeleteYesBtn.Name = "miscellaneousDeleteYesBtn";
            miscellaneousDeleteYesBtn.Size = new Size(101, 38);
            miscellaneousDeleteYesBtn.TabIndex = 1;
            miscellaneousDeleteYesBtn.Text = "Yes";
            miscellaneousDeleteYesBtn.UseVisualStyleBackColor = false;
            // 
            // miscellaneousDeleteLabel
            // 
            miscellaneousDeleteLabel.AutoSize = true;
            miscellaneousDeleteLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            miscellaneousDeleteLabel.ForeColor = Color.FromArgb(236, 239, 244);
            miscellaneousDeleteLabel.Location = new Point(84, 41);
            miscellaneousDeleteLabel.Name = "miscellaneousDeleteLabel";
            miscellaneousDeleteLabel.Size = new Size(142, 21);
            miscellaneousDeleteLabel.TabIndex = 2;
            miscellaneousDeleteLabel.Text = "Confirm Deletion?";
            // 
            // MiscellaneousDeletePopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 79, 99);
            ClientSize = new Size(310, 182);
            Controls.Add(miscellaneousDeleteLabel);
            Controls.Add(miscellaneousDeleteYesBtn);
            Controls.Add(miscellaneousDeleteNoBtn);
            Name = "MiscellaneousDeletePopup";
            Text = "Delete Confirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button miscellaneousDeleteNoBtn;
        private Button miscellaneousDeleteYesBtn;
        private Label miscellaneousDeleteLabel;
    }
}