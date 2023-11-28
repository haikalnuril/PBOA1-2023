using FASILKOMPOINT.App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT
{
    public partial class Form1 : Form
    {
        public string username;
        public Form1()
        {
            InitializeComponent();
            tabelDataSKPIMahasiswa.DataSource = AktivitasKeikutsertaanContext.showKeikutsertaan("222410101006", 601);

            tabelDataSKPIMahasiswa.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tabelDataSKPIMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SearchNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ExecuteSearch();
                e.Handled = true;
            }
        }
        private void ExecuteSearch()
        {
            string nama = SearchNama.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(nama))
                {
                    tabelDataSKPIMahasiswa.DataSource = MahasiswaContext.showDataSKPIMahasiswa();
                }
                else
                {
                    tabelDataSKPIMahasiswa.DataSource = MahasiswaContext.showSearchDataSKPIMahasiswa(nama);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchNama_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchNama.Text))
            {
                tabelDataSKPIMahasiswa.DataSource = MahasiswaContext.showDataSKPIMahasiswa();
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }
    }
}
