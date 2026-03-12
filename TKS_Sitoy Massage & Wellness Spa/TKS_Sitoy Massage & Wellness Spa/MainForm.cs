using MySql.Data.MySqlClient;
using System.Data;

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
            LoadInventoryGrid();
            LoadAppointmentGrid();
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

        private void attendancePanelGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventoryPanelGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void appointmentsPanelGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void miscellaneousPanelGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void attendancePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadInventoryGrid()
        {
            dbCon db = new dbCon();
            try
            {
                // We match the AS names to your Column DataPropertyNames
                string query = @"SELECT 
                            inventory_date AS d, 
                            CASE WHEN oil = 1 THEN 'Oil' ELSE '-' END AS o, 
                            CASE WHEN towel = 1 THEN 'Towel' ELSE '-' END AS t, 
                            CASE WHEN bedsheet = 1 THEN 'Bed Sheet' ELSE '-' END AS b 
                         FROM inventory";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.connection);
                DataTable dt = new DataTable();

                db.OpenConnection();
                adapter.Fill(dt);

                inventoryPanelGridView.AutoGenerateColumns = false;

                // 3. Link your DESIGNER columns to the SQL names
                inventoryPanelGridView.Columns["inventoryDateHeader"].DataPropertyName = "d";
                inventoryPanelGridView.Columns["inventoryOilHeader"].DataPropertyName = "o";
                inventoryPanelGridView.Columns["inventoryTowelHeader"].DataPropertyName = "t";
                inventoryPanelGridView.Columns["inventoryBedSheetHeader"].DataPropertyName = "b";

                // 4. Set the source
                inventoryPanelGridView.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { db.CloseConnection(); }
        }
        public void LoadAppointmentGrid()
        {
            dbCon db = new dbCon();
            try
            {
                string query = @"SELECT 
                            t.date AS d, 
                            t.therapist_name AS n, 
                            a.service_type AS s, 
                            a.commission AS c 
                         FROM appointment a 
                         JOIN therapist_attendance t ON a.attendance_id = t.attendance_id 
                         ORDER BY t.date DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.connection);
                DataTable dt = new DataTable();

                db.OpenConnection();
                adapter.Fill(dt);

                appointmentsPanelGridView.AutoGenerateColumns = false;

                appointmentsPanelGridView.Columns["appointmentsDateHeader"].DataPropertyName = "d";
                appointmentsPanelGridView.Columns["appointmentsNameHeader"].DataPropertyName = "n";
                appointmentsPanelGridView.Columns["appointmentsServiceHeader"].DataPropertyName = "s";
                appointmentsPanelGridView.Columns["appointmentsCommissionHeader"].DataPropertyName = "c";

                appointmentsPanelGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Appointment Grid: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
