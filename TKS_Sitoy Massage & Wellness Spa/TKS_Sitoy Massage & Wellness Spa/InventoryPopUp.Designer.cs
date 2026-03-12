namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class inventoryInputPopUp
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
            inventoryOilLabel = new Label();
            inventoryCalendar = new MonthCalendar();
            inventoryCancelBtn = new Button();
            inventoryEnterBtn = new Button();
            inventoryTowelLabel = new Label();
            inventoryBedSheetLabel = new Label();
            inventoryBedSheetCheck = new CheckBox();
            inventoryTowelCheck = new CheckBox();
            inventoryOilCheck = new CheckBox();
            SuspendLayout();
            // 
            // inventoryOilLabel
            // 
            inventoryOilLabel.AutoSize = true;
            inventoryOilLabel.Font = new Font("Segoe UI", 10F);
            inventoryOilLabel.Location = new Point(47, 55);
            inventoryOilLabel.Margin = new Padding(0);
            inventoryOilLabel.Name = "inventoryOilLabel";
            inventoryOilLabel.Size = new Size(41, 28);
            inventoryOilLabel.TabIndex = 1;
            inventoryOilLabel.Text = "Oil:";
            inventoryOilLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inventoryCalendar
            // 
            inventoryCalendar.Location = new Point(256, 55);
            inventoryCalendar.Margin = new Padding(13, 15, 13, 15);
            inventoryCalendar.Name = "inventoryCalendar";
            inventoryCalendar.TabIndex = 2;
            inventoryCalendar.DateChanged += inventoryCalendar_DateChanged;
            // 
            // inventoryCancelBtn
            // 
            inventoryCancelBtn.BackColor = Color.IndianRed;
            inventoryCancelBtn.Location = new Point(113, 418);
            inventoryCancelBtn.Margin = new Padding(4, 5, 4, 5);
            inventoryCancelBtn.Name = "inventoryCancelBtn";
            inventoryCancelBtn.Size = new Size(144, 63);
            inventoryCancelBtn.TabIndex = 3;
            inventoryCancelBtn.Text = "Cancel";
            inventoryCancelBtn.UseVisualStyleBackColor = false;
            inventoryCancelBtn.Click += cancelinventory;
            // 
            // inventoryEnterBtn
            // 
            inventoryEnterBtn.BackColor = Color.YellowGreen;
            inventoryEnterBtn.Cursor = Cursors.Hand;
            inventoryEnterBtn.Location = new Point(349, 418);
            inventoryEnterBtn.Margin = new Padding(4, 5, 4, 5);
            inventoryEnterBtn.Name = "inventoryEnterBtn";
            inventoryEnterBtn.Size = new Size(144, 63);
            inventoryEnterBtn.TabIndex = 4;
            inventoryEnterBtn.Text = "Enter";
            inventoryEnterBtn.UseVisualStyleBackColor = false;
            inventoryEnterBtn.Click += inventoryEnterBtn_Click;
            // 
            // inventoryTowelLabel
            // 
            inventoryTowelLabel.AutoSize = true;
            inventoryTowelLabel.Font = new Font("Segoe UI", 10F);
            inventoryTowelLabel.Location = new Point(47, 115);
            inventoryTowelLabel.Margin = new Padding(0);
            inventoryTowelLabel.Name = "inventoryTowelLabel";
            inventoryTowelLabel.Size = new Size(65, 28);
            inventoryTowelLabel.TabIndex = 6;
            inventoryTowelLabel.Text = "Towel:";
            inventoryTowelLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inventoryBedSheetLabel
            // 
            inventoryBedSheetLabel.AutoSize = true;
            inventoryBedSheetLabel.Font = new Font("Segoe UI", 10F);
            inventoryBedSheetLabel.Location = new Point(47, 172);
            inventoryBedSheetLabel.Margin = new Padding(0);
            inventoryBedSheetLabel.Name = "inventoryBedSheetLabel";
            inventoryBedSheetLabel.Size = new Size(103, 28);
            inventoryBedSheetLabel.TabIndex = 8;
            inventoryBedSheetLabel.Text = "Bed Sheet:";
            inventoryBedSheetLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inventoryBedSheetCheck
            // 
            inventoryBedSheetCheck.Appearance = Appearance.Button;
            inventoryBedSheetCheck.Location = new Point(166, 173);
            inventoryBedSheetCheck.Margin = new Padding(4, 5, 4, 5);
            inventoryBedSheetCheck.Name = "inventoryBedSheetCheck";
            inventoryBedSheetCheck.Size = new Size(29, 33);
            inventoryBedSheetCheck.TabIndex = 9;
            inventoryBedSheetCheck.TextAlign = ContentAlignment.MiddleRight;
            inventoryBedSheetCheck.UseVisualStyleBackColor = true;
            // 
            // inventoryTowelCheck
            // 
            inventoryTowelCheck.Appearance = Appearance.Button;
            inventoryTowelCheck.Location = new Point(166, 113);
            inventoryTowelCheck.Margin = new Padding(4, 5, 4, 5);
            inventoryTowelCheck.Name = "inventoryTowelCheck";
            inventoryTowelCheck.Size = new Size(29, 33);
            inventoryTowelCheck.TabIndex = 10;
            inventoryTowelCheck.TextAlign = ContentAlignment.MiddleRight;
            inventoryTowelCheck.UseVisualStyleBackColor = true;
            // 
            // inventoryOilCheck
            // 
            inventoryOilCheck.Appearance = Appearance.Button;
            inventoryOilCheck.Location = new Point(166, 57);
            inventoryOilCheck.Margin = new Padding(4, 5, 4, 5);
            inventoryOilCheck.Name = "inventoryOilCheck";
            inventoryOilCheck.Size = new Size(29, 33);
            inventoryOilCheck.TabIndex = 11;
            inventoryOilCheck.TextAlign = ContentAlignment.MiddleRight;
            inventoryOilCheck.UseVisualStyleBackColor = true;
            // 
            // inventoryInputPopUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 535);
            Controls.Add(inventoryOilCheck);
            Controls.Add(inventoryTowelCheck);
            Controls.Add(inventoryBedSheetCheck);
            Controls.Add(inventoryBedSheetLabel);
            Controls.Add(inventoryTowelLabel);
            Controls.Add(inventoryEnterBtn);
            Controls.Add(inventoryCancelBtn);
            Controls.Add(inventoryCalendar);
            Controls.Add(inventoryOilLabel);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "inventoryInputPopUp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label inventoryOilLabel;
        private MonthCalendar inventoryCalendar;
        private Button inventoryCancelBtn;
        private Button inventoryEnterBtn;
        private Label inventoryTowelLabel;
        private Label inventoryBedSheetLabel;
        private CheckBox inventoryBedSheetCheck;
        private CheckBox inventoryTowelCheck;
        private CheckBox inventoryOilCheck;
    }
}