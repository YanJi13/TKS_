using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TKS_Sitoy_Massage___Wellness_Spa
{
    public partial class AppointmentsInputPopUp : Form
    {
        bool dateWasSelected = false; // To track the calendar click
        public AppointmentsInputPopUp()
        {
            InitializeComponent();
        }
        private void cancelappointments(object sender, EventArgs e)
        {
            this.Close();
        }

        private void appointmentsEnterBtn_Click(object sender, EventArgs e)
        {

            bool isNameMissing = string.IsNullOrWhiteSpace(appointmentsNameInput.Text);
            bool isServiceMissing = string.IsNullOrWhiteSpace(appointmentsServiceTypeInput.Text);
            bool isCommMissing = string.IsNullOrWhiteSpace(appointmentsCommissionInput.Text);

            if (isNameMissing || isServiceMissing || isCommMissing)
            {
                MessageBox.Show("Please fill in all fields (Name, Service, and Commission).", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon db = new dbCon();
                string selectedDate = appointmentsCalendar.SelectionStart.ToString("yyyy-MM-dd");
                string therapistName = appointmentsNameInput.Text;

                try
                {
                    db.OpenConnection();
                    int attendanceId = 0;

                    // 1. CHECK: Does this therapist already have an ID for today?
                    string checkQuery = "SELECT attendance_id FROM therapist_attendance WHERE therapist_name = @name AND date = @date LIMIT 1";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.connection);
                    checkCmd.Parameters.AddWithValue("@name", therapistName);
                    checkCmd.Parameters.AddWithValue("@date", selectedDate);

                    object result = checkCmd.ExecuteScalar();

                    if (result != null)
                    {
                        // If they exist, use the old ID
                        attendanceId = Convert.ToInt32(result);
                    }
                    else
                    {
                        // 2. INSERT: If they don't exist, create the record for the day
                        string insertAtt = "INSERT INTO therapist_attendance (therapist_name, date) VALUES (@name, @date); SELECT LAST_INSERT_ID();";
                        MySqlCommand insertCmd = new MySqlCommand(insertAtt, db.connection);
                        insertCmd.Parameters.AddWithValue("@name", therapistName);
                        insertCmd.Parameters.AddWithValue("@date", selectedDate);
                        attendanceId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }

                    // 3. FINAL STEP: Insert the appointment using the ID we found/created
                    string queryApp = "INSERT INTO appointment (service_type, commission, attendance_id) VALUES (@service, @comm, @attId)";
                    MySqlCommand cmdApp = new MySqlCommand(queryApp, db.connection);
                    cmdApp.Parameters.AddWithValue("@service", appointmentsServiceTypeInput.Text);
                    cmdApp.Parameters.AddWithValue("@comm", appointmentsCommissionInput.Text);
                    cmdApp.Parameters.AddWithValue("@attId", attendanceId);

                    cmdApp.ExecuteNonQuery();
                    MessageBox.Show("Appointment added to " + therapistName + "'s schedule for " + selectedDate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void appointmentsCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
