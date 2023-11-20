namespace Fasilkom_Point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;

            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;

            button4.MouseEnter += button4_MouseEnter;
            button4.MouseLeave += button4_MouseLeave;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Control;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.Control;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Blue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Keluar dari aplikasi?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            {
                // Sambung ke form login
                //LoginForm loginForm = new LoginForm();
                //loginForm.Show();
                //this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RekapDataSKPI Form2 = new RekapDataSKPI();
            //this.Close();
            Form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntryData EntryData = new EntryData();
            EntryData.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LihatSKPI LihatSKPI = new LihatSKPI();
            //this.Close();
            LihatSKPI.Show();
            this.Hide();
        }
    }
}