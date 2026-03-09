namespace TKS_Sitoy_Massage___Wellness_Spa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void attendanceSideBtn_Click(object sender, EventArgs e)
        {
            attendancePanel.Visible = true;
            appointmentsPanel.Visible = false;
            inventoryPanel.Visible = false;
            miscellaneousPanel.Visible = false;
            attendancePanel.BringToFront();
        }

        private void appointmentsSideBtn_Click(object sender, EventArgs e)
        {
            attendancePanel.Visible = false;
            appointmentsPanel.Visible = true;
            inventoryPanel.Visible = false;
            miscellaneousPanel.Visible = false;
            appointmentsPanel.BringToFront();

        }
        private void inventorySideBtn_Click(object sender, EventArgs e)
        {
            attendancePanel.Visible = false;
            appointmentsPanel.Visible = false;
            inventoryPanel.Visible = true;
            miscellaneousPanel.Visible = false;
            inventoryPanel.BringToFront();

        }

        private void miscSideBtn_Click(object sender, EventArgs e)
        {
            attendancePanel.Visible = false;
            appointmentsPanel.Visible = false;
            inventoryPanel.Visible = false;
            miscellaneousPanel.Visible = true;
            miscellaneousPanel.BringToFront();
        }
    }
}
