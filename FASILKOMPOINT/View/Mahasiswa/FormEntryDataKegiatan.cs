using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.App.Models;
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
    public partial class FormEntryDataKegiatan : Form
    {
        public string username { get; set; }
        public FormEntryDataKegiatan(string username)
        {
            InitializeComponent();
            this.username = username;
            dateTimePicker2.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }

        private void lbl_judul_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntryDataKegiatan entryDataKegiatan = new EntryDataKegiatan(username);
            entryDataKegiatan.Show();
            this.Close();
        }

        private void FormEntryDataKegiatan_Load(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var nama_kegiatan = txt_nama.Text;
            var tanggal_dimulai = Convert.ToString(dateTimePicker1.Value);
            var tanggal_berakhir = Convert.ToString(dateTimePicker2.Value);
            KeyValuePair<int, string> selectedCombobox1 = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            var jenis_kepesertaan = selectedCombobox1.Value;
            KeyValuePair<int, string> selectedCombobox2 = (KeyValuePair<int, string>)comboBox2.SelectedItem;
            var level_tingkat = selectedCombobox2.Value;
            var file_bukti = txt_bukti.Text;

            M_Aktivitas_Keikutsertaan aktivitasKeikutsertaanBaru = new M_Aktivitas_Keikutsertaan
            {
                nama_kegiatan = nama_kegiatan,
                tanggal_dimulai = tanggal_dimulai,
                tanggal_berakhir = tanggal_berakhir,
                jenis_kepesertaan = jenis_kepesertaan,
                level_tingkat = level_tingkat,
                file_bukti = file_bukti,
                poin_id_poin = 0,
                is_acc = "menunggu",
                mahasiswa_username = Halaman.instance.username

            };
            AktivitasKeikutsertaanContext.addKeikutsertaan(aktivitasKeikutsertaanBaru);

            DialogResult messageBox = MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void check_hari_CheckedChanged(object sender, EventArgs e)
        {
            if (check_hari.Checked)
            {
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Halaman_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllForms.CloseHiddenForms(this);
        }
    }
}
