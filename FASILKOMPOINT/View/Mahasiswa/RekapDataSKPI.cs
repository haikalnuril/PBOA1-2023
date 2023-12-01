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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FASILKOMPOINT.View.Mahasiswa
{
    public partial class RekapDataSKPI : Form
    {
        public string username { get; set; }
        public RekapDataSKPI()
        {
            InitializeComponent();

            // Check if "Halaman" form is open and not null
            Halaman halamanLogin = Application.OpenForms["Halaman"] as Halaman;
            if (halamanLogin != null)
            {
                // Access the username property from "Halaman" form
                string username = halamanLogin.username;
                this.username = username;

                // Assuming showRekapPrestasi returns a DataTable (adjust accordingly)
                DataTable rekapData = AktivitasPrestasiContext.showRekapPrestasi(username, 602);

                // Assign the DataTable to the DataGridView DataSource
                dataGridView1.DataSource = rekapData;
                dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }


        private void RekapDataSKPI_Load(object sender, EventArgs e)
        {

        }

        private void btn_prestasi_Click(object sender, EventArgs e)
        {
            DataTable rekapData = AktivitasPrestasiContext.showRekapPrestasi(username, 602);
            dataGridView1.DataSource = rekapData;
            dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            this.Close(); // Sembunyikan form saat ini
            BerandaMahasiswa berandaMahasiswa = new BerandaMahasiswa();
            berandaMahasiswa.Show();
        }

        private void btn_kegiatan_Click(object sender, EventArgs e)
        {
            DataTable rekapData = AktivitasKeikutsertaanContext.showRekapKeikutsertaan(username, 601);
            dataGridView1.DataSource = rekapData;
            dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btn_sertifikasi_Click(object sender, EventArgs e)
        {
            DataTable rekapData = AktivitasSertifikasiContext.showRekapSertifikasi(username, 603);
            dataGridView1.DataSource = rekapData;
            dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}
