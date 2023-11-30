using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FASILKOMPOINT.View.Mahasiswa
{
    public partial class EntryData_Prestasi_depan : Form
    {
        private bool button1Clicked = false;
        private bool button2Clicked = false;
        private bool button3Clicked = false;
        public EntryData_Prestasi_depan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
        }
        private void btn_kegiatan_Click(object sender, EventArgs e)
        {
            button2Clicked = true;
        }

        private void btn_sertifikasi_Click(object sender, EventArgs e)
        {
            button3Clicked = true;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambah_Click_Click(object sender, EventArgs e)
        {
            if (button1Clicked)
            {
                FormEntriDataPrestasi formEntriDataPrestasi = new FormEntriDataPrestasi();
                formEntriDataPrestasi.Show();
                this.Hide();
            }

            else if (button2Clicked)
            {
                FormEntriDataKegiatan FormEntriDataKegiatan = new FormEntriDataKegiatan();
                FormEntriDataKegiatan.Show();
                this.Hide();
            }

            else if (button3Clicked)
            {
                FormEntryDataSertifikasi formEntryDataSertifikasi = new FormEntryDataSertifikasi();
                formEntryDataSertifikasi.Show();
                this.Hide();
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            Form1 HalamanBerandaMahasiswa = new Form1();
            HalamanBerandaMahasiswa.Show();
            this.Hide();
        }
    }
}
