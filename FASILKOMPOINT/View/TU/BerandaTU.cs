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

namespace FASILKOMPOINT.View.TU
{
    public partial class BerandaTU : Form
    {
        public string nim { get; set; }
        public BerandaTU()
        {
            InitializeComponent();
            dataGridView1.DataSource = MahasiswaContext.readSKPITU();

            DataGridViewButtonColumn PDFButton = new DataGridViewButtonColumn();
            PDFButton.HeaderText = "PDF SKPI";
            PDFButton.Text = "Unduh";
            PDFButton.Name = "PDFButton";
            PDFButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(PDFButton);
        }

        private void BerandaTU_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ExecuteSearch();
                e.Handled = true;
            }
        }
        private void ExecuteSearch()
        {
            string searchquery = textBox1.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(searchquery))
                {
                    BerandaTU berandaTU = new BerandaTU();
                    berandaTU.Show();
                    this.Close();
                }
                else
                {
                    dataGridView1.DataSource = MahasiswaContext.showSearchDataMahasiswa(searchquery);

                    if (dataGridView1.Columns.Contains("PDFButton"))
                    {
                        dataGridView1.Columns.Remove("PDFButton");
                    }

                    DataGridViewButtonColumn PDFButton = new DataGridViewButtonColumn();
                    PDFButton.HeaderText = "PDF SKPI";
                    PDFButton.Text = "Unduh";
                    PDFButton.Name = "PDFButton";
                    PDFButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(PDFButton);

                    dataGridView1.Columns["nama_mahasiswa"].DisplayIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchquery = textBox1.Text;
            if (string.IsNullOrWhiteSpace(searchquery))
            {
                BerandaTU berandaTU = new BerandaTU();
                berandaTU.Show();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["PDFButton"].Index && e.RowIndex >= 0)
            {
                string nim = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NIM"].Value);
                this.nim = nim;
                MessageBox.Show("Berhasil mengunduh SKPI!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Halaman HalamanLogin = new Halaman();
                    HalamanLogin.Show();
                    this.Close();

                }
                else if (result == DialogResult.No)
                {
                    BerandaTU berandaTU = new BerandaTU();
                    berandaTU.Show();
                    this.Close();
                }
            }
        }
        private void Halaman_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllForms.CloseHiddenForms(this);
        }
    }
}
