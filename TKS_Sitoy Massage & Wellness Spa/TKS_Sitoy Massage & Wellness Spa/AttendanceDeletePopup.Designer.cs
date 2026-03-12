namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class AttendanceDeletePopup
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
            attendanceDeleteNoBtn = new Button();
            attendanceDeleteYesBtn = new Button();
            attendanceDeleteLabel = new Label();
            SuspendLayout();
            // 
            // attendanceDeleteNoBtn
            // 
            attendanceDeleteNoBtn.BackColor = Color.IndianRed;
            attendanceDeleteNoBtn.Location = new Point(36, 83);
            attendanceDeleteNoBtn.Name = "attendanceDeleteNoBtn";
            attendanceDeleteNoBtn.Size = new Size(101, 38);
            attendanceDeleteNoBtn.TabIndex = 0;
            attendanceDeleteNoBtn.Text = "No";
            attendanceDeleteNoBtn.UseVisualStyleBackColor = false;
            // 
            // attendanceDeleteYesBtn
            // 
            attendanceDeleteYesBtn.BackColor = Color.YellowGreen;
            attendanceDeleteYesBtn.Location = new Point(178, 83);
            attendanceDeleteYesBtn.Name = "attendanceDeleteYesBtn";
            attendanceDeleteYesBtn.Size = new Size(101, 38);
            attendanceDeleteYesBtn.TabIndex = 1;
            attendanceDeleteYesBtn.Text = "Yes";
            attendanceDeleteYesBtn.UseVisualStyleBackColor = false;
            // 
            // attendanceDeleteLabel
            // 
            attendanceDeleteLabel.AutoSize = true;
            attendanceDeleteLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendanceDeleteLabel.Location = new Point(84, 41);
            attendanceDeleteLabel.Name = "attendanceDeleteLabel";
            attendanceDeleteLabel.Size = new Size(142, 21);
            attendanceDeleteLabel.TabIndex = 2;
            attendanceDeleteLabel.Text = "Confirm Deletion?";
            // 
            // attendanceDeletePopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 182);
            Controls.Add(attendanceDeleteLabel);
            Controls.Add(attendanceDeleteYesBtn);
            Controls.Add(attendanceDeleteNoBtn);
            Name = "attendanceDeletePopup";
            Text = "Delete Confirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button attendanceDeleteNoBtn;
        private Button attendanceDeleteYesBtn;
        private Label attendanceDeleteLabel;
    }
}