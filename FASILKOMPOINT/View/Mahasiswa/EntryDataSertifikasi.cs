using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.App.Core;
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
    public partial class EntryDataSertifikasi : Form
    {
        public string username { get; set; }
        public EntryDataSertifikasi(string username)
        {
            InitializeComponent();
            this.username = username;
            dataGridView.DataSource = AktivitasSertifikasiContext.showSertifikasi(username, 603);
            dataGridView.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.FormClosing += Halaman_FormClosing;
        }

        private void btn_prestasi_Click(object sender, EventArgs e)
        {
            EntryDataPrestasi entryDataPrestasi = new EntryDataPrestasi(username);
            entryDataPrestasi.Show();
            this.Hide();
        }

        private void btn_kegiatan_Click(object sender, EventArgs e)
        {
            EntryDataKegiatan entryDataKegiatan = new EntryDataKegiatan(username);
            entryDataKegiatan.Show();
            this.Hide();
        }

        private void btn_sertifikasi_Click(object sender, EventArgs e)
        {
            EntryDataSertifikasi entryDataSertifikasi = new EntryDataSertifikasi(username);
            entryDataSertifikasi.Show();
            this.Hide();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            BerandaMahasiswa berandaMahasiswa = new BerandaMahasiswa(username);
            berandaMahasiswa.Show();
            this.Hide();
        }

        private void EntryDataSertifikasi_Load(object sender, EventArgs e)
        {

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            FormEntryDataSertifikasi formEntryDataSertifikasi = new FormEntryDataSertifikasi(username);
            formEntryDataSertifikasi.Show();
            this.Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["Bukti"].Index && e.RowIndex >= 0)
            {
                string link = dataGridView.Rows[e.RowIndex].Cells["Bukti"].Value?.ToString();

                if (!string.IsNullOrEmpty(link))
                {
                    ShellExecutor.OpenFileUsingDefaultProgram(link);
                }
            }
        }
        private void Halaman_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CloseAllForms.CloseHiddenForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
