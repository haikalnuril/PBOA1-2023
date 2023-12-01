using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.View.SKPI;
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
            tabelSKPITU.DataSource = MahasiswaContext.readSKPITU();

            DataGridViewButtonColumn PDFButton = new DataGridViewButtonColumn();
            PDFButton.HeaderText = "File SKPI";
            PDFButton.Text = "Unduh";
            PDFButton.Name = "PDFButton";
            PDFButton.UseColumnTextForButtonValue = true;
            tabelSKPITU.Columns.Insert(5, PDFButton);
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
                    this.Hide();
                }
                else
                {
                    tabelSKPITU.DataSource = MahasiswaContext.showSearchDataMahasiswa(searchquery);

                    if (tabelSKPITU.Columns.Contains("detailButton"))
                    {
                        tabelSKPITU.Columns.Remove("detailButton");
                    }

                    DataGridViewButtonColumn PDFButton = new DataGridViewButtonColumn();
                    PDFButton.HeaderText = "PDF SKPI";
                    PDFButton.Text = "Unduh";
                    PDFButton.Name = "PDFButton";
                    PDFButton.UseColumnTextForButtonValue = true;
                    tabelSKPITU.Columns.Insert(3, PDFButton);

                    tabelSKPITU.Columns["nama_mahasiswa"].DisplayIndex = 1;
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
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabelSKPITU.Columns["PDFButton"].Index && e.RowIndex >= 0)
            {
                string nim = Convert.ToString(tabelSKPITU.Rows[e.RowIndex].Cells["NIM"].Value);
                this.nim = nim;
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
                    this.Hide();

                }
                else if (result == DialogResult.No)
                {

                }
            }
        }
    }
}
