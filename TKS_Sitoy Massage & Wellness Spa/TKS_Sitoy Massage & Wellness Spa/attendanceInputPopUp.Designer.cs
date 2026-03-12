namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class AttendanceInputPopUp
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
            attendanceNameInput = new TextBox();
            attendanceNameLabel = new Label();
            attendanceCalendar = new MonthCalendar();
            attendanceCancelBtn = new Button();
            attendanceEnterBtn = new Button();
            SuspendLayout();
            // 
            // attendanceNameInput
            // 
            attendanceNameInput.Location = new Point(36, 93);
            attendanceNameInput.Margin = new Padding(4, 5, 4, 5);
            attendanceNameInput.Name = "attendanceNameInput";
            attendanceNameInput.Size = new Size(180, 31);
            attendanceNameInput.TabIndex = 0;
            // 
            // attendanceNameLabel
            // 
            attendanceNameLabel.AutoSize = true;
            attendanceNameLabel.Font = new Font("Segoe UI", 10F);
            attendanceNameLabel.Location = new Point(36, 55);
            attendanceNameLabel.Margin = new Padding(0);
            attendanceNameLabel.Name = "attendanceNameLabel";
            attendanceNameLabel.Size = new Size(68, 28);
            attendanceNameLabel.TabIndex = 1;
            attendanceNameLabel.Text = "Name:";
            attendanceNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // attendanceCalendar
            // 
            attendanceCalendar.Location = new Point(256, 55);
            attendanceCalendar.Margin = new Padding(13, 15, 13, 15);
            attendanceCalendar.Name = "attendanceCalendar";
            attendanceCalendar.TabIndex = 2;
            attendanceCalendar.DateChanged += attendanceCalendar_DateChanged;
            // 
            // attendanceCancelBtn
            // 
            attendanceCancelBtn.BackColor = Color.IndianRed;
            attendanceCancelBtn.Location = new Point(113, 418);
            attendanceCancelBtn.Margin = new Padding(4, 5, 4, 5);
            attendanceCancelBtn.Name = "attendanceCancelBtn";
            attendanceCancelBtn.Size = new Size(144, 63);
            attendanceCancelBtn.TabIndex = 3;
            attendanceCancelBtn.Text = "Cancel";
            attendanceCancelBtn.UseVisualStyleBackColor = false;
            attendanceCancelBtn.Click += cancelAttendance;
            // 
            // attendanceEnterBtn
            // 
            attendanceEnterBtn.BackColor = Color.YellowGreen;
            attendanceEnterBtn.Cursor = Cursors.Hand;
            attendanceEnterBtn.Location = new Point(349, 418);
            attendanceEnterBtn.Margin = new Padding(4, 5, 4, 5);
            attendanceEnterBtn.Name = "attendanceEnterBtn";
            attendanceEnterBtn.Size = new Size(144, 63);
            attendanceEnterBtn.TabIndex = 4;
            attendanceEnterBtn.Text = "Enter";
            attendanceEnterBtn.UseVisualStyleBackColor = false;
            attendanceEnterBtn.Click += attendanceEnterBtn_Click;
            // 
            // attendanceInputPopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 535);
            Controls.Add(attendanceEnterBtn);
            Controls.Add(attendanceCancelBtn);
            Controls.Add(attendanceCalendar);
            Controls.Add(attendanceNameLabel);
            Controls.Add(attendanceNameInput);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "attendanceInputPopUp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Attendance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox attendanceNameInput;
        private Label attendanceNameLabel;
        private MonthCalendar attendanceCalendar;
        private Button attendanceCancelBtn;
        private Button attendanceEnterBtn;
    }
}