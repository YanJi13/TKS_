namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class InventoryDeletePopup
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
            inventoryDeleteNoBtn = new Button();
            inventoryDeleteYesBtn = new Button();
            inventoryDeleteLabel = new Label();
            SuspendLayout();
            // 
            // inventoryDeleteNoBtn
            // 
            inventoryDeleteNoBtn.BackColor = Color.FromArgb(191, 97, 106);
            inventoryDeleteNoBtn.FlatStyle = FlatStyle.Popup;
            inventoryDeleteNoBtn.ForeColor = SystemColors.ControlText;
            inventoryDeleteNoBtn.Location = new Point(36, 83);
            inventoryDeleteNoBtn.Name = "inventoryDeleteNoBtn";
            inventoryDeleteNoBtn.Size = new Size(101, 38);
            inventoryDeleteNoBtn.TabIndex = 0;
            inventoryDeleteNoBtn.Text = "No";
            inventoryDeleteNoBtn.UseVisualStyleBackColor = false;
            // 
            // inventoryDeleteYesBtn
            // 
            inventoryDeleteYesBtn.BackColor = Color.FromArgb(145, 188, 143);
            inventoryDeleteYesBtn.FlatStyle = FlatStyle.Popup;
            inventoryDeleteYesBtn.Location = new Point(178, 83);
            inventoryDeleteYesBtn.Name = "inventoryDeleteYesBtn";
            inventoryDeleteYesBtn.Size = new Size(101, 38);
            inventoryDeleteYesBtn.TabIndex = 1;
            inventoryDeleteYesBtn.Text = "Yes";
            inventoryDeleteYesBtn.UseVisualStyleBackColor = false;
            // 
            // inventoryDeleteLabel
            // 
            inventoryDeleteLabel.AutoSize = true;
            inventoryDeleteLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventoryDeleteLabel.ForeColor = Color.FromArgb(236, 239, 244);
            inventoryDeleteLabel.Location = new Point(84, 41);
            inventoryDeleteLabel.Name = "inventoryDeleteLabel";
            inventoryDeleteLabel.Size = new Size(142, 21);
            inventoryDeleteLabel.TabIndex = 2;
            inventoryDeleteLabel.Text = "Confirm Deletion?";
            // 
            // InventoryDeletePopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 79, 99);
            ClientSize = new Size(310, 182);
            Controls.Add(inventoryDeleteLabel);
            Controls.Add(inventoryDeleteYesBtn);
            Controls.Add(inventoryDeleteNoBtn);
            Name = "InventoryDeletePopup";
            Text = "Delete Confirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inventoryDeleteNoBtn;
        private Button inventoryDeleteYesBtn;
        private Label inventoryDeleteLabel;
    }
}