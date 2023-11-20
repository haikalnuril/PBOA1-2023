using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fasilkom_Point
{
    public partial class EntriDataKegiatan : Form
    {
        public EntriDataKegiatan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Sembunyikan form saat ini
            EntryData EntryData = new EntryData();
            EntryData.Show();
        }
    }
}
