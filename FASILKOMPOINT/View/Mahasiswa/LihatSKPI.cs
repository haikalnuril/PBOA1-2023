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
    public partial class LihatSKPI : Form
    {
        public LihatSKPI()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); // Sembunyikan form saat ini
            BerandaMahasiswa berandaMahasiswa = new BerandaMahasiswa();
            berandaMahasiswa.Show();
        }
    }
}
