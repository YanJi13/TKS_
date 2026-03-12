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
    public partial class attendanceInputPopUp : Form
    {
        
        public attendanceInputPopUp()
        {
            InitializeComponent();
        }

        private void cancelAttendance(object sender, EventArgs e)
        {
            this.Close();
        }

        private void attendanceEnterBtn_Click(object sender, EventArgs e)
        {
            // 1. Check if name is empty
            bool isNameMissing = string.IsNullOrWhiteSpace(attendanceNameInput.Text);

            if (isNameMissing)
            {
                MessageBox.Show("Please enter a name.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                // SUCCESS!
                string name = attendanceNameInput.Text;
                string date = attendanceCalendar.SelectionStart.ToShortDateString();

                MessageBox.Show($"Attendance recorded for {name} on {date}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optional: Reset the flag for the next entry
                // dateWasSelected = false; 
                // attendanceNameInput.Clear();
            }

            dbCon db = new dbCon();

            try
            {
               
                string query = "INSERT INTO therapist_attendance (therapist_name,date) VALUES (@name, @date)";

                
                MySqlCommand cmd = new MySqlCommand(query, db.connection);

                
                cmd.Parameters.AddWithValue("@name", attendanceNameInput.Text);
                cmd.Parameters.AddWithValue("@Date", attendanceCalendar.SelectionStart.ToString("yyyy-MM-dd"));


                db.OpenConnection();
                cmd.ExecuteNonQuery(); // ExecuteNonQuery is for Insert/Update/Delete

                MessageBox.Show("Data Saved Successfully!");
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

        private void attendanceCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }
    }
}
