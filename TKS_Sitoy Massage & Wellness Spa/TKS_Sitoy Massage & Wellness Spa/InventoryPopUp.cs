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
    public partial class inventoryInputPopUp : Form
    {
        bool dateWasSelected = false; // To track the calendar click
        public inventoryInputPopUp()
        {
            InitializeComponent();
        }
        private void cancelinventory(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventoryCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateWasSelected = true;
        }

        private void inventoryEnterBtn_Click(object sender, EventArgs e)
        {
            bool isOilChecked = inventoryOilCheck.Checked;
            bool isTowelChecked = inventoryTowelCheck.Checked;
            bool isBedsheetChecked = inventoryBedSheetCheck.Checked;

            // Validation: At least one must be true
            if (!isOilChecked && !isTowelChecked && !isBedsheetChecked)
            {
                MessageBox.Show("Please select at least one item to record.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon db = new dbCon();

                try
                {
                    // Based on your ERD: table 'inventory' with columns oil, towel, bedsheet, inventory_date
                    string query = "INSERT INTO inventory (oil, towel, bedsheet, inventory_date) VALUES (@oil, @towel, @bedsheet, @date)";

                    MySqlCommand cmd = new MySqlCommand(query, db.connection);

                    // MySql handles C# bools (true/false) as bit/boolean values (1/0) automatically
                    cmd.Parameters.AddWithValue("@oil", isOilChecked);
                    cmd.Parameters.AddWithValue("@towel", isTowelChecked);
                    cmd.Parameters.AddWithValue("@bedsheet", isBedsheetChecked);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                    db.OpenConnection();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Inventory recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Optional: Close the pop-up after success
                    this.Close();
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
    }
}
