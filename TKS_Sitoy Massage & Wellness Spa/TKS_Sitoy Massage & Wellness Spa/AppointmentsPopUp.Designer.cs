namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class appointmentsInputPopUp
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
            appointmentsNameInput = new TextBox();
            appointmentsNameLabel = new Label();
            appointmentsCalendar = new MonthCalendar();
            appointmentsCancelBtn = new Button();
            appointmentsEnterBtn = new Button();
            appointmentsServiceTypeLabel = new Label();
            appointmentsServiceTypeInput = new TextBox();
            appointmentsCommissionLabel = new Label();
            appointmentsCommissionInput = new TextBox();
            SuspendLayout();
            // 
            // appointmentsNameInput
            // 
            appointmentsNameInput.Location = new Point(36, 92);
            appointmentsNameInput.Margin = new Padding(4, 5, 4, 5);
            appointmentsNameInput.Name = "appointmentsNameInput";
            appointmentsNameInput.Size = new Size(180, 31);
            appointmentsNameInput.TabIndex = 0;
            // 
            // appointmentsNameLabel
            // 
            appointmentsNameLabel.AutoSize = true;
            appointmentsNameLabel.Font = new Font("Segoe UI", 10F);
            appointmentsNameLabel.Location = new Point(36, 55);
            appointmentsNameLabel.Margin = new Padding(0);
            appointmentsNameLabel.Name = "appointmentsNameLabel";
            appointmentsNameLabel.Size = new Size(68, 28);
            appointmentsNameLabel.TabIndex = 1;
            appointmentsNameLabel.Text = "Name:";
            appointmentsNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // appointmentsCalendar
            // 
            appointmentsCalendar.Location = new Point(256, 55);
            appointmentsCalendar.Margin = new Padding(13, 15, 13, 15);
            appointmentsCalendar.Name = "appointmentsCalendar";
            appointmentsCalendar.TabIndex = 2;
            appointmentsCalendar.DateChanged += appointmentsCalendar_DateChanged;
            // 
            // appointmentsCancelBtn
            // 
            appointmentsCancelBtn.BackColor = Color.IndianRed;
            appointmentsCancelBtn.Location = new Point(113, 418);
            appointmentsCancelBtn.Margin = new Padding(4, 5, 4, 5);
            appointmentsCancelBtn.Name = "appointmentsCancelBtn";
            appointmentsCancelBtn.Size = new Size(144, 63);
            appointmentsCancelBtn.TabIndex = 3;
            appointmentsCancelBtn.Text = "Cancel";
            appointmentsCancelBtn.UseVisualStyleBackColor = false;
            appointmentsCancelBtn.Click += cancelappointments;
            // 
            // appointmentsEnterBtn
            // 
            appointmentsEnterBtn.BackColor = Color.YellowGreen;
            appointmentsEnterBtn.Cursor = Cursors.Hand;
            appointmentsEnterBtn.Location = new Point(349, 418);
            appointmentsEnterBtn.Margin = new Padding(4, 5, 4, 5);
            appointmentsEnterBtn.Name = "appointmentsEnterBtn";
            appointmentsEnterBtn.Size = new Size(144, 63);
            appointmentsEnterBtn.TabIndex = 4;
            appointmentsEnterBtn.Text = "Enter";
            appointmentsEnterBtn.UseVisualStyleBackColor = false;
            appointmentsEnterBtn.Click += appointmentsEnterBtn_Click;
            // 
            // appointmentsServiceTypeLabel
            // 
            appointmentsServiceTypeLabel.AutoSize = true;
            appointmentsServiceTypeLabel.Font = new Font("Segoe UI", 10F);
            appointmentsServiceTypeLabel.Location = new Point(36, 150);
            appointmentsServiceTypeLabel.Margin = new Padding(0);
            appointmentsServiceTypeLabel.Name = "appointmentsServiceTypeLabel";
            appointmentsServiceTypeLabel.Size = new Size(124, 28);
            appointmentsServiceTypeLabel.TabIndex = 6;
            appointmentsServiceTypeLabel.Text = "Service Type:";
            appointmentsServiceTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // appointmentsServiceTypeInput
            // 
            appointmentsServiceTypeInput.Location = new Point(36, 188);
            appointmentsServiceTypeInput.Margin = new Padding(4, 5, 4, 5);
            appointmentsServiceTypeInput.Name = "appointmentsServiceTypeInput";
            appointmentsServiceTypeInput.Size = new Size(180, 31);
            appointmentsServiceTypeInput.TabIndex = 5;
            // 
            // appointmentsCommissionLabel
            // 
            appointmentsCommissionLabel.AutoSize = true;
            appointmentsCommissionLabel.Font = new Font("Segoe UI", 10F);
            appointmentsCommissionLabel.Location = new Point(36, 248);
            appointmentsCommissionLabel.Margin = new Padding(0);
            appointmentsCommissionLabel.Name = "appointmentsCommissionLabel";
            appointmentsCommissionLabel.Size = new Size(123, 28);
            appointmentsCommissionLabel.TabIndex = 8;
            appointmentsCommissionLabel.Text = "Commission:";
            appointmentsCommissionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // appointmentsCommissionInput
            // 
            appointmentsCommissionInput.Location = new Point(36, 287);
            appointmentsCommissionInput.Margin = new Padding(4, 5, 4, 5);
            appointmentsCommissionInput.Name = "appointmentsCommissionInput";
            appointmentsCommissionInput.Size = new Size(180, 31);
            appointmentsCommissionInput.TabIndex = 7;
            // 
            // appointmentsInputPopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 535);
            Controls.Add(appointmentsCommissionLabel);
            Controls.Add(appointmentsCommissionInput);
            Controls.Add(appointmentsServiceTypeLabel);
            Controls.Add(appointmentsServiceTypeInput);
            Controls.Add(appointmentsEnterBtn);
            Controls.Add(appointmentsCancelBtn);
            Controls.Add(appointmentsCalendar);
            Controls.Add(appointmentsNameLabel);
            Controls.Add(appointmentsNameInput);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "appointmentsInputPopUp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Appointments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox appointmentsNameInput;
        private Label appointmentsNameLabel;
        private MonthCalendar appointmentsCalendar;
        private Button appointmentsCancelBtn;
        private Button appointmentsEnterBtn;
        private Label appointmentsServiceTypeLabel;
        private TextBox appointmentsServiceTypeInput;
        private Label appointmentsCommissionLabel;
        private TextBox appointmentsCommissionInput;
    }
}