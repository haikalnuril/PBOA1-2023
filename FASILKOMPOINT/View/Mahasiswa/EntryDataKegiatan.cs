﻿using FASILKOMPOINT.App.Context;
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
    public partial class EntryDataKegiatan : Form
    {
        public string username { get; set; }
        public EntryDataKegiatan()
        {
            InitializeComponent();
            Halaman halamanLogin = Application.OpenForms["Halaman"] as Halaman;
            if (halamanLogin != null)
            {
                string username = halamanLogin.username;
                this.username = username;

                dataGridView.DataSource = AktivitasKeikutsertaanContext.showKeikutsertaan(username, 601);
                dataGridView.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void btn_kegiatan_Click(object sender, EventArgs e)
        {
            EntryDataKegiatan entryDataKegiatan = new EntryDataKegiatan();
            entryDataKegiatan.Show();
            this.Hide();
        }

        private void btn_sertifikasi_Click(object sender, EventArgs e)
        {
            EntryDataSertifikasi entryDataSertifikasi = new EntryDataSertifikasi();
            entryDataSertifikasi.Show();
            this.Hide();
        }

        private void EntryDataKegiatan_Load(object sender, EventArgs e)
        {

        }

        private void btn_prestasi_Click(object sender, EventArgs e)
        {
            EntryDataPrestasi entryDataPrestasi = new EntryDataPrestasi();
            entryDataPrestasi.Show();
            this.Hide();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            this.Close(); // Sembunyikan form saat ini
            BerandaMahasiswa berandaMahasiswa = new BerandaMahasiswa();
            berandaMahasiswa.Show();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            FormEntryDataKegiatan formEntryDataKegiatan = new FormEntryDataKegiatan();
            formEntryDataKegiatan.Show();
            this.Hide();
        }
    }
}
