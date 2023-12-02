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
    public partial class FormEntryDataPrestasi : Form
    {
        public string username { get; set; }
        public FormEntryDataPrestasi(string username)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void EntriDataSKPI_Load(object sender, EventArgs e)
        {

        }

        private void lbl_nama_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
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
            EntryDataPrestasi entryDataPrestasi = new EntryDataPrestasi(username);
            entryDataPrestasi.Show();
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
