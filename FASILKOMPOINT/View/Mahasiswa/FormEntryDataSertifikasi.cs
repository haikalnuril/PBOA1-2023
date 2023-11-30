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
        public FormEntryDataSertifikasi()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_judul_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntryData_Prestasi_depan entryData_Prestasi_Depan = new EntryData_Prestasi_depan();
            entryData_Prestasi_Depan.Show();
            this.Hide();
        }
    }
}
