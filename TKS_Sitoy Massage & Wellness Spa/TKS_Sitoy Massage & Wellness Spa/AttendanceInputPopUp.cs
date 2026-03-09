using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    }   
}
