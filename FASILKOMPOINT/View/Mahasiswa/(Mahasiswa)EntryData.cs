using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.View.Mahasiswa
{
    public partial class EntryData : Form
    {
        public EntryData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntriDataPrestasi EntriDataPrestasi = new EntriDataPrestasi();
            EntriDataPrestasi.Show();
            this.Hide();
        }

        private void btn_kegiatan_Click(object sender, EventArgs e)
        {
            EntriDataKegiatan EntriDataKegiatan = new EntriDataKegiatan();
            EntriDataKegiatan.Show();
            this.Hide();
        }

        private void btn_sertifikasi_Click(object sender, EventArgs e)
        {
            //EntryDataSertifikasi EntryDataSertifikasi = new EntryDataSertifikasi();
            //EntryDataSertifikasi.Show();
            //this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Close(); // Sembunyikan form saat ini
            //Form1 Form1 = new Form1();
            //Form1.Show();
        }

        private void EntryData_Load(object sender, EventArgs e)
        {

        }
    }
}
