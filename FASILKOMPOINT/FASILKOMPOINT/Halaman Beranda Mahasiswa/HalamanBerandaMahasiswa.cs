using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.Halaman_Beranda_Mahasiswa
{
    public partial class HalamanBerandaMahasiswa : Form
    {
        public HalamanBerandaMahasiswa()
        {
            InitializeComponent();

            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;

            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;

            button4.MouseEnter += button4_MouseEnter;
            button4.MouseLeave += button4_MouseLeave;

        }

        private void HalamanBerandaMahasiswa_Load(object sender, EventArgs e)
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

            if (result == DialogResult.Yes)
            {
                HalamanLogin HalamanLogin = new HalamanLogin();
                HalamanLogin.Show();
                this.Hide();

            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //RekapDataSKPI Form2 = new RekapDataSKPI();
            //Form2.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //EntryData_Prestasi_depan entryData_Prestasi_Depan = new EntryData_Prestasi_depan();
            //entryData_Prestasi_Depan.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LihatSKPI LihatSKPI = new LihatSKPI();
            //LihatSKPI.Show();
            //this.Hide();
        }

        private void HalamanBerandaMahasiswa_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
