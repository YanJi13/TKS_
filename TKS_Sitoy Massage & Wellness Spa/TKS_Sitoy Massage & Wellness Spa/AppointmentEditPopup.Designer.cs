namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class AppointmentEditPopup
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
            appointmentNameEditInput = new TextBox();
            appointmentNameEditLabel = new Label();
            appointmentServiceEditLabel = new Label();
            appointmentServiceEditInput = new TextBox();
            appointmentPaymentEditLabel = new Label();
            appointmentPaymentEditInput = new TextBox();
            appointmentCommissionEditLabel = new Label();
            appointmentCommEditInput = new TextBox();
            appointmentsEditYesBtn = new Button();
            appointmentsEditNoBtn = new Button();
            SuspendLayout();
            // 
            // appointmentNameEditInput
            // 
            appointmentNameEditInput.Location = new Point(52, 50);
            appointmentNameEditInput.Name = "appointmentNameEditInput";
            appointmentNameEditInput.Size = new Size(100, 23);
            appointmentNameEditInput.TabIndex = 0;
            // 
            // appointmentNameEditLabel
            // 
            appointmentNameEditLabel.AutoSize = true;
            appointmentNameEditLabel.Font = new Font("Segoe UI", 10F);
            appointmentNameEditLabel.Location = new Point(52, 28);
            appointmentNameEditLabel.Name = "appointmentNameEditLabel";
            appointmentNameEditLabel.Size = new Size(45, 19);
            appointmentNameEditLabel.TabIndex = 1;
            appointmentNameEditLabel.Text = "Name";
            // 
            // appointmentServiceEditLabel
            // 
            appointmentServiceEditLabel.AutoSize = true;
            appointmentServiceEditLabel.Font = new Font("Segoe UI", 10F);
            appointmentServiceEditLabel.Location = new Point(175, 28);
            appointmentServiceEditLabel.Name = "appointmentServiceEditLabel";
            appointmentServiceEditLabel.Size = new Size(51, 19);
            appointmentServiceEditLabel.TabIndex = 3;
            appointmentServiceEditLabel.Text = "Service";
            // 
            // appointmentServiceEditInput
            // 
            appointmentServiceEditInput.Location = new Point(175, 50);
            appointmentServiceEditInput.Name = "appointmentServiceEditInput";
            appointmentServiceEditInput.Size = new Size(100, 23);
            appointmentServiceEditInput.TabIndex = 2;
            // 
            // appointmentPaymentEditLabel
            // 
            appointmentPaymentEditLabel.AutoSize = true;
            appointmentPaymentEditLabel.Font = new Font("Segoe UI", 10F);
            appointmentPaymentEditLabel.Location = new Point(52, 76);
            appointmentPaymentEditLabel.Name = "appointmentPaymentEditLabel";
            appointmentPaymentEditLabel.Size = new Size(63, 19);
            appointmentPaymentEditLabel.TabIndex = 5;
            appointmentPaymentEditLabel.Text = "Payment";
            // 
            // appointmentPaymentEditInput
            // 
            appointmentPaymentEditInput.Location = new Point(52, 98);
            appointmentPaymentEditInput.Name = "appointmentPaymentEditInput";
            appointmentPaymentEditInput.Size = new Size(100, 23);
            appointmentPaymentEditInput.TabIndex = 4;
            // 
            // appointmentCommissionEditLabel
            // 
            appointmentCommissionEditLabel.AutoSize = true;
            appointmentCommissionEditLabel.Font = new Font("Segoe UI", 10F);
            appointmentCommissionEditLabel.Location = new Point(175, 76);
            appointmentCommissionEditLabel.Name = "appointmentCommissionEditLabel";
            appointmentCommissionEditLabel.Size = new Size(84, 19);
            appointmentCommissionEditLabel.TabIndex = 7;
            appointmentCommissionEditLabel.Text = "Commission";
            // 
            // appointmentCommEditInput
            // 
            appointmentCommEditInput.Location = new Point(175, 98);
            appointmentCommEditInput.Name = "appointmentCommEditInput";
            appointmentCommEditInput.Size = new Size(100, 23);
            appointmentCommEditInput.TabIndex = 6;
            // 
            // appointmentsEditYesBtn
            // 
            appointmentsEditYesBtn.BackColor = Color.YellowGreen;
            appointmentsEditYesBtn.Location = new Point(184, 155);
            appointmentsEditYesBtn.Name = "appointmentsEditYesBtn";
            appointmentsEditYesBtn.Size = new Size(101, 38);
            appointmentsEditYesBtn.TabIndex = 9;
            appointmentsEditYesBtn.Text = "Yes";
            appointmentsEditYesBtn.UseVisualStyleBackColor = false;
            // 
            // appointmentsEditNoBtn
            // 
            appointmentsEditNoBtn.BackColor = Color.IndianRed;
            appointmentsEditNoBtn.Location = new Point(42, 155);
            appointmentsEditNoBtn.Name = "appointmentsEditNoBtn";
            appointmentsEditNoBtn.Size = new Size(101, 38);
            appointmentsEditNoBtn.TabIndex = 8;
            appointmentsEditNoBtn.Text = "No";
            appointmentsEditNoBtn.UseVisualStyleBackColor = false;
            // 
            // AppointmentEditPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 235);
            Controls.Add(appointmentsEditYesBtn);
            Controls.Add(appointmentsEditNoBtn);
            Controls.Add(appointmentCommissionEditLabel);
            Controls.Add(appointmentCommEditInput);
            Controls.Add(appointmentPaymentEditLabel);
            Controls.Add(appointmentPaymentEditInput);
            Controls.Add(appointmentServiceEditLabel);
            Controls.Add(appointmentServiceEditInput);
            Controls.Add(appointmentNameEditLabel);
            Controls.Add(appointmentNameEditInput);
            Name = "AppointmentEditPopup";
            Text = "Appointment Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox appointmentNameEditInput;
        private Label appointmentNameEditLabel;
        private Label appointmentServiceEditLabel;
        private TextBox appointmentServiceEditInput;
        private Label appointmentPaymentEditLabel;
        private TextBox appointmentPaymentEditInput;
        private Label appointmentCommissionEditLabel;
        private TextBox appointmentCommEditInput;
        private Button appointmentsEditYesBtn;
        private Button appointmentsEditNoBtn;
    }
}