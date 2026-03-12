namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class AttendanceEditPopup
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
            attendanceNameEditInput = new TextBox();
            attendanceNameEditLabel = new Label();
            attendanceEditYesBtn = new Button();
            attendanceEditNoBtn = new Button();
            SuspendLayout();
            // 
            // attendanceNameEditInput
            // 
            attendanceNameEditInput.Location = new Point(77, 91);
            attendanceNameEditInput.Name = "attendanceNameEditInput";
            attendanceNameEditInput.Size = new Size(172, 23);
            attendanceNameEditInput.TabIndex = 0;
            // 
            // attendanceNameEditLabel
            // 
            attendanceNameEditLabel.AutoSize = true;
            attendanceNameEditLabel.Font = new Font("Segoe UI", 10F);
            attendanceNameEditLabel.Location = new Point(77, 69);
            attendanceNameEditLabel.Name = "attendanceNameEditLabel";
            attendanceNameEditLabel.Size = new Size(45, 19);
            attendanceNameEditLabel.TabIndex = 1;
            attendanceNameEditLabel.Text = "Name";
            // 
            // attendanceEditYesBtn
            // 
            attendanceEditYesBtn.BackColor = Color.YellowGreen;
            attendanceEditYesBtn.Location = new Point(184, 155);
            attendanceEditYesBtn.Name = "attendanceEditYesBtn";
            attendanceEditYesBtn.Size = new Size(101, 38);
            attendanceEditYesBtn.TabIndex = 9;
            attendanceEditYesBtn.Text = "Yes";
            attendanceEditYesBtn.UseVisualStyleBackColor = false;
            // 
            // attendanceEditNoBtn
            // 
            attendanceEditNoBtn.BackColor = Color.IndianRed;
            attendanceEditNoBtn.Location = new Point(42, 155);
            attendanceEditNoBtn.Name = "attendanceEditNoBtn";
            attendanceEditNoBtn.Size = new Size(101, 38);
            attendanceEditNoBtn.TabIndex = 8;
            attendanceEditNoBtn.Text = "No";
            attendanceEditNoBtn.UseVisualStyleBackColor = false;
            // 
            // AttendanceEditPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 235);
            Controls.Add(attendanceEditYesBtn);
            Controls.Add(attendanceEditNoBtn);
            Controls.Add(attendanceNameEditLabel);
            Controls.Add(attendanceNameEditInput);
            Name = "AttendanceEditPopup";
            Text = "Attendance Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox attendanceNameEditInput;
        private Label attendanceNameEditLabel;
        private Button attendanceEditYesBtn;
        private Button attendanceEditNoBtn;
    }
}