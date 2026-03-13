namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class AppointmentsEditPopup
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
            appointmentsNameEditInput = new TextBox();
            appointmentsNameEditLabel = new Label();
            appointmentserviceEditLabel = new Label();
            appointmentServiceEditInput = new TextBox();
            appointmentsPaymentEditLabel = new Label();
            appointmentsPaymentEditInput = new TextBox();
            appointmentsCommissionEditLabel = new Label();
            appointmentsCommEditInput = new TextBox();
            appointmentsEditYesBtn = new Button();
            appointmentsEditNoBtn = new Button();
            SuspendLayout();
            // 
            // appointmentsNameEditInput
            // 
            appointmentsNameEditInput.Location = new Point(52, 50);
            appointmentsNameEditInput.Name = "appointmentsNameEditInput";
            appointmentsNameEditInput.Size = new Size(100, 23);
            appointmentsNameEditInput.TabIndex = 0;
            // 
            // appointmentsNameEditLabel
            // 
            appointmentsNameEditLabel.AutoSize = true;
            appointmentsNameEditLabel.Font = new Font("Segoe UI", 10F);
            appointmentsNameEditLabel.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsNameEditLabel.Location = new Point(52, 28);
            appointmentsNameEditLabel.Name = "appointmentsNameEditLabel";
            appointmentsNameEditLabel.Size = new Size(45, 19);
            appointmentsNameEditLabel.TabIndex = 1;
            appointmentsNameEditLabel.Text = "Name";
            // 
            // appointmentserviceEditLabel
            // 
            appointmentserviceEditLabel.AutoSize = true;
            appointmentserviceEditLabel.Font = new Font("Segoe UI", 10F);
            appointmentserviceEditLabel.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentserviceEditLabel.Location = new Point(175, 28);
            appointmentserviceEditLabel.Name = "appointmentserviceEditLabel";
            appointmentserviceEditLabel.Size = new Size(51, 19);
            appointmentserviceEditLabel.TabIndex = 3;
            appointmentserviceEditLabel.Text = "Service";
            // 
            // appointmentServiceEditInput
            // 
            appointmentServiceEditInput.Location = new Point(175, 50);
            appointmentServiceEditInput.Name = "appointmentServiceEditInput";
            appointmentServiceEditInput.Size = new Size(100, 23);
            appointmentServiceEditInput.TabIndex = 2;
            // 
            // appointmentsPaymentEditLabel
            // 
            appointmentsPaymentEditLabel.AutoSize = true;
            appointmentsPaymentEditLabel.Font = new Font("Segoe UI", 10F);
            appointmentsPaymentEditLabel.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsPaymentEditLabel.Location = new Point(52, 76);
            appointmentsPaymentEditLabel.Name = "appointmentsPaymentEditLabel";
            appointmentsPaymentEditLabel.Size = new Size(63, 19);
            appointmentsPaymentEditLabel.TabIndex = 5;
            appointmentsPaymentEditLabel.Text = "Payment";
            // 
            // appointmentsPaymentEditInput
            // 
            appointmentsPaymentEditInput.Location = new Point(52, 98);
            appointmentsPaymentEditInput.Name = "appointmentsPaymentEditInput";
            appointmentsPaymentEditInput.Size = new Size(100, 23);
            appointmentsPaymentEditInput.TabIndex = 4;
            // 
            // appointmentsCommissionEditLabel
            // 
            appointmentsCommissionEditLabel.AutoSize = true;
            appointmentsCommissionEditLabel.Font = new Font("Segoe UI", 10F);
            appointmentsCommissionEditLabel.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsCommissionEditLabel.Location = new Point(175, 76);
            appointmentsCommissionEditLabel.Name = "appointmentsCommissionEditLabel";
            appointmentsCommissionEditLabel.Size = new Size(84, 19);
            appointmentsCommissionEditLabel.TabIndex = 7;
            appointmentsCommissionEditLabel.Text = "Commission";
            // 
            // appointmentsCommEditInput
            // 
            appointmentsCommEditInput.Location = new Point(175, 98);
            appointmentsCommEditInput.Name = "appointmentsCommEditInput";
            appointmentsCommEditInput.Size = new Size(100, 23);
            appointmentsCommEditInput.TabIndex = 6;
            // 
            // appointmentsEditYesBtn
            // 
            appointmentsEditYesBtn.BackColor = Color.FromArgb(145, 188, 143);
            appointmentsEditYesBtn.FlatStyle = FlatStyle.Popup;
            appointmentsEditYesBtn.Location = new Point(184, 155);
            appointmentsEditYesBtn.Name = "appointmentsEditYesBtn";
            appointmentsEditYesBtn.Size = new Size(101, 38);
            appointmentsEditYesBtn.TabIndex = 9;
            appointmentsEditYesBtn.Text = "Yes";
            appointmentsEditYesBtn.UseVisualStyleBackColor = false;
            // 
            // appointmentsEditNoBtn
            // 
            appointmentsEditNoBtn.BackColor = Color.FromArgb(191, 97, 106);
            appointmentsEditNoBtn.FlatStyle = FlatStyle.Popup;
            appointmentsEditNoBtn.Location = new Point(42, 155);
            appointmentsEditNoBtn.Name = "appointmentsEditNoBtn";
            appointmentsEditNoBtn.Size = new Size(101, 38);
            appointmentsEditNoBtn.TabIndex = 8;
            appointmentsEditNoBtn.Text = "No";
            appointmentsEditNoBtn.UseVisualStyleBackColor = false;
            // 
            // AppointmentsEditPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 79, 99);
            ClientSize = new Size(326, 235);
            Controls.Add(appointmentsEditYesBtn);
            Controls.Add(appointmentsEditNoBtn);
            Controls.Add(appointmentsCommissionEditLabel);
            Controls.Add(appointmentsCommEditInput);
            Controls.Add(appointmentsPaymentEditLabel);
            Controls.Add(appointmentsPaymentEditInput);
            Controls.Add(appointmentserviceEditLabel);
            Controls.Add(appointmentServiceEditInput);
            Controls.Add(appointmentsNameEditLabel);
            Controls.Add(appointmentsNameEditInput);
            Name = "AppointmentsEditPopup";
            Text = "Appointments Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox appointmentsNameEditInput;
        private Label appointmentsNameEditLabel;
        private Label appointmentserviceEditLabel;
        private TextBox appointmentServiceEditInput;
        private Label appointmentsPaymentEditLabel;
        private TextBox appointmentsPaymentEditInput;
        private Label appointmentsCommissionEditLabel;
        private TextBox appointmentsCommEditInput;
        private Button appointmentsEditYesBtn;
        private Button appointmentsEditNoBtn;
    }
}