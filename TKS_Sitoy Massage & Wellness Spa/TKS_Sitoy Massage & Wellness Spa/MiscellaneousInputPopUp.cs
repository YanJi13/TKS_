using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TKS_Sitoy_Massage___Wellness_Spa
{
    public partial class MiscellaneousInputPopUp : Form
    {
        bool dateWasSelected = false; // To track the calendar click
        public MiscellaneousInputPopUp()
        {
            InitializeComponent();
        }
        private void cancelmiscellaneous(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miscellaneousEnterBtn_Click(object sender, EventArgs e)
        {
            // Check if empty
            if (string.IsNullOrWhiteSpace(miscellaneousExpensesAmountInput.Text))
            {
                MessageBox.Show("Please enter an amount.");
                return;
            }

            // NEW: Check if it's a valid decimal number
            // This handles the decimal(10,2) requirement
            if (!decimal.TryParse(miscellaneousExpensesAmountInput.Text, out decimal validatedAmount))
            {
                MessageBox.Show("Please enter a valid number (e.g., 50.00). Do not include symbols like $.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dbCon db = new dbCon();
            string selectedDate = miscellaneousCalendar.SelectionStart.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(miscellaneousExpensesAmountInput.Text))
            {
                MessageBox.Show("Please enter a valid number (e.g., 50.00). Do not include symbols like $.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.OpenConnection();

                // Get all Attendance IDs for the people present on this date
                string getIdsQuery = "SELECT attendance_id FROM therapist_attendance WHERE date = @date";
                MySqlCommand getIdsCmd = new MySqlCommand(getIdsQuery, db.connection);
                getIdsCmd.Parameters.AddWithValue("@date", selectedDate);

                List<int> presentIds = new List<int>();
                using (MySqlDataReader reader = getIdsCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        presentIds.Add(reader.GetInt32("attendance_id"));
                    }
                }

                // Check if anyone is actually present
                if (presentIds.Count == 0)
                {
                    MessageBox.Show("No therapists are marked as present for this date. Expense cannot be recorded.");
                    return;
                }

                // Loop through each ID and record the expense
                foreach (int attId in presentIds)
                {
                    string insertMisc = "INSERT INTO misc_expenses (misc_expenses, notes, attendance_id) VALUES (@amount, @notes, @attId)";
                    MySqlCommand insertCmd = new MySqlCommand(insertMisc, db.connection);

                    insertCmd.Parameters.AddWithValue("@amount", miscellaneousExpensesAmountInput.Text);
                    insertCmd.Parameters.AddWithValue("@notes", string.IsNullOrWhiteSpace(miscellaneousNoteInput.Text) ? (object)DBNull.Value : miscellaneousNoteInput.Text);
                    insertCmd.Parameters.AddWithValue("@attId", attId);

                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Success! Expense recorded for all {presentIds.Count} therapists present.");
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
        
        private void miscellaneousCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateWasSelected = true;
        }
    }
}
