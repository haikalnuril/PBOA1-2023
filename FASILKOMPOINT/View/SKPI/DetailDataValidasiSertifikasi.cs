using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.View.SKPI
{
    public partial class DetailDataValidasiSertifikasi : Form
    {
        public DetailDataValidasiSertifikasi()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailDataValidasiPrestasi form = new DetailDataValidasiPrestasi();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetailDataalidasiKegiatan form = new DetailDataalidasiKegiatan();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetailDataValidasiSertifikasi form = new DetailDataValidasiSertifikasi();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ValidasiSKPIMahasiswa form = new ValidasiSKPIMahasiswa();
            form.Show();
            this.Hide();
        }
    }
}
