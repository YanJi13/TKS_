namespace TKS_Sitoy_Massage___Wellness_Spa
{
    partial class Form1
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
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            button5 = new Button();
            textBox3 = new TextBox();
            button6 = new Button();
            dataGridView3 = new DataGridView();
            attendancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendancePanelGridView).BeginInit();
            sidebarPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
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
            attendancePanelSearchBar.Size = new Size(405, 23);
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
            attendancePanelGridView.Size = new Size(712, 404);
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
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(171, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 520);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(533, 75);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 23);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(9, 75);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 4;
            button2.Text = "Input";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(712, 404);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(dataGridView2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(171, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(732, 520);
            panel2.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(533, 75);
            button3.Name = "button3";
            button3.Size = new Size(107, 23);
            button3.TabIndex = 6;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(405, 23);
            textBox2.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(9, 75);
            button4.Name = "button4";
            button4.Size = new Size(107, 23);
            button4.TabIndex = 4;
            button4.Text = "Input";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 104);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(712, 404);
            dataGridView2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(dataGridView3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(171, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(732, 520);
            panel3.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new Point(533, 75);
            button5.Name = "button5";
            button5.Size = new Size(107, 23);
            button5.TabIndex = 6;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(405, 23);
            textBox3.TabIndex = 5;
            // 
            // button6
            // 
            button6.Location = new Point(9, 75);
            button6.Name = "button6";
            button6.Size = new Size(107, 23);
            button6.TabIndex = 4;
            button6.Text = "Input";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(9, 104);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(712, 404);
            dataGridView3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(903, 520);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(attendancePanel);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            attendancePanel.ResumeLayout(false);
            attendancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)attendancePanelGridView).EndInit();
            sidebarPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
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
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private DataGridView dataGridView2;
        private Panel panel3;
        private Button button5;
        private TextBox textBox3;
        private Button button6;
        private DataGridView dataGridView3;
    }
}
