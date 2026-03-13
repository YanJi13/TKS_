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
            LoadAttendanceGrid();
            LoadMiscGrid();
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
            AttendanceInputPopUp attendancePopup = new AttendanceInputPopUp();
            attendancePopup.ShowDialog();
        }

        private void showAppointmentsPopup(object sender, EventArgs e)
        {
            AppointmentsInputPopUp appointmentsPopup = new AppointmentsInputPopUp();
            appointmentsPopup.ShowDialog();
        }
        private void showInventoryPopup(object sender, EventArgs e)
        {
            InventoryInputPopUp inventoryPopup = new InventoryInputPopUp();
            inventoryPopup.ShowDialog();
        }

        private void showMiscPopup(object sender, EventArgs e)
        {
            MiscellaneousInputPopUp miscPopup = new MiscellaneousInputPopUp();
            miscPopup.ShowDialog();
        }

        private void attendancePanelGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ignore header clicks
            if (e.RowIndex < 0)
                return;

            // DELETE button
            if (attendancePanelGridView.Columns[e.ColumnIndex].Name == "attendanceDeleteBtn")
            {
                MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                // put your delete logic here
            }

            // EDIT button
            if (attendancePanelGridView.Columns[e.ColumnIndex].Name == "attendanceEditBtn")
            {
                MessageBox.Show("Edit button clicked for row " + e.RowIndex);
                // open your edit popup here
            }
        }

        private void appointmentsPanelGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ignore header clicks
            if (e.RowIndex < 0)
                return;
            // DELETE button
            if (appointmentsPanelGridView.Columns[e.ColumnIndex].Name == "appointmentsDeleteBtn")
            {
                MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                // put your delete logic here
            }

            // EDIT button
            if (appointmentsPanelGridView.Columns[e.ColumnIndex].Name == "appointmentsEditBtn")
            {
                MessageBox.Show("Edit button clicked for row " + e.RowIndex);
                // open your edit popup here
            }
        }

        private void inventoryPanelGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ignore header clicks
            if (e.RowIndex < 0)
                return;

            // DELETE button
            if (inventoryPanelGridView.Columns[e.ColumnIndex].Name == "inventoryDeleteBtn")
            {
                // put your delete logic here
            }

            // EDIT button
            if (inventoryPanelGridView.Columns[e.ColumnIndex].Name == "inventoryEditBtn")
            {
                MessageBox.Show("Edit button clicked for row " + e.RowIndex);
                // open your edit popup here
            }
        }

        private void miscellaneousPanelGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ignore header clicks
            if (e.RowIndex < 0)
                return;

            // DELETE button
            if (miscellaneousPanelGridView.Columns[e.ColumnIndex].Name == "miscellaneousDeleteBtn")
            {
                MessageBox.Show("Delete button clicked for row " + e.RowIndex);
                // put your delete logic here
            }

            // EDIT button
            if (miscellaneousPanelGridView.Columns[e.ColumnIndex].Name == "miscellaneousEditBtn")
            {
                MessageBox.Show("Edit button clicked for row " + e.RowIndex);
                // open your edit popup here
            }
        }

        public void LoadAttendanceGrid()
        {
            dbCon db = new dbCon();
            try
            {
                string query = "SELECT attendance_id AS i, date AS d, therapist_name AS tn FROM therapist_attendance ORDER BY date DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.connection);
                DataTable dt = new DataTable();
                db.OpenConnection();
                adapter.Fill(dt);


                attendancePanelGridView.AutoGenerateColumns = false;

                // Map data to your specific headers (matching your screenshot)
                attendancePanelGridView.Columns["attendanceIdHeader"].DataPropertyName = "i";
                attendancePanelGridView.Columns["attendanceDateHeader"].DataPropertyName = "d";
                attendancePanelGridView.Columns["attendanceNameHeader"].DataPropertyName = "tn";

                // Bind the data
                attendancePanelGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Attendance: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();

            }
        }
        public void LoadAppointmentGrid()
        {
            dbCon db = new dbCon();
            try
            {
                string query = @"SELECT 
                            a.appointment_id AS i,
                            t.date AS d, 
                            t.therapist_name AS tn, 
                            a.service_type AS s, 
                            a.commission AS c 
                         FROM appointment a 
                         JOIN therapist_attendance t ON a.attendance_id = t.attendance_id 
                         ORDER BY t.date DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.connection);
                DataTable dt = new DataTable();

                db.OpenConnection();
                adapter.Fill(dt);
                appointmentsPanelGridView.Columns["appointmentsIdHeader"].DataPropertyName = "i";
                appointmentsPanelGridView.Columns["appointmentsDateHeader"].DataPropertyName = "d";
                appointmentsPanelGridView.Columns["appointmentsNameHeader"].DataPropertyName = "tn";
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
        public void LoadInventoryGrid()
        {
            dbCon db = new dbCon();
            try
            {
                string query = @"SELECT 
                            inventory_id AS i,
                            inventory_date AS d, 
                            CASE WHEN oil = 1 THEN 'Oil' ELSE '-' END AS o, 
                            CASE WHEN towel = 1 THEN 'Towel' ELSE '-' END AS t, 
                            CASE WHEN bedsheet = 1 THEN 'Bed Sheet' ELSE '-' END AS b 
                         FROM inventory";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.connection);
                DataTable dt = new DataTable();

                db.OpenConnection();
                adapter.Fill(dt);

                // Link your DESIGNER columns to the SQL names
                inventoryPanelGridView.Columns["inventoryIdHeader"].DataPropertyName = "i";
                inventoryPanelGridView.Columns["inventoryDateHeader"].DataPropertyName = "d";
                inventoryPanelGridView.Columns["inventoryOilHeader"].DataPropertyName = "o";
                inventoryPanelGridView.Columns["inventoryTowelHeader"].DataPropertyName = "t";
                inventoryPanelGridView.Columns["inventoryBedSheetHeader"].DataPropertyName = "b";

                // Set the source
                inventoryPanelGridView.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { db.CloseConnection(); }
        }
        public void LoadMiscGrid()
        {
            dbCon db = new dbCon();
            try
            {

                string query = @"SELECT 
                            m.misc_expenses_id AS i,
                            t.date AS d, 
                            m.misc_expenses AS me 
                         FROM misc_expenses m 
                         JOIN therapist_attendance t ON m.attendance_id = t.attendance_id 
                         ORDER BY t.date DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.connection);
                DataTable dt = new DataTable();
                db.OpenConnection();
                adapter.Fill(dt);

                // Mapping to your specific Designer Headers
                miscellaneousPanelGridView.Columns["miscellaneousIdHeader"].DataPropertyName = "i";
                miscellaneousPanelGridView.Columns["miscellaneousDateHeader"].DataPropertyName = "d";
                miscellaneousPanelGridView.Columns["miscellaneousAmount"].DataPropertyName = "me";


                miscellaneousPanelGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Miscellaneous: " + ex.Message);
            }
            finally { db.CloseConnection(); }
        }
    }
}
