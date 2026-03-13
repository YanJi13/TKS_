namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class AppointmentsInputPopUp
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
            appointmentsPaymentLabel = new Label();
            appointmentsPaymentInput = new TextBox();
            SuspendLayout();
            // 
            // appointmentsNameInput
            // 
            appointmentsNameInput.Location = new Point(25, 50);
            appointmentsNameInput.Name = "appointmentsNameInput";
            appointmentsNameInput.Size = new Size(127, 23);
            appointmentsNameInput.TabIndex = 0;
            // 
            // appointmentsNameLabel
            // 
            appointmentsNameLabel.AutoSize = true;
            appointmentsNameLabel.Font = new Font("Segoe UI", 9F);
            appointmentsNameLabel.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsNameLabel.Location = new Point(25, 33);
            appointmentsNameLabel.Margin = new Padding(0);
            appointmentsNameLabel.Name = "appointmentsNameLabel";
            appointmentsNameLabel.Size = new Size(42, 15);
            appointmentsNameLabel.TabIndex = 1;
            appointmentsNameLabel.Text = "Name:";
            appointmentsNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // appointmentsCalendar
            // 
            appointmentsCalendar.BackColor = Color.FromArgb(129, 161, 193);
            appointmentsCalendar.Location = new Point(179, 33);
            appointmentsCalendar.Name = "appointmentsCalendar";
            appointmentsCalendar.TabIndex = 2;
            appointmentsCalendar.TitleForeColor = Color.FromArgb(129, 161, 193);
            appointmentsCalendar.TrailingForeColor = Color.FromArgb(129, 161, 193);
            appointmentsCalendar.DateChanged += appointmentsCalendar_DateChanged;
            // 
            // appointmentsCancelBtn
            // 
            appointmentsCancelBtn.BackColor = Color.FromArgb(191, 97, 106);
            appointmentsCancelBtn.FlatStyle = FlatStyle.Popup;
            appointmentsCancelBtn.Location = new Point(79, 251);
            appointmentsCancelBtn.Name = "appointmentsCancelBtn";
            appointmentsCancelBtn.Size = new Size(101, 38);
            appointmentsCancelBtn.TabIndex = 3;
            appointmentsCancelBtn.Text = "Cancel";
            appointmentsCancelBtn.UseVisualStyleBackColor = false;
            appointmentsCancelBtn.Click += cancelappointments;
            // 
            // appointmentsEnterBtn
            // 
            appointmentsEnterBtn.BackColor = Color.FromArgb(145, 188, 143);
            appointmentsEnterBtn.Cursor = Cursors.Hand;
            appointmentsEnterBtn.FlatStyle = FlatStyle.Popup;
            appointmentsEnterBtn.Location = new Point(244, 251);
            appointmentsEnterBtn.Name = "appointmentsEnterBtn";
            appointmentsEnterBtn.Size = new Size(101, 38);
            appointmentsEnterBtn.TabIndex = 4;
            appointmentsEnterBtn.Text = "Enter";
            appointmentsEnterBtn.UseVisualStyleBackColor = false;
            appointmentsEnterBtn.Click += appointmentsEnterBtn_Click;
            // 
            // appointmentsServiceTypeLabel
            // 
            appointmentsServiceTypeLabel.AutoSize = true;
            appointmentsServiceTypeLabel.Font = new Font("Segoe UI", 9F);
            appointmentsServiceTypeLabel.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsServiceTypeLabel.Location = new Point(25, 76);
            appointmentsServiceTypeLabel.Margin = new Padding(0);
            appointmentsServiceTypeLabel.Name = "appointmentsServiceTypeLabel";
            appointmentsServiceTypeLabel.Size = new Size(74, 15);
            appointmentsServiceTypeLabel.TabIndex = 6;
            appointmentsServiceTypeLabel.Text = "Service Type:";
            appointmentsServiceTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // appointmentsServiceTypeInput
            // 
            appointmentsServiceTypeInput.Location = new Point(25, 94);
            appointmentsServiceTypeInput.Name = "appointmentsServiceTypeInput";
            appointmentsServiceTypeInput.Size = new Size(127, 23);
            appointmentsServiceTypeInput.TabIndex = 5;
            // 
            // appointmentsCommissionLabel
            // 
            appointmentsCommissionLabel.AutoSize = true;
            appointmentsCommissionLabel.Font = new Font("Segoe UI", 9F);
            appointmentsCommissionLabel.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsCommissionLabel.Location = new Point(25, 164);
            appointmentsCommissionLabel.Margin = new Padding(0);
            appointmentsCommissionLabel.Name = "appointmentsCommissionLabel";
            appointmentsCommissionLabel.Size = new Size(77, 15);
            appointmentsCommissionLabel.TabIndex = 8;
            appointmentsCommissionLabel.Text = "Commission:";
            appointmentsCommissionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // appointmentsCommissionInput
            // 
            appointmentsCommissionInput.Location = new Point(25, 182);
            appointmentsCommissionInput.Name = "appointmentsCommissionInput";
            appointmentsCommissionInput.Size = new Size(127, 23);
            appointmentsCommissionInput.TabIndex = 7;
            // 
            // appointmentsPaymentLabel
            // 
            appointmentsPaymentLabel.AutoSize = true;
            appointmentsPaymentLabel.Font = new Font("Segoe UI", 9F);
            appointmentsPaymentLabel.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsPaymentLabel.Location = new Point(25, 120);
            appointmentsPaymentLabel.Margin = new Padding(0);
            appointmentsPaymentLabel.Name = "appointmentsPaymentLabel";
            appointmentsPaymentLabel.Size = new Size(57, 15);
            appointmentsPaymentLabel.TabIndex = 9;
            appointmentsPaymentLabel.Text = "Payment:";
            appointmentsPaymentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // appointmentsPaymentInput
            // 
            appointmentsPaymentInput.Location = new Point(25, 138);
            appointmentsPaymentInput.Name = "appointmentsPaymentInput";
            appointmentsPaymentInput.Size = new Size(127, 23);
            appointmentsPaymentInput.TabIndex = 10;
            // 
            // AppointmentsInputPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 79, 99);
            ClientSize = new Size(424, 321);
            Controls.Add(appointmentsPaymentInput);
            Controls.Add(appointmentsPaymentLabel);
            Controls.Add(appointmentsCommissionLabel);
            Controls.Add(appointmentsCommissionInput);
            Controls.Add(appointmentsServiceTypeLabel);
            Controls.Add(appointmentsServiceTypeInput);
            Controls.Add(appointmentsEnterBtn);
            Controls.Add(appointmentsCancelBtn);
            Controls.Add(appointmentsCalendar);
            Controls.Add(appointmentsNameLabel);
            Controls.Add(appointmentsNameInput);
            MaximizeBox = false;
            Name = "AppointmentsInputPopUp";
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
        private Label appointmentsPaymentLabel;
        private TextBox appointmentsPaymentInput;
    }
}