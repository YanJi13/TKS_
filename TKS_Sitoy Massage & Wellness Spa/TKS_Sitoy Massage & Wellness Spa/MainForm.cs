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

        private void showAttendancePanel(object sender, EventArgs e)
        {
            attendancePanel.Visible = true;
            appointmentsPanel.Visible = false;
            inventoryPanel.Visible = false;
            miscellaneousPanel.Visible = false;
            attendancePanel.BringToFront();
        }

        private void showAppointmentsPanel(object sender, EventArgs e)
        {
            attendancePanel.Visible = false;
            appointmentsPanel.Visible = true;
            inventoryPanel.Visible = false;
            miscellaneousPanel.Visible = false;
            appointmentsPanel.BringToFront();

        }
        private void showInventoryPanel(object sender, EventArgs e)
        {
            attendancePanel.Visible = false;
            appointmentsPanel.Visible = false;
            inventoryPanel.Visible = true;
            miscellaneousPanel.Visible = false;
            inventoryPanel.BringToFront();

        }

        private void showMiscPanel(object sender, EventArgs e)
        {
            attendancePanel.Visible = false;
            appointmentsPanel.Visible = false;
            inventoryPanel.Visible = false;
            miscellaneousPanel.Visible = true;
            miscellaneousPanel.BringToFront();
        }

        private void showAttendancePopup(object sender, EventArgs e)
        {
            attendanceInputPopUp attendancePopup = new attendanceInputPopUp();
            attendancePopup.ShowDialog();
        }

        private void showAppointmentsPopup(object sender, EventArgs e)
        {
            appointmentsInputPopUp appointmentsPopup = new appointmentsInputPopUp();
            appointmentsPopup.ShowDialog();
        }
        private void showInventoryPopup(object sender, EventArgs e)
        {
            inventoryInputPopUp inventoryPopup = new inventoryInputPopUp();
            inventoryPopup.ShowDialog();
        }

        private void showMiscPopup(object sender, EventArgs e)
        {
            miscellaneousInputPopUp miscPopup = new miscellaneousInputPopUp();
            miscPopup.ShowDialog();
        }
    }
}
