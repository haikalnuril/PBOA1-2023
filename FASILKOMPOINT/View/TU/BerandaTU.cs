using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.View.TU
{
    public partial class BerandaTU : Form
    {
        public BerandaTU()
        {
            InitializeComponent();
        }

        private void BerandaTU_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Halaman HalamanLogin = new Halaman();
                //HalamanLogin.Show();
                //this.Hide();
            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}
