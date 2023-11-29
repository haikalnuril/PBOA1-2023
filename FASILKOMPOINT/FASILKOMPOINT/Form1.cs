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
    public partial class Form1 : Form //NYOBA FITUR DATA SKPI MAHASISWA - TIM SKPI
    {
        public string username;
        public Form1()
        {
            InitializeComponent();
            TabelData.DataSource = MahasiswaContext.showDataSKPIMahasiswa();

            ///TabelData.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TabelData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void caributton_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchtb.Text))
            {
                TabelData.DataSource = MahasiswaContext.showDataSKPIMahasiswa();
             }
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
            string nim = searchtb.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(nim))
                {
                    TabelData.DataSource = MahasiswaContext.showDataSKPIMahasiswa();
                }
                else
                {
                    TabelData.DataSource = MahasiswaContext.showSearchDataSKPIMahasiswa(nim);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //        private void SearchNama_TextChanged(object sender, EventArgs e)
        //        {
        //            if (string.IsNullOrWhiteSpace(SearchNama.Text))
        //            {
        //                tabelDataSKPIMahasiswa.DataSource = MahasiswaContext.showDataSKPIMahasiswa();
        //            }
        //        }

        //        private void ButtonSearch_Click(object sender, EventArgs e)
        //        {
        //            ExecuteSearch();
        //        }
    }
}