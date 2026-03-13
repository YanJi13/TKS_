namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class MiscellaneousEditPopup
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
            miscellaneousAmountEditInput = new TextBox();
            miscellaneousAmountEditLabel = new Label();
            miscellaneousNoteEditLabel = new Label();
            miscellaneousEditYesBtn = new Button();
            miscellaneousEditNoBtn = new Button();
            miscellaneousNoteEditInput = new TextBox();
            SuspendLayout();
            // 
            // miscellaneousAmountEditInput
            // 
            miscellaneousAmountEditInput.Location = new Point(31, 50);
            miscellaneousAmountEditInput.Name = "miscellaneousAmountEditInput";
            miscellaneousAmountEditInput.Size = new Size(100, 23);
            miscellaneousAmountEditInput.TabIndex = 0;
            // 
            // miscellaneousAmountEditLabel
            // 
            miscellaneousAmountEditLabel.AutoSize = true;
            miscellaneousAmountEditLabel.Font = new Font("Segoe UI", 10F);
            miscellaneousAmountEditLabel.ForeColor = Color.FromArgb(236, 239, 244);
            miscellaneousAmountEditLabel.Location = new Point(31, 28);
            miscellaneousAmountEditLabel.Name = "miscellaneousAmountEditLabel";
            miscellaneousAmountEditLabel.Size = new Size(91, 19);
            miscellaneousAmountEditLabel.TabIndex = 1;
            miscellaneousAmountEditLabel.Text = "Misc Amount";
            // 
            // miscellaneousNoteEditLabel
            // 
            miscellaneousNoteEditLabel.AutoSize = true;
            miscellaneousNoteEditLabel.Font = new Font("Segoe UI", 10F);
            miscellaneousNoteEditLabel.ForeColor = Color.FromArgb(236, 239, 244);
            miscellaneousNoteEditLabel.Location = new Point(154, 28);
            miscellaneousNoteEditLabel.Name = "miscellaneousNoteEditLabel";
            miscellaneousNoteEditLabel.Size = new Size(39, 19);
            miscellaneousNoteEditLabel.TabIndex = 3;
            miscellaneousNoteEditLabel.Text = "Note";
            // 
            // miscellaneousEditYesBtn
            // 
            miscellaneousEditYesBtn.BackColor = Color.FromArgb(145, 188, 143);
            miscellaneousEditYesBtn.FlatStyle = FlatStyle.Flat;
            miscellaneousEditYesBtn.Location = new Point(184, 155);
            miscellaneousEditYesBtn.Name = "miscellaneousEditYesBtn";
            miscellaneousEditYesBtn.Size = new Size(101, 38);
            miscellaneousEditYesBtn.TabIndex = 9;
            miscellaneousEditYesBtn.Text = "Yes";
            miscellaneousEditYesBtn.UseVisualStyleBackColor = false;
            // 
            // miscellaneousEditNoBtn
            // 
            miscellaneousEditNoBtn.BackColor = Color.FromArgb(191, 97, 106);
            miscellaneousEditNoBtn.FlatStyle = FlatStyle.Flat;
            miscellaneousEditNoBtn.Location = new Point(42, 155);
            miscellaneousEditNoBtn.Name = "miscellaneousEditNoBtn";
            miscellaneousEditNoBtn.Size = new Size(101, 38);
            miscellaneousEditNoBtn.TabIndex = 8;
            miscellaneousEditNoBtn.Text = "No";
            miscellaneousEditNoBtn.UseVisualStyleBackColor = false;
            // 
            // miscellaneousNoteEditInput
            // 
            miscellaneousNoteEditInput.Location = new Point(154, 50);
            miscellaneousNoteEditInput.MaxLength = 100;
            miscellaneousNoteEditInput.Multiline = true;
            miscellaneousNoteEditInput.Name = "miscellaneousNoteEditInput";
            miscellaneousNoteEditInput.ScrollBars = ScrollBars.Vertical;
            miscellaneousNoteEditInput.Size = new Size(142, 79);
            miscellaneousNoteEditInput.TabIndex = 10;
            // 
            // MiscellaneousEditPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 79, 99);
            ClientSize = new Size(326, 235);
            Controls.Add(miscellaneousNoteEditInput);
            Controls.Add(miscellaneousEditYesBtn);
            Controls.Add(miscellaneousEditNoBtn);
            Controls.Add(miscellaneousNoteEditLabel);
            Controls.Add(miscellaneousAmountEditLabel);
            Controls.Add(miscellaneousAmountEditInput);
            Name = "MiscellaneousEditPopup";
            Text = "Miscellaneous Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox miscellaneousAmountEditInput;
        private Label miscellaneousAmountEditLabel;
        private Label miscellaneousNoteEditLabel;
        private Button miscellaneousEditYesBtn;
        private Button miscellaneousEditNoBtn;
        private TextBox miscellaneousNoteEditInput;
    }
}