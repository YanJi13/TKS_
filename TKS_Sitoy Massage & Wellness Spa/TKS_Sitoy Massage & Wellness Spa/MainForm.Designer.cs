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
            attendanceIdHeader = new DataGridViewTextBoxColumn();
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
            appointmentsIdHeader = new DataGridViewTextBoxColumn();
            appointmentsDateHeader = new DataGridViewTextBoxColumn();
            appointmentsNameHeader = new DataGridViewTextBoxColumn();
            appointmentsServiceHeader = new DataGridViewTextBoxColumn();
            appointmentsPaymentHeader = new DataGridViewTextBoxColumn();
            appointmentsCommissionHeader = new DataGridViewTextBoxColumn();
            appointmentsDeleteBtn = new DataGridViewButtonColumn();
            appointmentsEditBtn = new DataGridViewButtonColumn();
            inventoryPanel = new Panel();
            inventoryPanelSearchBtn = new Button();
            inventoryPanelSearchBar = new TextBox();
            inventoryPanelInputBtn = new Button();
            inventoryPanelGridView = new DataGridView();
            inventoryIdHeader = new DataGridViewTextBoxColumn();
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
            miscellaneousIdHeader = new DataGridViewTextBoxColumn();
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
            attendancePanel.Controls.Add(attendancePanelSearchBar);
            attendancePanel.Controls.Add(attendancePanelInputBtn);
            attendancePanel.Controls.Add(attendancePanelGridView);
            attendancePanel.Dock = DockStyle.Fill;
            attendancePanel.Location = new Point(199, 0);
            attendancePanel.Name = "attendancePanel";
            attendancePanel.Size = new Size(839, 547);
            attendancePanel.TabIndex = 9;
            // 
            // attendancePanelSearchBtn
            // 
            attendancePanelSearchBtn.BackColor = Color.FromArgb(129, 161, 193);
            attendancePanelSearchBtn.FlatStyle = FlatStyle.Popup;
            attendancePanelSearchBtn.ForeColor = Color.FromArgb(236, 239, 244);
            attendancePanelSearchBtn.Location = new Point(364, 60);
            attendancePanelSearchBtn.Name = "attendancePanelSearchBtn";
            attendancePanelSearchBtn.Size = new Size(107, 38);
            attendancePanelSearchBtn.TabIndex = 6;
            attendancePanelSearchBtn.Text = "Search";
            attendancePanelSearchBtn.UseVisualStyleBackColor = false;
            // 
            // attendancePanelSearchBar
            // 
            attendancePanelSearchBar.Location = new Point(122, 60);
            attendancePanelSearchBar.Name = "attendancePanelSearchBar";
            attendancePanelSearchBar.Size = new Size(236, 23);
            attendancePanelSearchBar.TabIndex = 5;
            // 
            // attendancePanelInputBtn
            // 
            attendancePanelInputBtn.BackColor = Color.FromArgb(129, 161, 193);
            attendancePanelInputBtn.FlatStyle = FlatStyle.Popup;
            attendancePanelInputBtn.ForeColor = Color.FromArgb(236, 239, 244);
            attendancePanelInputBtn.Location = new Point(9, 60);
            attendancePanelInputBtn.Name = "attendancePanelInputBtn";
            attendancePanelInputBtn.Size = new Size(107, 38);
            attendancePanelInputBtn.TabIndex = 4;
            attendancePanelInputBtn.Text = "Input";
            attendancePanelInputBtn.UseVisualStyleBackColor = false;
            attendancePanelInputBtn.Click += showAttendancePopup;
            // 
            // attendancePanelGridView
            // 
            attendancePanelGridView.AllowUserToAddRows = false;
            attendancePanelGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            attendancePanelGridView.BackgroundColor = Color.FromArgb(70, 79, 99);
            attendancePanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendancePanelGridView.Columns.AddRange(new DataGridViewColumn[] { attendanceIdHeader, attendanceDateHeader, attendanceNameHeader, attendanceDeleteBtn, attendanceEditBtn });
            attendancePanelGridView.Location = new Point(9, 120);
            attendancePanelGridView.Name = "attendancePanelGridView";
            attendancePanelGridView.RowHeadersWidth = 30;
            attendancePanelGridView.Size = new Size(765, 404);
            attendancePanelGridView.TabIndex = 0;
            attendancePanelGridView.CellContentClick += attendancePanelGridView_CellContentClick;
            // 
            // attendanceIdHeader
            // 
            attendanceIdHeader.HeaderText = "Id";
            attendanceIdHeader.MinimumWidth = 8;
            attendanceIdHeader.Name = "attendanceIdHeader";
            attendanceIdHeader.Visible = false;
            // 
            // attendanceDateHeader
            // 
            attendanceDateHeader.HeaderText = "Date";
            attendanceDateHeader.MinimumWidth = 8;
            attendanceDateHeader.Name = "attendanceDateHeader";
            // 
            // attendanceNameHeader
            // 
            attendanceNameHeader.HeaderText = "Name";
            attendanceNameHeader.MinimumWidth = 8;
            attendanceNameHeader.Name = "attendanceNameHeader";
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
            // 
            // attendanceEditBtn
            // 
            attendanceEditBtn.HeaderText = "Edit";
            attendanceEditBtn.MinimumWidth = 8;
            attendanceEditBtn.Name = "attendanceEditBtn";
            attendanceEditBtn.Text = "Edit";
            attendanceEditBtn.UseColumnTextForButtonValue = true;
            // 
            // attendanceSideBtn
            // 
            attendanceSideBtn.BackColor = Color.FromArgb(129, 161, 193);
            attendanceSideBtn.FlatStyle = FlatStyle.Popup;
            attendanceSideBtn.ForeColor = Color.FromArgb(236, 239, 244);
            attendanceSideBtn.Location = new Point(21, 118);
            attendanceSideBtn.Name = "attendanceSideBtn";
            attendanceSideBtn.Size = new Size(150, 45);
            attendanceSideBtn.TabIndex = 0;
            attendanceSideBtn.Text = "Attendance";
            attendanceSideBtn.UseVisualStyleBackColor = false;
            attendanceSideBtn.Click += showAttendancePanel;
            // 
            // appointmentsSideBtn
            // 
            appointmentsSideBtn.BackColor = Color.FromArgb(129, 161, 193);
            appointmentsSideBtn.FlatStyle = FlatStyle.Popup;
            appointmentsSideBtn.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsSideBtn.Location = new Point(21, 178);
            appointmentsSideBtn.Name = "appointmentsSideBtn";
            appointmentsSideBtn.Size = new Size(150, 45);
            appointmentsSideBtn.TabIndex = 1;
            appointmentsSideBtn.Text = "Appointments";
            appointmentsSideBtn.UseVisualStyleBackColor = false;
            appointmentsSideBtn.Click += showAppointmentsPanel;
            // 
            // inventorySideBtn
            // 
            inventorySideBtn.BackColor = Color.FromArgb(129, 161, 193);
            inventorySideBtn.FlatStyle = FlatStyle.Popup;
            inventorySideBtn.ForeColor = Color.FromArgb(236, 239, 244);
            inventorySideBtn.Location = new Point(21, 238);
            inventorySideBtn.Name = "inventorySideBtn";
            inventorySideBtn.Size = new Size(150, 45);
            inventorySideBtn.TabIndex = 2;
            inventorySideBtn.Text = "Inventory";
            inventorySideBtn.UseVisualStyleBackColor = false;
            inventorySideBtn.Click += showInventoryPanel;
            // 
            // miscSideBtn
            // 
            miscSideBtn.BackColor = Color.FromArgb(129, 161, 193);
            miscSideBtn.FlatStyle = FlatStyle.Popup;
            miscSideBtn.ForeColor = Color.FromArgb(236, 239, 244);
            miscSideBtn.Location = new Point(21, 298);
            miscSideBtn.Name = "miscSideBtn";
            miscSideBtn.Size = new Size(150, 45);
            miscSideBtn.TabIndex = 3;
            miscSideBtn.Text = "Miscellaneous";
            miscSideBtn.UseVisualStyleBackColor = false;
            miscSideBtn.Click += showMiscPanel;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(59, 66, 82);
            sidebarPanel.Controls.Add(attendanceSideBtn);
            sidebarPanel.Controls.Add(appointmentsSideBtn);
            sidebarPanel.Controls.Add(inventorySideBtn);
            sidebarPanel.Controls.Add(miscSideBtn);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(199, 547);
            sidebarPanel.TabIndex = 0;
            // 
            // appointmentsPanel
            // 
            appointmentsPanel.Controls.Add(appointmentsPanelSearchBtn);
            appointmentsPanel.Controls.Add(appointmentsPanelSearchBar);
            appointmentsPanel.Controls.Add(appointmentsPanelInputBtn);
            appointmentsPanel.Controls.Add(appointmentsPanelGridView);
            appointmentsPanel.Dock = DockStyle.Fill;
            appointmentsPanel.Location = new Point(199, 0);
            appointmentsPanel.Name = "appointmentsPanel";
            appointmentsPanel.Size = new Size(839, 547);
            appointmentsPanel.TabIndex = 10;
            // 
            // appointmentsPanelSearchBtn
            // 
            appointmentsPanelSearchBtn.BackColor = Color.FromArgb(129, 161, 193);
            appointmentsPanelSearchBtn.FlatStyle = FlatStyle.Popup;
            appointmentsPanelSearchBtn.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsPanelSearchBtn.Location = new Point(364, 60);
            appointmentsPanelSearchBtn.Name = "appointmentsPanelSearchBtn";
            appointmentsPanelSearchBtn.Size = new Size(107, 38);
            appointmentsPanelSearchBtn.TabIndex = 6;
            appointmentsPanelSearchBtn.Text = "Search";
            appointmentsPanelSearchBtn.UseVisualStyleBackColor = false;
            // 
            // appointmentsPanelSearchBar
            // 
            appointmentsPanelSearchBar.Location = new Point(122, 60);
            appointmentsPanelSearchBar.Name = "appointmentsPanelSearchBar";
            appointmentsPanelSearchBar.Size = new Size(236, 23);
            appointmentsPanelSearchBar.TabIndex = 5;
            // 
            // appointmentsPanelInputBtn
            // 
            appointmentsPanelInputBtn.BackColor = Color.FromArgb(129, 161, 193);
            appointmentsPanelInputBtn.FlatStyle = FlatStyle.Popup;
            appointmentsPanelInputBtn.ForeColor = Color.FromArgb(236, 239, 244);
            appointmentsPanelInputBtn.Location = new Point(9, 60);
            appointmentsPanelInputBtn.Name = "appointmentsPanelInputBtn";
            appointmentsPanelInputBtn.Size = new Size(107, 38);
            appointmentsPanelInputBtn.TabIndex = 4;
            appointmentsPanelInputBtn.Text = "Input";
            appointmentsPanelInputBtn.UseVisualStyleBackColor = false;
            appointmentsPanelInputBtn.Click += showAppointmentsPopup;
            // 
            // appointmentsPanelGridView
            // 
            appointmentsPanelGridView.AllowUserToAddRows = false;
            appointmentsPanelGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentsPanelGridView.BackgroundColor = Color.FromArgb(70, 79, 99);
            appointmentsPanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsPanelGridView.Columns.AddRange(new DataGridViewColumn[] { appointmentsIdHeader, appointmentsDateHeader, appointmentsNameHeader, appointmentsServiceHeader, appointmentsPaymentHeader, appointmentsCommissionHeader, appointmentsDeleteBtn, appointmentsEditBtn });
            appointmentsPanelGridView.Location = new Point(9, 120);
            appointmentsPanelGridView.Name = "appointmentsPanelGridView";
            appointmentsPanelGridView.RowHeadersWidth = 30;
            appointmentsPanelGridView.Size = new Size(765, 404);
            appointmentsPanelGridView.TabIndex = 0;
            appointmentsPanelGridView.CellContentClick += appointmentsPanelGridView_CellContentClick;
            // 
            // appointmentsIdHeader
            // 
            appointmentsIdHeader.HeaderText = "Id";
            appointmentsIdHeader.MinimumWidth = 8;
            appointmentsIdHeader.Name = "appointmentsIdHeader";
            appointmentsIdHeader.Visible = false;
            // 
            // appointmentsDateHeader
            // 
            appointmentsDateHeader.HeaderText = "Date";
            appointmentsDateHeader.MinimumWidth = 8;
            appointmentsDateHeader.Name = "appointmentsDateHeader";
            // 
            // appointmentsNameHeader
            // 
            appointmentsNameHeader.HeaderText = "Name";
            appointmentsNameHeader.MinimumWidth = 8;
            appointmentsNameHeader.Name = "appointmentsNameHeader";
            // 
            // appointmentsServiceHeader
            // 
            appointmentsServiceHeader.HeaderText = "Service";
            appointmentsServiceHeader.MinimumWidth = 8;
            appointmentsServiceHeader.Name = "appointmentsServiceHeader";
            // 
            // appointmentsPaymentHeader
            // 
            appointmentsPaymentHeader.HeaderText = "Payment";
            appointmentsPaymentHeader.Name = "appointmentsPaymentHeader";
            // 
            // appointmentsCommissionHeader
            // 
            appointmentsCommissionHeader.HeaderText = "Commission";
            appointmentsCommissionHeader.MinimumWidth = 8;
            appointmentsCommissionHeader.Name = "appointmentsCommissionHeader";
            // 
            // appointmentsDeleteBtn
            // 
            appointmentsDeleteBtn.HeaderText = "Delete";
            appointmentsDeleteBtn.MinimumWidth = 8;
            appointmentsDeleteBtn.Name = "appointmentsDeleteBtn";
            appointmentsDeleteBtn.Text = "Delete";
            appointmentsDeleteBtn.UseColumnTextForButtonValue = true;
            // 
            // appointmentsEditBtn
            // 
            appointmentsEditBtn.HeaderText = "Edit";
            appointmentsEditBtn.MinimumWidth = 8;
            appointmentsEditBtn.Name = "appointmentsEditBtn";
            appointmentsEditBtn.Text = "Edit";
            appointmentsEditBtn.UseColumnTextForButtonValue = true;
            // 
            // inventoryPanel
            // 
            inventoryPanel.Controls.Add(inventoryPanelSearchBtn);
            inventoryPanel.Controls.Add(inventoryPanelSearchBar);
            inventoryPanel.Controls.Add(inventoryPanelInputBtn);
            inventoryPanel.Controls.Add(inventoryPanelGridView);
            inventoryPanel.Dock = DockStyle.Fill;
            inventoryPanel.Location = new Point(199, 0);
            inventoryPanel.Name = "inventoryPanel";
            inventoryPanel.Size = new Size(839, 547);
            inventoryPanel.TabIndex = 11;
            // 
            // inventoryPanelSearchBtn
            // 
            inventoryPanelSearchBtn.BackColor = Color.FromArgb(129, 161, 193);
            inventoryPanelSearchBtn.FlatStyle = FlatStyle.Popup;
            inventoryPanelSearchBtn.ForeColor = Color.FromArgb(236, 239, 244);
            inventoryPanelSearchBtn.Location = new Point(364, 60);
            inventoryPanelSearchBtn.Name = "inventoryPanelSearchBtn";
            inventoryPanelSearchBtn.Size = new Size(107, 38);
            inventoryPanelSearchBtn.TabIndex = 6;
            inventoryPanelSearchBtn.Text = "Search";
            inventoryPanelSearchBtn.UseVisualStyleBackColor = false;
            // 
            // inventoryPanelSearchBar
            // 
            inventoryPanelSearchBar.Location = new Point(122, 60);
            inventoryPanelSearchBar.Name = "inventoryPanelSearchBar";
            inventoryPanelSearchBar.Size = new Size(236, 23);
            inventoryPanelSearchBar.TabIndex = 5;
            // 
            // inventoryPanelInputBtn
            // 
            inventoryPanelInputBtn.BackColor = Color.FromArgb(129, 161, 193);
            inventoryPanelInputBtn.FlatStyle = FlatStyle.Popup;
            inventoryPanelInputBtn.ForeColor = Color.FromArgb(236, 239, 244);
            inventoryPanelInputBtn.Location = new Point(9, 60);
            inventoryPanelInputBtn.Name = "inventoryPanelInputBtn";
            inventoryPanelInputBtn.Size = new Size(107, 38);
            inventoryPanelInputBtn.TabIndex = 4;
            inventoryPanelInputBtn.Text = "Input";
            inventoryPanelInputBtn.UseVisualStyleBackColor = false;
            inventoryPanelInputBtn.Click += showInventoryPopup;
            // 
            // inventoryPanelGridView
            // 
            inventoryPanelGridView.AllowUserToAddRows = false;
            inventoryPanelGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryPanelGridView.BackgroundColor = Color.FromArgb(70, 79, 99);
            inventoryPanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryPanelGridView.Columns.AddRange(new DataGridViewColumn[] { inventoryIdHeader, inventoryDateHeader, inventoryOilHeader, inventoryTowelHeader, inventoryBedSheetHeader, inventoryDeleteBtn, inventoryEditBtn });
            inventoryPanelGridView.Location = new Point(9, 120);
            inventoryPanelGridView.Name = "inventoryPanelGridView";
            inventoryPanelGridView.RowHeadersWidth = 30;
            inventoryPanelGridView.Size = new Size(765, 404);
            inventoryPanelGridView.TabIndex = 0;
            inventoryPanelGridView.CellContentClick += inventoryPanelGridView_CellContentClick;
            // 
            // inventoryIdHeader
            // 
            inventoryIdHeader.HeaderText = "Id";
            inventoryIdHeader.MinimumWidth = 8;
            inventoryIdHeader.Name = "inventoryIdHeader";
            inventoryIdHeader.Visible = false;
            // 
            // inventoryDateHeader
            // 
            inventoryDateHeader.HeaderText = "Date";
            inventoryDateHeader.MinimumWidth = 8;
            inventoryDateHeader.Name = "inventoryDateHeader";
            // 
            // inventoryOilHeader
            // 
            inventoryOilHeader.HeaderText = "Oil";
            inventoryOilHeader.MinimumWidth = 8;
            inventoryOilHeader.Name = "inventoryOilHeader";
            // 
            // inventoryTowelHeader
            // 
            inventoryTowelHeader.HeaderText = "Towel";
            inventoryTowelHeader.MinimumWidth = 8;
            inventoryTowelHeader.Name = "inventoryTowelHeader";
            // 
            // inventoryBedSheetHeader
            // 
            inventoryBedSheetHeader.HeaderText = "Bed Sheet";
            inventoryBedSheetHeader.MinimumWidth = 8;
            inventoryBedSheetHeader.Name = "inventoryBedSheetHeader";
            // 
            // inventoryDeleteBtn
            // 
            inventoryDeleteBtn.HeaderText = "Delete";
            inventoryDeleteBtn.MinimumWidth = 8;
            inventoryDeleteBtn.Name = "inventoryDeleteBtn";
            // 
            // inventoryEditBtn
            // 
            inventoryEditBtn.HeaderText = "Edit";
            inventoryEditBtn.MinimumWidth = 8;
            inventoryEditBtn.Name = "inventoryEditBtn";
            // 
            // miscellaneousPanel
            // 
            miscellaneousPanel.Controls.Add(miscellaneousPanelSearchBtn);
            miscellaneousPanel.Controls.Add(miscellaneousPanelSearchBar);
            miscellaneousPanel.Controls.Add(miscellaneousPanelInputBtn);
            miscellaneousPanel.Controls.Add(miscellaneousPanelGridView);
            miscellaneousPanel.Dock = DockStyle.Fill;
            miscellaneousPanel.Location = new Point(199, 0);
            miscellaneousPanel.Name = "miscellaneousPanel";
            miscellaneousPanel.Size = new Size(839, 547);
            miscellaneousPanel.TabIndex = 12;
            // 
            // miscellaneousPanelSearchBtn
            // 
            miscellaneousPanelSearchBtn.BackColor = Color.FromArgb(129, 161, 193);
            miscellaneousPanelSearchBtn.FlatStyle = FlatStyle.Popup;
            miscellaneousPanelSearchBtn.ForeColor = Color.FromArgb(236, 239, 244);
            miscellaneousPanelSearchBtn.Location = new Point(364, 60);
            miscellaneousPanelSearchBtn.Name = "miscellaneousPanelSearchBtn";
            miscellaneousPanelSearchBtn.Size = new Size(107, 38);
            miscellaneousPanelSearchBtn.TabIndex = 6;
            miscellaneousPanelSearchBtn.Text = "Search";
            miscellaneousPanelSearchBtn.UseVisualStyleBackColor = false;
            // 
            // miscellaneousPanelSearchBar
            // 
            miscellaneousPanelSearchBar.Location = new Point(122, 60);
            miscellaneousPanelSearchBar.Name = "miscellaneousPanelSearchBar";
            miscellaneousPanelSearchBar.Size = new Size(236, 23);
            miscellaneousPanelSearchBar.TabIndex = 5;
            // 
            // miscellaneousPanelInputBtn
            // 
            miscellaneousPanelInputBtn.BackColor = Color.FromArgb(129, 161, 193);
            miscellaneousPanelInputBtn.FlatStyle = FlatStyle.Popup;
            miscellaneousPanelInputBtn.ForeColor = Color.FromArgb(236, 239, 244);
            miscellaneousPanelInputBtn.Location = new Point(9, 60);
            miscellaneousPanelInputBtn.Name = "miscellaneousPanelInputBtn";
            miscellaneousPanelInputBtn.Size = new Size(107, 38);
            miscellaneousPanelInputBtn.TabIndex = 4;
            miscellaneousPanelInputBtn.Text = "Input";
            miscellaneousPanelInputBtn.UseVisualStyleBackColor = false;
            miscellaneousPanelInputBtn.Click += showMiscPopup;
            // 
            // miscellaneousPanelGridView
            // 
            miscellaneousPanelGridView.AllowUserToAddRows = false;
            miscellaneousPanelGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            miscellaneousPanelGridView.BackgroundColor = Color.FromArgb(70, 79, 99);
            miscellaneousPanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miscellaneousPanelGridView.Columns.AddRange(new DataGridViewColumn[] { miscellaneousIdHeader, miscellaneousDateHeader, miscellaneousAmount, miscellaneousNoteHeader, miscellaneousDeleteBtn, miscellaneousEditBtn });
            miscellaneousPanelGridView.Location = new Point(9, 120);
            miscellaneousPanelGridView.Name = "miscellaneousPanelGridView";
            miscellaneousPanelGridView.RowHeadersWidth = 30;
            miscellaneousPanelGridView.Size = new Size(765, 404);
            miscellaneousPanelGridView.TabIndex = 0;
            miscellaneousPanelGridView.CellContentClick += miscellaneousPanelGridView_CellContentClick;
            // 
            // miscellaneousIdHeader
            // 
            miscellaneousIdHeader.HeaderText = "Id";
            miscellaneousIdHeader.MinimumWidth = 8;
            miscellaneousIdHeader.Name = "miscellaneousIdHeader";
            miscellaneousIdHeader.Visible = false;
            // 
            // miscellaneousDateHeader
            // 
            miscellaneousDateHeader.HeaderText = "Date";
            miscellaneousDateHeader.MinimumWidth = 8;
            miscellaneousDateHeader.Name = "miscellaneousDateHeader";
            // 
            // miscellaneousAmount
            // 
            miscellaneousAmount.HeaderText = "Misc Amount";
            miscellaneousAmount.MinimumWidth = 8;
            miscellaneousAmount.Name = "miscellaneousAmount";
            // 
            // miscellaneousNoteHeader
            // 
            miscellaneousNoteHeader.HeaderText = "Notes (optional)";
            miscellaneousNoteHeader.MinimumWidth = 8;
            miscellaneousNoteHeader.Name = "miscellaneousNoteHeader";
            // 
            // miscellaneousDeleteBtn
            // 
            miscellaneousDeleteBtn.HeaderText = "Delete";
            miscellaneousDeleteBtn.MinimumWidth = 8;
            miscellaneousDeleteBtn.Name = "miscellaneousDeleteBtn";
            miscellaneousDeleteBtn.Text = "Delete";
            miscellaneousDeleteBtn.UseColumnTextForButtonValue = true;
            // 
            // miscellaneousEditBtn
            // 
            miscellaneousEditBtn.HeaderText = "Edit";
            miscellaneousEditBtn.MinimumWidth = 8;
            miscellaneousEditBtn.Name = "miscellaneousEditBtn";
            miscellaneousEditBtn.Text = "Edit";
            miscellaneousEditBtn.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(46, 52, 64);
            ClientSize = new Size(1038, 547);
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
        private DataGridView appointmentsPanelGridView;
        private DataGridView inventoryPanelGridView;
        private DataGridView miscellaneousPanelGridView;
        private Button attendancePanelSearchBtn;
        private Button attendancePanelInputBtn;
        private TextBox attendancePanelSearchBar;
        private DataGridViewTextBoxColumn attendanceIdHeader;
        private DataGridViewTextBoxColumn attendanceDateHeader;
        private DataGridViewTextBoxColumn attendanceNameHeader;
        private DataGridViewButtonColumn attendanceDeleteBtn;
        private DataGridViewButtonColumn attendanceEditBtn;
        private DataGridViewTextBoxColumn inventoryIdHeader;
        private DataGridViewTextBoxColumn inventoryDateHeader;
        private DataGridViewTextBoxColumn inventoryOilHeader;
        private DataGridViewTextBoxColumn inventoryTowelHeader;
        private DataGridViewTextBoxColumn inventoryBedSheetHeader;
        private DataGridViewButtonColumn inventoryDeleteBtn;
        private DataGridViewButtonColumn inventoryEditBtn;
        private DataGridViewTextBoxColumn miscellaneousIdHeader;
        private DataGridViewTextBoxColumn miscellaneousDateHeader;
        private DataGridViewTextBoxColumn miscellaneousAmount;
        private DataGridViewTextBoxColumn miscellaneousNoteHeader;
        private DataGridViewButtonColumn miscellaneousDeleteBtn;
        private DataGridViewButtonColumn miscellaneousEditBtn;
        private DataGridViewTextBoxColumn appointmentsIdHeader;
        private DataGridViewTextBoxColumn appointmentsDateHeader;
        private DataGridViewTextBoxColumn appointmentsNameHeader;
        private DataGridViewTextBoxColumn appointmentsServiceHeader;
        private DataGridViewTextBoxColumn appointmentsPaymentHeader;
        private DataGridViewTextBoxColumn appointmentsCommissionHeader;
        private DataGridViewButtonColumn appointmentsDeleteBtn;
        private DataGridViewButtonColumn appointmentsEditBtn;
    }
}
