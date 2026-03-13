namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class AppointmentsDeletePopup
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
            appointmentsDeleteNoBtn = new Button();
            appointmentsDeleteYesBtn = new Button();
            appointmentsDeleteLabel = new Label();
            SuspendLayout();
            // 
            // appointmentsDeleteNoBtn
            // 
            appointmentsDeleteNoBtn.BackColor = Color.FromArgb(191, 97, 106);
            appointmentsDeleteNoBtn.FlatStyle = FlatStyle.Popup;
            appointmentsDeleteNoBtn.Location = new Point(36, 83);
            appointmentsDeleteNoBtn.Name = "appointmentsDeleteNoBtn";
            appointmentsDeleteNoBtn.Size = new Size(101, 38);
            appointmentsDeleteNoBtn.TabIndex = 0;
            appointmentsDeleteNoBtn.Text = "No";
            appointmentsDeleteNoBtn.UseVisualStyleBackColor = false;
            // 
            // appointmentsDeleteYesBtn
            // 
            appointmentsDeleteYesBtn.BackColor = Color.FromArgb(145, 188, 143);
            appointmentsDeleteYesBtn.FlatStyle = FlatStyle.Popup;
            appointmentsDeleteYesBtn.Location = new Point(178, 83);
            appointmentsDeleteYesBtn.Name = "appointmentsDeleteYesBtn";
            appointmentsDeleteYesBtn.Size = new Size(101, 38);
            appointmentsDeleteYesBtn.TabIndex = 1;
            appointmentsDeleteYesBtn.Text = "Yes";
            appointmentsDeleteYesBtn.UseVisualStyleBackColor = false;
            // 
            // appointmentsDeleteLabel
            // 
            appointmentsDeleteLabel.AutoSize = true;
            appointmentsDeleteLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentsDeleteLabel.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsDeleteLabel.Location = new Point(84, 41);
            appointmentsDeleteLabel.Name = "appointmentsDeleteLabel";
            appointmentsDeleteLabel.Size = new Size(142, 21);
            appointmentsDeleteLabel.TabIndex = 2;
            appointmentsDeleteLabel.Text = "Confirm Deletion?";
            // 
            // AppointmentsDeletePopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 79, 99);
            ClientSize = new Size(310, 182);
            Controls.Add(appointmentsDeleteLabel);
            Controls.Add(appointmentsDeleteYesBtn);
            Controls.Add(appointmentsDeleteNoBtn);
            Name = "AppointmentsDeletePopup";
            Text = "Delete Confirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button appointmentsDeleteNoBtn;
        private Button appointmentsDeleteYesBtn;
        private Label appointmentsDeleteLabel;
    }
}