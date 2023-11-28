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
        private int akumulasipoin = AktivitasKeikutsertaanContext.AkumulasiPoin("222410101004");

        public Form3()
        {
            InitializeComponent();
            AkumulasiLabel.Text = akumulasipoin.ToString();

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
    }
}