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
            attendancePanelInputBtn = new Button();
            attendancePanelSearchBar = new TextBox();
            attendancePanelGridView = new DataGridView();
            attendanceDateHeader = new DataGridViewTextBoxColumn();
            attendanceNameHeader = new DataGridViewTextBoxColumn();
            attendanceDeleteBtn = new DataGridViewButtonColumn();
            attendanceEditBtn = new DataGridViewButtonColumn();
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
            appointmentsDateHeader = new DataGridViewTextBoxColumn();
            appointmentsNameHeader = new DataGridViewTextBoxColumn();
            appointmentsServiceHeader = new DataGridViewTextBoxColumn();
            appointmentsCommissionHeader = new DataGridViewTextBoxColumn();
            appointmentsDeleteBtn = new DataGridViewButtonColumn();
            appointmentsEditBtn = new DataGridViewButtonColumn();
            inventoryPanel = new Panel();
            inventoryPanelSearchBtn = new Button();
            inventoryPanelSearchBar = new TextBox();
            inventoryPanelInputBtn = new Button();
            inventoryPanelGridView = new DataGridView();
            inventoryDateHeader = new DataGridViewTextBoxColumn();
            inventoryOilHeader = new DataGridViewTextBoxColumn();
            inventoryTowelHeader = new DataGridViewTextBoxColumn();
            inventoryBedSheetHeader = new DataGridViewTextBoxColumn();
            inventoryDeleteBtn = new DataGridViewButtonColumn();
            inventoryEditBtn = new DataGridViewButtonColumn();
            miscellaneousPanel = new Panel();
            miscellaneousPanelSearchBtn = new Button();
            miscellaneousPanelSearchBar = new TextBox();
            miscellaneousPanelInputBtn = new Button();
            miscellaneousPanelGridView = new DataGridView();
            miscellaneousDateHeader = new DataGridViewTextBoxColumn();
            miscellaneousAmount = new DataGridViewTextBoxColumn();
            miscellaneousNoteHeader = new DataGridViewTextBoxColumn();
            miscellaneousDeleteBtn = new DataGridViewButtonColumn();
            miscellaneousEditBtn = new DataGridViewButtonColumn();
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
            attendancePanel.Controls.Add(attendancePanelInputBtn);
            attendancePanel.Controls.Add(attendancePanelSearchBar);
            attendancePanel.Controls.Add(attendancePanelGridView);
            attendancePanel.Dock = DockStyle.Fill;
            attendancePanel.Location = new Point(171, 0);
            attendancePanel.Name = "attendancePanel";
            attendancePanel.Size = new Size(733, 521);
            attendancePanel.TabIndex = 9;
            attendancePanel.Paint += attendancePanel_Paint;
            // 
            // attendancePanelSearchBtn
            // 
            attendancePanelSearchBtn.Location = new Point(364, 60);
            attendancePanelSearchBtn.Name = "attendancePanelSearchBtn";
            attendancePanelSearchBtn.Size = new Size(107, 23);
            attendancePanelSearchBtn.TabIndex = 6;
            attendancePanelSearchBtn.Text = "Search";
            attendancePanelSearchBtn.UseVisualStyleBackColor = true;
            // 
            // attendancePanelInputBtn
            // 
            attendancePanelInputBtn.Location = new Point(9, 60);
            attendancePanelInputBtn.Name = "attendancePanelInputBtn";
            attendancePanelInputBtn.Size = new Size(107, 23);
            attendancePanelInputBtn.TabIndex = 4;
            attendancePanelInputBtn.Text = "Input";
            attendancePanelInputBtn.UseVisualStyleBackColor = true;
            attendancePanelInputBtn.Click += showAttendancePopup;
            // 
            // attendancePanelSearchBar
            // 
            attendancePanelSearchBar.Location = new Point(122, 60);
            attendancePanelSearchBar.Name = "attendancePanelSearchBar";
            attendancePanelSearchBar.Size = new Size(236, 31);
            attendancePanelSearchBar.TabIndex = 5;
            // 
            // attendancePanelGridView
            // 
            attendancePanelGridView.AllowUserToAddRows = false;
            attendancePanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendancePanelGridView.Columns.AddRange(new DataGridViewColumn[] { attendanceDateHeader, attendanceNameHeader, attendanceDeleteBtn, attendanceEditBtn });
            attendancePanelGridView.Location = new Point(9, 104);
            attendancePanelGridView.Name = "attendancePanelGridView";
            attendancePanelGridView.RowHeadersWidth = 30;
            attendancePanelGridView.Size = new Size(352, 404);
            attendancePanelGridView.TabIndex = 0;
            // 
            // attendanceDateHeader
            // 
            attendanceDateHeader.HeaderText = "Date";
            attendanceDateHeader.MinimumWidth = 8;
            attendanceDateHeader.Name = "attendanceDateHeader";
            attendanceDateHeader.Width = 150;
            // 
            // attendanceNameHeader
            // 
            attendanceNameHeader.HeaderText = "Name";
            attendanceNameHeader.MinimumWidth = 8;
            attendanceNameHeader.Name = "attendanceNameHeader";
            attendanceNameHeader.Width = 150;
            // 
            // attendanceDeleteBtn
            // 
            attendanceDeleteBtn.HeaderText = "Delete";
            attendanceDeleteBtn.MinimumWidth = 8;
            attendanceDeleteBtn.Name = "attendanceDeleteBtn";
            attendanceDeleteBtn.Resizable = DataGridViewTriState.True;
            attendanceDeleteBtn.SortMode = DataGridViewColumnSortMode.Automatic;
            attendanceDeleteBtn.Text = "Delete";
            attendanceDeleteBtn.UseColumnTextForButtonValue = true;
            attendanceDeleteBtn.Width = 60;
            // 
            // attendanceEditBtn
            // 
            attendanceEditBtn.HeaderText = "Edit";
            attendanceEditBtn.MinimumWidth = 8;
            attendanceEditBtn.Name = "attendanceEditBtn";
            attendanceEditBtn.Text = "Edit";
            attendanceEditBtn.UseColumnTextForButtonValue = true;
            attendanceEditBtn.Width = 60;
            // 
            // attendanceSideBtn
            // 
            attendanceSideBtn.Location = new Point(21, 118);
            attendanceSideBtn.Name = "attendanceSideBtn";
            attendanceSideBtn.Size = new Size(129, 45);
            attendanceSideBtn.TabIndex = 0;
            attendanceSideBtn.Text = "Attendance";
            attendanceSideBtn.UseVisualStyleBackColor = true;
            attendanceSideBtn.Click += showAttendancePanel;
            // 
            // appointmentsSideBtn
            // 
            appointmentsSideBtn.Location = new Point(21, 178);
            appointmentsSideBtn.Name = "appointmentsSideBtn";
            appointmentsSideBtn.Size = new Size(129, 45);
            appointmentsSideBtn.TabIndex = 1;
            appointmentsSideBtn.Text = "Appointments";
            appointmentsSideBtn.UseVisualStyleBackColor = true;
            appointmentsSideBtn.Click += showAppointmentsPanel;
            // 
            // inventorySideBtn
            // 
            inventorySideBtn.Location = new Point(21, 238);
            inventorySideBtn.Name = "inventorySideBtn";
            inventorySideBtn.Size = new Size(129, 45);
            inventorySideBtn.TabIndex = 2;
            inventorySideBtn.Text = "Inventory";
            inventorySideBtn.UseVisualStyleBackColor = true;
            inventorySideBtn.Click += showInventoryPanel;
            // 
            // miscSideBtn
            // 
            miscSideBtn.Location = new Point(21, 298);
            miscSideBtn.Name = "miscSideBtn";
            miscSideBtn.Size = new Size(129, 45);
            miscSideBtn.TabIndex = 3;
            miscSideBtn.Text = "Miscellaneous";
            miscSideBtn.UseVisualStyleBackColor = true;
            miscSideBtn.Click += showMiscPanel;
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
            sidebarPanel.Size = new Size(171, 521);
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
            appointmentsPanel.Size = new Size(733, 521);
            appointmentsPanel.TabIndex = 10;
            // 
            // appointmentsPanelSearchBtn
            // 
            appointmentsPanelSearchBtn.Location = new Point(364, 60);
            appointmentsPanelSearchBtn.Name = "appointmentsPanelSearchBtn";
            appointmentsPanelSearchBtn.Size = new Size(107, 23);
            appointmentsPanelSearchBtn.TabIndex = 6;
            appointmentsPanelSearchBtn.Text = "Search";
            appointmentsPanelSearchBtn.UseVisualStyleBackColor = true;
            // 
            // appointmentsPanelSearchBar
            // 
            appointmentsPanelSearchBar.Location = new Point(122, 60);
            appointmentsPanelSearchBar.Name = "appointmentsPanelSearchBar";
            appointmentsPanelSearchBar.Size = new Size(236, 31);
            appointmentsPanelSearchBar.TabIndex = 5;
            // 
            // appointmentsPanelInputBtn
            // 
            appointmentsPanelInputBtn.Location = new Point(9, 60);
            appointmentsPanelInputBtn.Name = "appointmentsPanelInputBtn";
            appointmentsPanelInputBtn.Size = new Size(107, 23);
            appointmentsPanelInputBtn.TabIndex = 4;
            appointmentsPanelInputBtn.Text = "Input";
            appointmentsPanelInputBtn.UseVisualStyleBackColor = true;
            appointmentsPanelInputBtn.Click += showAppointmentsPopup;
            // 
            // appointmentsPanelGridView
            // 
            appointmentsPanelGridView.AllowUserToAddRows = false;
            appointmentsPanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsPanelGridView.Columns.AddRange(new DataGridViewColumn[] { appointmentsDateHeader, appointmentsNameHeader, appointmentsServiceHeader, appointmentsCommissionHeader, appointmentsDeleteBtn, appointmentsEditBtn });
            appointmentsPanelGridView.Location = new Point(9, 104);
            appointmentsPanelGridView.Name = "appointmentsPanelGridView";
            appointmentsPanelGridView.RowHeadersWidth = 30;
            appointmentsPanelGridView.Size = new Size(632, 404);
            appointmentsPanelGridView.TabIndex = 0;
            // 
            // appointmentsDateHeader
            // 
            appointmentsDateHeader.HeaderText = "Date";
            appointmentsDateHeader.MinimumWidth = 8;
            appointmentsDateHeader.Name = "appointmentsDateHeader";
            appointmentsDateHeader.Width = 150;
            // 
            // appointmentsNameHeader
            // 
            appointmentsNameHeader.HeaderText = "Name";
            appointmentsNameHeader.MinimumWidth = 8;
            appointmentsNameHeader.Name = "appointmentsNameHeader";
            appointmentsNameHeader.Width = 150;
            // 
            // appointmentsServiceHeader
            // 
            appointmentsServiceHeader.HeaderText = "Service";
            appointmentsServiceHeader.MinimumWidth = 8;
            appointmentsServiceHeader.Name = "appointmentsServiceHeader";
            appointmentsServiceHeader.Width = 150;
            // 
            // appointmentsCommissionHeader
            // 
            appointmentsCommissionHeader.HeaderText = "Commission";
            appointmentsCommissionHeader.MinimumWidth = 8;
            appointmentsCommissionHeader.Name = "appointmentsCommissionHeader";
            appointmentsCommissionHeader.Width = 150;
            // 
            // appointmentsDeleteBtn
            // 
            appointmentsDeleteBtn.HeaderText = "Delete";
            appointmentsDeleteBtn.MinimumWidth = 8;
            appointmentsDeleteBtn.Name = "appointmentsDeleteBtn";
            appointmentsDeleteBtn.Text = "Delete";
            appointmentsDeleteBtn.UseColumnTextForButtonValue = true;
            appointmentsDeleteBtn.Width = 150;
            // 
            // appointmentsEditBtn
            // 
            appointmentsEditBtn.HeaderText = "Edit";
            appointmentsEditBtn.MinimumWidth = 8;
            appointmentsEditBtn.Name = "appointmentsEditBtn";
            appointmentsEditBtn.Text = "Edit";
            appointmentsEditBtn.UseColumnTextForButtonValue = true;
            appointmentsEditBtn.Width = 150;
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
            inventoryPanel.Size = new Size(733, 521);
            inventoryPanel.TabIndex = 11;
            // 
            // inventoryPanelSearchBtn
            // 
            inventoryPanelSearchBtn.Location = new Point(364, 60);
            inventoryPanelSearchBtn.Name = "inventoryPanelSearchBtn";
            inventoryPanelSearchBtn.Size = new Size(107, 23);
            inventoryPanelSearchBtn.TabIndex = 6;
            inventoryPanelSearchBtn.Text = "Search";
            inventoryPanelSearchBtn.UseVisualStyleBackColor = true;
            // 
            // inventoryPanelSearchBar
            // 
            inventoryPanelSearchBar.Location = new Point(122, 60);
            inventoryPanelSearchBar.Name = "inventoryPanelSearchBar";
            inventoryPanelSearchBar.Size = new Size(236, 31);
            inventoryPanelSearchBar.TabIndex = 5;
            // 
            // inventoryPanelInputBtn
            // 
            inventoryPanelInputBtn.Location = new Point(9, 60);
            inventoryPanelInputBtn.Name = "inventoryPanelInputBtn";
            inventoryPanelInputBtn.Size = new Size(107, 23);
            inventoryPanelInputBtn.TabIndex = 4;
            inventoryPanelInputBtn.Text = "Input";
            inventoryPanelInputBtn.UseVisualStyleBackColor = true;
            inventoryPanelInputBtn.Click += showInventoryPopup;
            // 
            // inventoryPanelGridView
            // 
            inventoryPanelGridView.AllowUserToAddRows = false;
            inventoryPanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryPanelGridView.Columns.AddRange(new DataGridViewColumn[] { inventoryDateHeader, inventoryOilHeader, inventoryTowelHeader, inventoryBedSheetHeader, inventoryDeleteBtn, inventoryEditBtn });
            inventoryPanelGridView.Location = new Point(9, 104);
            inventoryPanelGridView.Name = "inventoryPanelGridView";
            inventoryPanelGridView.RowHeadersWidth = 30;
            inventoryPanelGridView.Size = new Size(632, 404);
            inventoryPanelGridView.TabIndex = 0;
            // 
            // inventoryDateHeader
            // 
            inventoryDateHeader.HeaderText = "Date";
            inventoryDateHeader.MinimumWidth = 8;
            inventoryDateHeader.Name = "inventoryDateHeader";
            inventoryDateHeader.Width = 150;
            // 
            // inventoryOilHeader
            // 
            inventoryOilHeader.HeaderText = "Oil";
            inventoryOilHeader.MinimumWidth = 8;
            inventoryOilHeader.Name = "inventoryOilHeader";
            inventoryOilHeader.Width = 150;
            // 
            // inventoryTowelHeader
            // 
            inventoryTowelHeader.HeaderText = "Towel";
            inventoryTowelHeader.MinimumWidth = 8;
            inventoryTowelHeader.Name = "inventoryTowelHeader";
            inventoryTowelHeader.Width = 150;
            // 
            // inventoryBedSheetHeader
            // 
            inventoryBedSheetHeader.HeaderText = "Bed Sheet";
            inventoryBedSheetHeader.MinimumWidth = 8;
            inventoryBedSheetHeader.Name = "inventoryBedSheetHeader";
            inventoryBedSheetHeader.Width = 150;
            // 
            // inventoryDeleteBtn
            // 
            inventoryDeleteBtn.HeaderText = "Delete";
            inventoryDeleteBtn.MinimumWidth = 8;
            inventoryDeleteBtn.Name = "inventoryDeleteBtn";
            inventoryDeleteBtn.Width = 150;
            // 
            // inventoryEditBtn
            // 
            inventoryEditBtn.HeaderText = "Edit";
            inventoryEditBtn.MinimumWidth = 8;
            inventoryEditBtn.Name = "inventoryEditBtn";
            inventoryEditBtn.Width = 150;
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
            miscellaneousPanel.Size = new Size(733, 521);
            miscellaneousPanel.TabIndex = 12;
            // 
            // miscellaneousPanelSearchBtn
            // 
            miscellaneousPanelSearchBtn.Location = new Point(364, 60);
            miscellaneousPanelSearchBtn.Name = "miscellaneousPanelSearchBtn";
            miscellaneousPanelSearchBtn.Size = new Size(107, 23);
            miscellaneousPanelSearchBtn.TabIndex = 6;
            miscellaneousPanelSearchBtn.Text = "Search";
            miscellaneousPanelSearchBtn.UseVisualStyleBackColor = true;
            // 
            // miscellaneousPanelSearchBar
            // 
            miscellaneousPanelSearchBar.Location = new Point(122, 60);
            miscellaneousPanelSearchBar.Name = "miscellaneousPanelSearchBar";
            miscellaneousPanelSearchBar.Size = new Size(236, 31);
            miscellaneousPanelSearchBar.TabIndex = 5;
            // 
            // miscellaneousPanelInputBtn
            // 
            miscellaneousPanelInputBtn.Location = new Point(9, 60);
            miscellaneousPanelInputBtn.Name = "miscellaneousPanelInputBtn";
            miscellaneousPanelInputBtn.Size = new Size(107, 23);
            miscellaneousPanelInputBtn.TabIndex = 4;
            miscellaneousPanelInputBtn.Text = "Input";
            miscellaneousPanelInputBtn.UseVisualStyleBackColor = true;
            miscellaneousPanelInputBtn.Click += showMiscPopup;
            // 
            // miscellaneousPanelGridView
            // 
            miscellaneousPanelGridView.AllowUserToAddRows = false;
            miscellaneousPanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miscellaneousPanelGridView.Columns.AddRange(new DataGridViewColumn[] { miscellaneousDateHeader, miscellaneousAmount, miscellaneousNoteHeader, miscellaneousDeleteBtn, miscellaneousEditBtn });
            miscellaneousPanelGridView.Location = new Point(9, 104);
            miscellaneousPanelGridView.Name = "miscellaneousPanelGridView";
            miscellaneousPanelGridView.RowHeadersWidth = 30;
            miscellaneousPanelGridView.Size = new Size(532, 404);
            miscellaneousPanelGridView.TabIndex = 0;
            miscellaneousPanelGridView.CellContentClick += miscellaneousPanelGridView_CellContentClick;
            // 
            // miscellaneousDateHeader
            // 
            miscellaneousDateHeader.HeaderText = "Date";
            miscellaneousDateHeader.MinimumWidth = 8;
            miscellaneousDateHeader.Name = "miscellaneousDateHeader";
            miscellaneousDateHeader.Width = 150;
            // 
            // miscellaneousAmount
            // 
            miscellaneousAmount.HeaderText = "Misc Amount";
            miscellaneousAmount.MinimumWidth = 8;
            miscellaneousAmount.Name = "miscellaneousAmount";
            miscellaneousAmount.Width = 110;
            // 
            // miscellaneousNoteHeader
            // 
            miscellaneousNoteHeader.HeaderText = "Notes (optional)";
            miscellaneousNoteHeader.MinimumWidth = 8;
            miscellaneousNoteHeader.Name = "miscellaneousNoteHeader";
            miscellaneousNoteHeader.Width = 120;
            // 
            // miscellaneousDeleteBtn
            // 
            miscellaneousDeleteBtn.HeaderText = "Delete";
            miscellaneousDeleteBtn.MinimumWidth = 8;
            miscellaneousDeleteBtn.Name = "miscellaneousDeleteBtn";
            miscellaneousDeleteBtn.Text = "Delete";
            miscellaneousDeleteBtn.UseColumnTextForButtonValue = true;
            miscellaneousDeleteBtn.Width = 150;
            // 
            // miscellaneousEditBtn
            // 
            miscellaneousEditBtn.HeaderText = "Edit";
            miscellaneousEditBtn.MinimumWidth = 8;
            miscellaneousEditBtn.Name = "miscellaneousEditBtn";
            miscellaneousEditBtn.Text = "Edit";
            miscellaneousEditBtn.UseColumnTextForButtonValue = true;
            miscellaneousEditBtn.Width = 150;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(904, 521);
            Controls.Add(attendancePanel);
            Controls.Add(appointmentsPanel);
            Controls.Add(inventoryPanel);
            Controls.Add(miscellaneousPanel);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Sitoy Massage & Wellness Spa";
            Load += mainForm_Load;
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
        private Panel inventoryPanel;
        private Button inventoryPanelSearchBtn;
        private TextBox inventoryPanelSearchBar;
        private Button inventoryPanelInputBtn;
        private Panel miscellaneousPanel;
        private Button miscellaneousPanelSearchBtn;
        private TextBox miscellaneousPanelSearchBar;
        private Button miscellaneousPanelInputBtn;
        private DataGridViewTextBoxColumn attendanceDateHeader;
        private DataGridViewTextBoxColumn attendanceNameHeader;
        private DataGridViewButtonColumn attendanceDeleteBtn;
        private DataGridViewButtonColumn attendanceEditBtn;
        private DataGridView appointmentsPanelGridView;
        private DataGridView inventoryPanelGridView;
        private DataGridView miscellaneousPanelGridView;
        private DataGridViewTextBoxColumn appointmentsDateHeader;
        private DataGridViewTextBoxColumn appointmentsNameHeader;
        private DataGridViewTextBoxColumn appointmentsServiceHeader;
        private DataGridViewTextBoxColumn appointmentsCommissionHeader;
        private DataGridViewButtonColumn appointmentsDeleteBtn;
        private DataGridViewButtonColumn appointmentsEditBtn;
        private DataGridViewTextBoxColumn inventoryDateHeader;
        private DataGridViewTextBoxColumn inventoryOilHeader;
        private DataGridViewTextBoxColumn inventoryTowelHeader;
        private DataGridViewTextBoxColumn inventoryBedSheetHeader;
        private DataGridViewButtonColumn inventoryDeleteBtn;
        private DataGridViewButtonColumn inventoryEditBtn;
        private DataGridViewTextBoxColumn miscellaneousDateHeader;
        private DataGridViewTextBoxColumn miscellaneousAmount;
        private DataGridViewTextBoxColumn miscellaneousNoteHeader;
        private DataGridViewButtonColumn miscellaneousDeleteBtn;
        private DataGridViewButtonColumn miscellaneousEditBtn;
    }
}
