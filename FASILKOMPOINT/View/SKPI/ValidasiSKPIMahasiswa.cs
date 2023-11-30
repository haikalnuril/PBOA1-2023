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
    public partial class ValidasiSKPIMahasiswa : Form
    {
        public ValidasiSKPIMahasiswa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BerandaSKPI form = new BerandaSKPI();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DetailDataValidasiPrestasi DetailDataValidasiSertifikasi = new DetailDataValidasiPrestasi();
            //DetailDataValidasiSertifikasi.Show();
            this.Hide();
        }

        private void ValidasiSKPIMahasiswa_Load(object sender, EventArgs e)
        {

        }
    }
}
