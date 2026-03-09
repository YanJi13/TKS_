namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            attendancePanel = new Panel();
            attendancePanelSearchBtn = new Button();
            attendancePanelSearchBar = new TextBox();
            attendancePanelInputBtn = new Button();
            attendancePanelGridView = new DataGridView();
            attendanceSideBtn = new Button();
            appointmentsSideBtn = new Button();
            inventorySideBtn = new Button();
            miscSideBtn = new Button();
            sidebarPanel = new Panel();
            appointmentsPanel = new Panel();
            appointmentsPanelSearchBtn = new Button();
            appointmentsPanelSearchBar = new TextBox();
            appointmentsPanelInputBtn = new Button();
            appointmentsPanelGridView = new DataGridView();
            inventoryPanel = new Panel();
            inventoryPanelSearchBtn = new Button();
            inventoryPanelSearchBar = new TextBox();
            inventoryPanelInputBtn = new Button();
            inventoryPanelGridView = new DataGridView();
            miscellaneousPanel = new Panel();
            miscellaneousPanelSearchBtn = new Button();
            miscellaneousPanelSearchBar = new TextBox();
            miscellaneousPanelInputBtn = new Button();
            miscellaneousPanelGridView = new DataGridView();
            attendancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendancePanelGridView).BeginInit();
            sidebarPanel.SuspendLayout();
            appointmentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsPanelGridView).BeginInit();
            inventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryPanelGridView).BeginInit();
            miscellaneousPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)miscellaneousPanelGridView).BeginInit();
            SuspendLayout();
            // 
            // attendancePanel
            // 
            attendancePanel.Controls.Add(attendancePanelSearchBtn);
            attendancePanel.Controls.Add(attendancePanelSearchBar);
            attendancePanel.Controls.Add(attendancePanelInputBtn);
            attendancePanel.Controls.Add(attendancePanelGridView);
            attendancePanel.Dock = DockStyle.Fill;
            attendancePanel.Location = new Point(171, 0);
            attendancePanel.Name = "attendancePanel";
            attendancePanel.Size = new Size(732, 520);
            attendancePanel.TabIndex = 9;
            attendancePanel.Paint += panel2_Paint_1;
            // 
            // attendancePanelSearchBtn
            // 
            attendancePanelSearchBtn.Location = new Point(533, 75);
            attendancePanelSearchBtn.Name = "attendancePanelSearchBtn";
            attendancePanelSearchBtn.Size = new Size(107, 23);
            attendancePanelSearchBtn.TabIndex = 6;
            attendancePanelSearchBtn.Text = "Search";
            attendancePanelSearchBtn.UseVisualStyleBackColor = true;
            // 
            // attendancePanelSearchBar
            // 
            attendancePanelSearchBar.Location = new Point(122, 75);
            attendancePanelSearchBar.Name = "attendancePanelSearchBar";
            attendancePanelSearchBar.Size = new Size(405, 31);
            attendancePanelSearchBar.TabIndex = 5;
            attendancePanelSearchBar.TextChanged += textBox1_TextChanged_1;
            // 
            // attendancePanelInputBtn
            // 
            attendancePanelInputBtn.Location = new Point(9, 75);
            attendancePanelInputBtn.Name = "attendancePanelInputBtn";
            attendancePanelInputBtn.Size = new Size(107, 23);
            attendancePanelInputBtn.TabIndex = 4;
            attendancePanelInputBtn.Text = "Input";
            attendancePanelInputBtn.UseVisualStyleBackColor = true;
            attendancePanelInputBtn.Click += button5_Click;
            // 
            // attendancePanelGridView
            // 
            attendancePanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendancePanelGridView.Location = new Point(9, 104);
            attendancePanelGridView.Name = "attendancePanelGridView";
            attendancePanelGridView.RowHeadersWidth = 62;
            attendancePanelGridView.Size = new Size(265, 404);
            attendancePanelGridView.TabIndex = 0;
            // 
            // attendanceSideBtn
            // 
            attendanceSideBtn.Location = new Point(21, 118);
            attendanceSideBtn.Name = "attendanceSideBtn";
            attendanceSideBtn.Size = new Size(129, 45);
            attendanceSideBtn.TabIndex = 0;
            attendanceSideBtn.Text = "Attendance";
            attendanceSideBtn.UseVisualStyleBackColor = true;
            attendanceSideBtn.Click += button1_Click;
            // 
            // appointmentsSideBtn
            // 
            appointmentsSideBtn.Location = new Point(21, 178);
            appointmentsSideBtn.Name = "appointmentsSideBtn";
            appointmentsSideBtn.Size = new Size(129, 45);
            appointmentsSideBtn.TabIndex = 1;
            appointmentsSideBtn.Text = "Appointments";
            appointmentsSideBtn.UseVisualStyleBackColor = true;
            appointmentsSideBtn.Click += button2_Click;
            // 
            // inventorySideBtn
            // 
            inventorySideBtn.Location = new Point(21, 238);
            inventorySideBtn.Name = "inventorySideBtn";
            inventorySideBtn.Size = new Size(129, 45);
            inventorySideBtn.TabIndex = 2;
            inventorySideBtn.Text = "Inventory";
            inventorySideBtn.UseVisualStyleBackColor = true;
            // 
            // miscSideBtn
            // 
            miscSideBtn.Location = new Point(21, 298);
            miscSideBtn.Name = "miscSideBtn";
            miscSideBtn.Size = new Size(129, 45);
            miscSideBtn.TabIndex = 3;
            miscSideBtn.Text = "Miscellaneous";
            miscSideBtn.UseVisualStyleBackColor = true;
            // 
            // sidebarPanel
            // 
            sidebarPanel.Controls.Add(attendanceSideBtn);
            sidebarPanel.Controls.Add(appointmentsSideBtn);
            sidebarPanel.Controls.Add(inventorySideBtn);
            sidebarPanel.Controls.Add(miscSideBtn);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(171, 520);
            sidebarPanel.TabIndex = 0;
            // 
            // appointmentsPanel
            // 
            appointmentsPanel.Controls.Add(appointmentsPanelSearchBtn);
            appointmentsPanel.Controls.Add(appointmentsPanelSearchBar);
            appointmentsPanel.Controls.Add(appointmentsPanelInputBtn);
            appointmentsPanel.Controls.Add(appointmentsPanelGridView);
            appointmentsPanel.Dock = DockStyle.Fill;
            appointmentsPanel.Location = new Point(171, 0);
            appointmentsPanel.Name = "appointmentsPanel";
            appointmentsPanel.Size = new Size(732, 520);
            appointmentsPanel.TabIndex = 10;
            // 
            // appointmentsPanelSearchBtn
            // 
            appointmentsPanelSearchBtn.Location = new Point(533, 75);
            appointmentsPanelSearchBtn.Name = "appointmentsPanelSearchBtn";
            appointmentsPanelSearchBtn.Size = new Size(107, 23);
            appointmentsPanelSearchBtn.TabIndex = 6;
            appointmentsPanelSearchBtn.Text = "Search";
            appointmentsPanelSearchBtn.UseVisualStyleBackColor = true;
            // 
            // appointmentsPanelSearchBar
            // 
            appointmentsPanelSearchBar.Location = new Point(122, 75);
            appointmentsPanelSearchBar.Name = "appointmentsPanelSearchBar";
            appointmentsPanelSearchBar.Size = new Size(405, 31);
            appointmentsPanelSearchBar.TabIndex = 5;
            // 
            // appointmentsPanelInputBtn
            // 
            appointmentsPanelInputBtn.Location = new Point(9, 75);
            appointmentsPanelInputBtn.Name = "appointmentsPanelInputBtn";
            appointmentsPanelInputBtn.Size = new Size(107, 23);
            appointmentsPanelInputBtn.TabIndex = 4;
            appointmentsPanelInputBtn.Text = "Input";
            appointmentsPanelInputBtn.UseVisualStyleBackColor = true;
            // 
            // appointmentsPanelGridView
            // 
            appointmentsPanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsPanelGridView.Location = new Point(9, 104);
            appointmentsPanelGridView.Name = "appointmentsPanelGridView";
            appointmentsPanelGridView.RowHeadersWidth = 62;
            appointmentsPanelGridView.Size = new Size(712, 404);
            appointmentsPanelGridView.TabIndex = 0;
            // 
            // inventoryPanel
            // 
            inventoryPanel.Controls.Add(inventoryPanelSearchBtn);
            inventoryPanel.Controls.Add(inventoryPanelSearchBar);
            inventoryPanel.Controls.Add(inventoryPanelInputBtn);
            inventoryPanel.Controls.Add(inventoryPanelGridView);
            inventoryPanel.Dock = DockStyle.Fill;
            inventoryPanel.Location = new Point(171, 0);
            inventoryPanel.Name = "inventoryPanel";
            inventoryPanel.Size = new Size(732, 520);
            inventoryPanel.TabIndex = 11;
            // 
            // inventoryPanelSearchBtn
            // 
            inventoryPanelSearchBtn.Location = new Point(533, 75);
            inventoryPanelSearchBtn.Name = "inventoryPanelSearchBtn";
            inventoryPanelSearchBtn.Size = new Size(107, 23);
            inventoryPanelSearchBtn.TabIndex = 6;
            inventoryPanelSearchBtn.Text = "Search";
            inventoryPanelSearchBtn.UseVisualStyleBackColor = true;
            // 
            // inventoryPanelSearchBar
            // 
            inventoryPanelSearchBar.Location = new Point(122, 75);
            inventoryPanelSearchBar.Name = "inventoryPanelSearchBar";
            inventoryPanelSearchBar.Size = new Size(405, 31);
            inventoryPanelSearchBar.TabIndex = 5;
            // 
            // inventoryPanelInputBtn
            // 
            inventoryPanelInputBtn.Location = new Point(9, 75);
            inventoryPanelInputBtn.Name = "inventoryPanelInputBtn";
            inventoryPanelInputBtn.Size = new Size(107, 23);
            inventoryPanelInputBtn.TabIndex = 4;
            inventoryPanelInputBtn.Text = "Input";
            inventoryPanelInputBtn.UseVisualStyleBackColor = true;
            // 
            // inventoryPanelGridView
            // 
            inventoryPanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryPanelGridView.Location = new Point(9, 104);
            inventoryPanelGridView.Name = "inventoryPanelGridView";
            inventoryPanelGridView.RowHeadersWidth = 62;
            inventoryPanelGridView.Size = new Size(712, 404);
            inventoryPanelGridView.TabIndex = 0;
            // 
            // miscellaneousPanel
            // 
            miscellaneousPanel.Controls.Add(miscellaneousPanelSearchBtn);
            miscellaneousPanel.Controls.Add(miscellaneousPanelSearchBar);
            miscellaneousPanel.Controls.Add(miscellaneousPanelInputBtn);
            miscellaneousPanel.Controls.Add(miscellaneousPanelGridView);
            miscellaneousPanel.Dock = DockStyle.Fill;
            miscellaneousPanel.Location = new Point(171, 0);
            miscellaneousPanel.Name = "miscellaneousPanel";
            miscellaneousPanel.Size = new Size(732, 520);
            miscellaneousPanel.TabIndex = 12;
            // 
            // miscellaneousPanelSearchBtn
            // 
            miscellaneousPanelSearchBtn.Location = new Point(533, 75);
            miscellaneousPanelSearchBtn.Name = "miscellaneousPanelSearchBtn";
            miscellaneousPanelSearchBtn.Size = new Size(107, 23);
            miscellaneousPanelSearchBtn.TabIndex = 6;
            miscellaneousPanelSearchBtn.Text = "Search";
            miscellaneousPanelSearchBtn.UseVisualStyleBackColor = true;
            // 
            // miscellaneousPanelSearchBar
            // 
            miscellaneousPanelSearchBar.Location = new Point(122, 75);
            miscellaneousPanelSearchBar.Name = "miscellaneousPanelSearchBar";
            miscellaneousPanelSearchBar.Size = new Size(405, 31);
            miscellaneousPanelSearchBar.TabIndex = 5;
            // 
            // miscellaneousPanelInputBtn
            // 
            miscellaneousPanelInputBtn.Location = new Point(9, 75);
            miscellaneousPanelInputBtn.Name = "miscellaneousPanelInputBtn";
            miscellaneousPanelInputBtn.Size = new Size(107, 23);
            miscellaneousPanelInputBtn.TabIndex = 4;
            miscellaneousPanelInputBtn.Text = "Input";
            miscellaneousPanelInputBtn.UseVisualStyleBackColor = true;
            // 
            // miscellaneousPanelGridView
            // 
            miscellaneousPanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miscellaneousPanelGridView.Location = new Point(9, 104);
            miscellaneousPanelGridView.Name = "miscellaneousPanelGridView";
            miscellaneousPanelGridView.RowHeadersWidth = 62;
            miscellaneousPanelGridView.Size = new Size(712, 404);
            miscellaneousPanelGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(903, 520);
            Controls.Add(appointmentsPanel);
            Controls.Add(attendancePanel);
            Controls.Add(miscellaneousPanel);
            Controls.Add(inventoryPanel);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            attendancePanel.ResumeLayout(false);
            attendancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)attendancePanelGridView).EndInit();
            sidebarPanel.ResumeLayout(false);
            appointmentsPanel.ResumeLayout(false);
            appointmentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsPanelGridView).EndInit();
            inventoryPanel.ResumeLayout(false);
            inventoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryPanelGridView).EndInit();
            miscellaneousPanel.ResumeLayout(false);
            miscellaneousPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)miscellaneousPanelGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private Panel attendancePanel;
        private Label miscLabel;
        private Button attendancePanelSearchBtn;
        private TextBox attendancePanelSearchBar;
        private Button attendancePanelInputBtn;
        private DataGridView attendancePanelGridView;
        private Button attendanceSideBtn;
        private Button appointmentsSideBtn;
        private Button inventorySideBtn;
        private Button miscSideBtn;
        private Panel appointmentsPanel;
        private Button appointmentsPanelSearchBtn;
        private TextBox appointmentsPanelSearchBar;
        private Button appointmentsPanelInputBtn;
        private DataGridView appointmentsPanelGridView;
        private Panel inventoryPanel;
        private Button inventoryPanelSearchBtn;
        private TextBox inventoryPanelSearchBar;
        private Button inventoryPanelInputBtn;
        private DataGridView inventoryPanelGridView;
        private Panel miscellaneousPanel;
        private Button miscellaneousPanelSearchBtn;
        private TextBox miscellaneousPanelSearchBar;
        private Button miscellaneousPanelInputBtn;
        private DataGridView miscellaneousPanelGridView;
    }
}
