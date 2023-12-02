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
    public partial class FormEntryDataSertifikasi : Form
    {
        public string username { get; set; }
        public FormEntryDataSertifikasi(string username)
        {
            InitializeComponent();
            this.username = username;
            dateTimePicker2.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            this.FormClosing += Halaman_FormClosing;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_judul_Click(object sender, EventArgs e)
        {

        }

        private void FormEntryDataSertifikasi_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            EntryDataSertifikasi entryDataSertifikasi = new EntryDataSertifikasi(username);
            entryDataSertifikasi.Show();
            this.Hide();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
