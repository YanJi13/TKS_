namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class MiscellaneousInputPopUp
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
            miscellaneousExpensesAmountInput = new TextBox();
            miscellaneousExpensesAmountLabel = new Label();
            miscellaneousCalendar = new MonthCalendar();
            miscellaneousCancelBtn = new Button();
            miscellaneousEnterBtn = new Button();
            miscellaneousNoteLabel = new Label();
            miscellaneousNoteInput = new TextBox();
            SuspendLayout();
            // 
            // miscellaneousExpensesAmountInput
            // 
            miscellaneousExpensesAmountInput.Location = new Point(25, 56);
            miscellaneousExpensesAmountInput.Name = "miscellaneousExpensesAmountInput";
            miscellaneousExpensesAmountInput.Size = new Size(127, 23);
            miscellaneousExpensesAmountInput.TabIndex = 0;
            // 
            // miscellaneousExpensesAmountLabel
            // 
            miscellaneousExpensesAmountLabel.AutoSize = true;
            miscellaneousExpensesAmountLabel.Font = new Font("Segoe UI", 10F);
            miscellaneousExpensesAmountLabel.ForeColor = Color.FromArgb(236, 239, 244);
            miscellaneousExpensesAmountLabel.Location = new Point(25, 33);
            miscellaneousExpensesAmountLabel.Margin = new Padding(0);
            miscellaneousExpensesAmountLabel.Name = "miscellaneousExpensesAmountLabel";
            miscellaneousExpensesAmountLabel.Size = new Size(94, 19);
            miscellaneousExpensesAmountLabel.TabIndex = 1;
            miscellaneousExpensesAmountLabel.Text = "Misc Amount:";
            miscellaneousExpensesAmountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // miscellaneousCalendar
            // 
            miscellaneousCalendar.Location = new Point(179, 33);
            miscellaneousCalendar.Name = "miscellaneousCalendar";
            miscellaneousCalendar.TabIndex = 2;
            miscellaneousCalendar.DateChanged += miscellaneousCalendar_DateChanged;
            // 
            // miscellaneousCancelBtn
            // 
            miscellaneousCancelBtn.BackColor = Color.FromArgb(191, 97, 106);
            miscellaneousCancelBtn.FlatStyle = FlatStyle.Popup;
            miscellaneousCancelBtn.Location = new Point(79, 251);
            miscellaneousCancelBtn.Name = "miscellaneousCancelBtn";
            miscellaneousCancelBtn.Size = new Size(101, 38);
            miscellaneousCancelBtn.TabIndex = 3;
            miscellaneousCancelBtn.Text = "Cancel";
            miscellaneousCancelBtn.UseVisualStyleBackColor = false;
            miscellaneousCancelBtn.Click += cancelmiscellaneous;
            // 
            // miscellaneousEnterBtn
            // 
            miscellaneousEnterBtn.BackColor = Color.FromArgb(145, 188, 143);
            miscellaneousEnterBtn.Cursor = Cursors.Hand;
            miscellaneousEnterBtn.FlatStyle = FlatStyle.Popup;
            miscellaneousEnterBtn.Location = new Point(244, 251);
            miscellaneousEnterBtn.Name = "miscellaneousEnterBtn";
            miscellaneousEnterBtn.Size = new Size(101, 38);
            miscellaneousEnterBtn.TabIndex = 4;
            miscellaneousEnterBtn.Text = "Enter";
            miscellaneousEnterBtn.UseVisualStyleBackColor = false;
            miscellaneousEnterBtn.Click += miscellaneousEnterBtn_Click;
            // 
            // miscellaneousNoteLabel
            // 
            miscellaneousNoteLabel.AutoSize = true;
            miscellaneousNoteLabel.Font = new Font("Segoe UI", 10F);
            miscellaneousNoteLabel.ForeColor = Color.FromArgb(236, 239, 244);
            miscellaneousNoteLabel.Location = new Point(25, 93);
            miscellaneousNoteLabel.Margin = new Padding(0);
            miscellaneousNoteLabel.Name = "miscellaneousNoteLabel";
            miscellaneousNoteLabel.Size = new Size(42, 19);
            miscellaneousNoteLabel.TabIndex = 6;
            miscellaneousNoteLabel.Text = "Note:";
            miscellaneousNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // miscellaneousNoteInput
            // 
            miscellaneousNoteInput.Location = new Point(25, 116);
            miscellaneousNoteInput.MaxLength = 100;
            miscellaneousNoteInput.Multiline = true;
            miscellaneousNoteInput.Name = "miscellaneousNoteInput";
            miscellaneousNoteInput.ScrollBars = ScrollBars.Vertical;
            miscellaneousNoteInput.Size = new Size(142, 79);
            miscellaneousNoteInput.TabIndex = 5;
            // 
            // MiscellaneousInputPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 79, 99);
            ClientSize = new Size(424, 321);
            Controls.Add(miscellaneousNoteLabel);
            Controls.Add(miscellaneousNoteInput);
            Controls.Add(miscellaneousEnterBtn);
            Controls.Add(miscellaneousCancelBtn);
            Controls.Add(miscellaneousCalendar);
            Controls.Add(miscellaneousExpensesAmountLabel);
            Controls.Add(miscellaneousExpensesAmountInput);
            MaximizeBox = false;
            Name = "MiscellaneousInputPopUp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Miscellaneous";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox miscellaneousExpensesAmountInput;
        private Label miscellaneousExpensesAmountLabel;
        private MonthCalendar miscellaneousCalendar;
        private Button miscellaneousCancelBtn;
        private Button miscellaneousEnterBtn;
        private Label miscellaneousNoteLabel;
        private TextBox miscellaneousNoteInput;
    }
}