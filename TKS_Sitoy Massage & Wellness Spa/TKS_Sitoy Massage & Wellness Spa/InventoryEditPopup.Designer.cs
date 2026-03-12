namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class InventoryEditPopup
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
            inventoryEditYesBtn = new Button();
            inventoryEditNoBtn = new Button();
            inventoryOilEditCheck = new CheckBox();
            inventoryTowelEditCheck = new CheckBox();
            inventoryBedSheetEditCheck = new CheckBox();
            inventoryBedSheetEditLabel = new Label();
            inventoryTowelEditLabel = new Label();
            inventoryOilEditLabel = new Label();
            SuspendLayout();
            // 
            // inventoryEditYesBtn
            // 
            inventoryEditYesBtn.BackColor = Color.YellowGreen;
            inventoryEditYesBtn.Location = new Point(184, 155);
            inventoryEditYesBtn.Name = "inventoryEditYesBtn";
            inventoryEditYesBtn.Size = new Size(101, 38);
            inventoryEditYesBtn.TabIndex = 9;
            inventoryEditYesBtn.Text = "Yes";
            inventoryEditYesBtn.UseVisualStyleBackColor = false;
            // 
            // inventoryEditNoBtn
            // 
            inventoryEditNoBtn.BackColor = Color.IndianRed;
            inventoryEditNoBtn.Location = new Point(42, 155);
            inventoryEditNoBtn.Name = "inventoryEditNoBtn";
            inventoryEditNoBtn.Size = new Size(101, 38);
            inventoryEditNoBtn.TabIndex = 8;
            inventoryEditNoBtn.Text = "No";
            inventoryEditNoBtn.UseVisualStyleBackColor = false;
            // 
            // inventoryOilEditCheck
            // 
            inventoryOilEditCheck.Appearance = Appearance.Button;
            inventoryOilEditCheck.Location = new Point(180, 44);
            inventoryOilEditCheck.Name = "inventoryOilEditCheck";
            inventoryOilEditCheck.Size = new Size(20, 20);
            inventoryOilEditCheck.TabIndex = 17;
            inventoryOilEditCheck.TextAlign = ContentAlignment.MiddleRight;
            inventoryOilEditCheck.UseVisualStyleBackColor = true;
            // 
            // inventoryTowelEditCheck
            // 
            inventoryTowelEditCheck.Appearance = Appearance.Button;
            inventoryTowelEditCheck.Location = new Point(180, 78);
            inventoryTowelEditCheck.Name = "inventoryTowelEditCheck";
            inventoryTowelEditCheck.Size = new Size(20, 20);
            inventoryTowelEditCheck.TabIndex = 16;
            inventoryTowelEditCheck.TextAlign = ContentAlignment.MiddleRight;
            inventoryTowelEditCheck.UseVisualStyleBackColor = true;
            // 
            // inventoryBedSheetEditCheck
            // 
            inventoryBedSheetEditCheck.Appearance = Appearance.Button;
            inventoryBedSheetEditCheck.Location = new Point(180, 114);
            inventoryBedSheetEditCheck.Name = "inventoryBedSheetEditCheck";
            inventoryBedSheetEditCheck.Size = new Size(20, 20);
            inventoryBedSheetEditCheck.TabIndex = 15;
            inventoryBedSheetEditCheck.TextAlign = ContentAlignment.MiddleRight;
            inventoryBedSheetEditCheck.UseVisualStyleBackColor = true;
            // 
            // inventoryBedSheetEditLabel
            // 
            inventoryBedSheetEditLabel.AutoSize = true;
            inventoryBedSheetEditLabel.Font = new Font("Segoe UI", 10F);
            inventoryBedSheetEditLabel.Location = new Point(97, 113);
            inventoryBedSheetEditLabel.Margin = new Padding(0);
            inventoryBedSheetEditLabel.Name = "inventoryBedSheetEditLabel";
            inventoryBedSheetEditLabel.Size = new Size(73, 19);
            inventoryBedSheetEditLabel.TabIndex = 14;
            inventoryBedSheetEditLabel.Text = "Bed Sheet:";
            inventoryBedSheetEditLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inventoryTowelEditLabel
            // 
            inventoryTowelEditLabel.AutoSize = true;
            inventoryTowelEditLabel.Font = new Font("Segoe UI", 10F);
            inventoryTowelEditLabel.Location = new Point(97, 79);
            inventoryTowelEditLabel.Margin = new Padding(0);
            inventoryTowelEditLabel.Name = "inventoryTowelEditLabel";
            inventoryTowelEditLabel.Size = new Size(46, 19);
            inventoryTowelEditLabel.TabIndex = 13;
            inventoryTowelEditLabel.Text = "Towel:";
            inventoryTowelEditLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inventoryOilEditLabel
            // 
            inventoryOilEditLabel.AutoSize = true;
            inventoryOilEditLabel.Font = new Font("Segoe UI", 10F);
            inventoryOilEditLabel.Location = new Point(97, 43);
            inventoryOilEditLabel.Margin = new Padding(0);
            inventoryOilEditLabel.Name = "inventoryOilEditLabel";
            inventoryOilEditLabel.Size = new Size(29, 19);
            inventoryOilEditLabel.TabIndex = 12;
            inventoryOilEditLabel.Text = "Oil:";
            inventoryOilEditLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InventoryEditPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 235);
            Controls.Add(inventoryOilEditCheck);
            Controls.Add(inventoryTowelEditCheck);
            Controls.Add(inventoryBedSheetEditCheck);
            Controls.Add(inventoryBedSheetEditLabel);
            Controls.Add(inventoryTowelEditLabel);
            Controls.Add(inventoryOilEditLabel);
            Controls.Add(inventoryEditYesBtn);
            Controls.Add(inventoryEditNoBtn);
            Name = "InventoryEditPopup";
            Text = "inventory Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button inventoryEditYesBtn;
        private Button inventoryEditNoBtn;
        private CheckBox inventoryOilEditCheck;
        private CheckBox inventoryTowelEditCheck;
        private CheckBox inventoryBedSheetEditCheck;
        private Label inventoryBedSheetEditLabel;
        private Label inventoryTowelEditLabel;
        private Label inventoryOilEditLabel;
    }
}