namespace TKS_Sitoy_Massage___Wellness_Spa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidebarPanel.Visible = true;
            sidebarPanel.Visible = false;
            attendancePanel.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            attendancePanel.Visible = false;
            panelAppointments.Visible = true;
            panelAppointments.BringToFront();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelAppointments_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
