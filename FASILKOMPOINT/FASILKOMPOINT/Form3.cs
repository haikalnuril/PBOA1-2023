using FASILKOMPOINT.App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT
{
    public partial class Form3 : Form
    {
        private int akumulasipoin = AktivitasKeikutsertaanContext.AkumulasiPoin("222410101001");

        public Form3()
        {
            InitializeComponent();
            AkumulasiLabel.Text = akumulasipoin.ToString();
            TabelData1.DataSource = AktivitasPrestasiContext.showPrestasi("222410101001", 602);
            TabelData1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void TitleAkumulasiLabel_Click(object sender, EventArgs e)
        {

        }

        private void AkumulasiLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TabelData1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prestasibutton_Click(object sender, EventArgs e)
        {
            int kategori = 602;
            TabelData1.DataSource = AktivitasPrestasiContext.showPrestasi("222410101001", kategori);
        }

        private void keikutsertaanbutton_Click(object sender, EventArgs e)
        {
            int kategori = 601;
            TabelData1.DataSource = AktivitasKeikutsertaanContext.showKeikutsertaan("222410101001", kategori);
        }
        private void sertifikasibutton_Click(object sender, EventArgs e)
        {
            int kategori = 601;
            TabelData1.DataSource = AktivitasSertifikasiContext.showSertifikasi("222410101001", kategori);
        }
    }
}