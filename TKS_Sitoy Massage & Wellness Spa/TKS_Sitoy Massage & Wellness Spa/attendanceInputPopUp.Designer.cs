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
            attendanceNameInput.Location = new Point(25, 56);
            attendanceNameInput.Name = "attendanceNameInput";
            attendanceNameInput.Size = new Size(127, 23);
            attendanceNameInput.TabIndex = 0;
            // 
            // attendanceNameLabel
            // 
            attendanceNameLabel.AutoSize = true;
            attendanceNameLabel.Font = new Font("Segoe UI", 10F);
            attendanceNameLabel.ForeColor = Color.FromArgb(236, 239, 244);
            attendanceNameLabel.Location = new Point(25, 33);
            attendanceNameLabel.Margin = new Padding(0);
            attendanceNameLabel.Name = "attendanceNameLabel";
            attendanceNameLabel.Size = new Size(48, 19);
            attendanceNameLabel.TabIndex = 1;
            attendanceNameLabel.Text = "Name:";
            attendanceNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // attendanceCalendar
            // 
            attendanceCalendar.Location = new Point(179, 33);
            attendanceCalendar.Name = "attendanceCalendar";
            attendanceCalendar.TabIndex = 2;
            attendanceCalendar.DateChanged += attendanceCalendar_DateChanged;
            // 
            // attendanceCancelBtn
            // 
            attendanceCancelBtn.BackColor = Color.IndianRed;
            attendanceCancelBtn.FlatStyle = FlatStyle.Popup;
            attendanceCancelBtn.Location = new Point(79, 251);
            attendanceCancelBtn.Name = "attendanceCancelBtn";
            attendanceCancelBtn.Size = new Size(101, 38);
            attendanceCancelBtn.TabIndex = 3;
            attendanceCancelBtn.Text = "Cancel";
            attendanceCancelBtn.UseVisualStyleBackColor = false;
            attendanceCancelBtn.Click += cancelAttendance;
            // 
            // attendanceEnterBtn
            // 
            attendanceEnterBtn.BackColor = Color.FromArgb(145, 188, 143);
            attendanceEnterBtn.Cursor = Cursors.Hand;
            attendanceEnterBtn.FlatStyle = FlatStyle.Popup;
            attendanceEnterBtn.Location = new Point(244, 251);
            attendanceEnterBtn.Name = "attendanceEnterBtn";
            attendanceEnterBtn.Size = new Size(101, 38);
            attendanceEnterBtn.TabIndex = 4;
            attendanceEnterBtn.Text = "Enter";
            attendanceEnterBtn.UseVisualStyleBackColor = false;
            attendanceEnterBtn.Click += attendanceEnterBtn_Click;
            // 
            // AttendanceInputPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 79, 99);
            ClientSize = new Size(424, 321);
            Controls.Add(attendanceEnterBtn);
            Controls.Add(attendanceCancelBtn);
            Controls.Add(attendanceCalendar);
            Controls.Add(attendanceNameLabel);
            Controls.Add(attendanceNameInput);
            MaximizeBox = false;
            Name = "AttendanceInputPopUp";
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