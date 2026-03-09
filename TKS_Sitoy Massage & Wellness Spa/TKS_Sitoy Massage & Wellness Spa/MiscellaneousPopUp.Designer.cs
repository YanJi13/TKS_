namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class miscellaneousInputPopUp
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
            miscExpensesAmountInput = new TextBox();
            miscExpensesAmountLabel = new Label();
            miscellaneousCalendar = new MonthCalendar();
            miscellaneousCancelBtn = new Button();
            miscellaneousEnterBtn = new Button();
            miscNoteLabel = new Label();
            miscNoteInput = new TextBox();
            SuspendLayout();
            // 
            // miscExpensesAmountInput
            // 
            miscExpensesAmountInput.Location = new Point(25, 56);
            miscExpensesAmountInput.Name = "miscExpensesAmountInput";
            miscExpensesAmountInput.Size = new Size(127, 23);
            miscExpensesAmountInput.TabIndex = 0;
            // 
            // miscExpensesAmountLabel
            // 
            miscExpensesAmountLabel.AutoSize = true;
            miscExpensesAmountLabel.Font = new Font("Segoe UI", 10F);
            miscExpensesAmountLabel.Location = new Point(25, 33);
            miscExpensesAmountLabel.Margin = new Padding(0);
            miscExpensesAmountLabel.Name = "miscExpensesAmountLabel";
            miscExpensesAmountLabel.Size = new Size(94, 19);
            miscExpensesAmountLabel.TabIndex = 1;
            miscExpensesAmountLabel.Text = "Misc Amount:";
            miscExpensesAmountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // miscellaneousCalendar
            // 
            miscellaneousCalendar.Location = new Point(179, 33);
            miscellaneousCalendar.Name = "miscellaneousCalendar";
            miscellaneousCalendar.TabIndex = 2;
            // 
            // miscellaneousCancelBtn
            // 
            miscellaneousCancelBtn.BackColor = Color.IndianRed;
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
            miscellaneousEnterBtn.BackColor = Color.YellowGreen;
            miscellaneousEnterBtn.Cursor = Cursors.Hand;
            miscellaneousEnterBtn.Location = new Point(244, 251);
            miscellaneousEnterBtn.Name = "miscellaneousEnterBtn";
            miscellaneousEnterBtn.Size = new Size(101, 38);
            miscellaneousEnterBtn.TabIndex = 4;
            miscellaneousEnterBtn.Text = "Enter";
            miscellaneousEnterBtn.UseVisualStyleBackColor = false;
            // 
            // miscNoteLabel
            // 
            miscNoteLabel.AutoSize = true;
            miscNoteLabel.Font = new Font("Segoe UI", 10F);
            miscNoteLabel.Location = new Point(25, 93);
            miscNoteLabel.Margin = new Padding(0);
            miscNoteLabel.Name = "miscNoteLabel";
            miscNoteLabel.Size = new Size(42, 19);
            miscNoteLabel.TabIndex = 6;
            miscNoteLabel.Text = "Note:";
            miscNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // miscNoteInput
            // 
            miscNoteInput.Location = new Point(25, 116);
            miscNoteInput.MaxLength = 100;
            miscNoteInput.Multiline = true;
            miscNoteInput.Name = "miscNoteInput";
            miscNoteInput.ScrollBars = ScrollBars.Vertical;
            miscNoteInput.Size = new Size(142, 79);
            miscNoteInput.TabIndex = 5;
            // 
            // miscellaneousInputPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 321);
            Controls.Add(miscNoteLabel);
            Controls.Add(miscNoteInput);
            Controls.Add(miscellaneousEnterBtn);
            Controls.Add(miscellaneousCancelBtn);
            Controls.Add(miscellaneousCalendar);
            Controls.Add(miscExpensesAmountLabel);
            Controls.Add(miscExpensesAmountInput);
            MaximizeBox = false;
            Name = "miscellaneousInputPopUp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "miscellaneous";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox miscExpensesAmountInput;
        private Label miscExpensesAmountLabel;
        private MonthCalendar miscellaneousCalendar;
        private Button miscellaneousCancelBtn;
        private Button miscellaneousEnterBtn;
        private Label miscNoteLabel;
        private TextBox miscNoteInput;
    }
}