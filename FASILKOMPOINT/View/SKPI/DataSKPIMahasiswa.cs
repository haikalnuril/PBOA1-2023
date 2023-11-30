using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.View.SKPI
{
    public partial class DataSKPIMahasiswa : Form
    {
        public DataSKPIMahasiswa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BerandaSKPI form = new BerandaSKPI();
            form.Show();
            this.Hide();
        }

        private void DataSKPIMahasiswa_Load(object sender, EventArgs e)
        {

        }
    }
}
