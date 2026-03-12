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
            // 1. Check if empty
            if (string.IsNullOrWhiteSpace(miscExpensesAmountInput.Text))
            {
                MessageBox.Show("Please enter an amount.");
                return;
            }

            // 2. NEW: Check if it's a valid decimal number
            // This handles the decimal(10,2) requirement
            if (!decimal.TryParse(miscExpensesAmountInput.Text, out decimal validatedAmount))
            {
                MessageBox.Show("Please enter a valid number (e.g., 50.00). Do not include symbols like $.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Check Date
            if (!dateWasSelected)
            {
                MessageBox.Show("Please select a date.");
                return;
            }

            dbCon db = new dbCon();
            string selectedDate = miscellaneousCalendar.SelectionStart.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(miscExpensesAmountInput.Text))
            {
                MessageBox.Show("Please enter a valid number (e.g., 50.00). Do not include symbols like $.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.OpenConnection();

                // 1. Get all Attendance IDs for the people present on this date
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

                // 2. Check if anyone is actually present
                if (presentIds.Count == 0)
                {
                    MessageBox.Show("No therapists are marked as present for this date. Expense cannot be recorded.");
                    return;
                }

                // 3. Loop through each ID and record the expense
                foreach (int attId in presentIds)
                {
                    string insertMisc = "INSERT INTO misc_expenses (misc_expenses, notes, attendance_id) VALUES (@amount, @notes, @attId)";
                    MySqlCommand insertCmd = new MySqlCommand(insertMisc, db.connection);

                    insertCmd.Parameters.AddWithValue("@amount", miscExpensesAmountInput.Text);
                    insertCmd.Parameters.AddWithValue("@notes", string.IsNullOrWhiteSpace(miscNoteInput.Text) ? (object)DBNull.Value : miscNoteInput.Text);
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
