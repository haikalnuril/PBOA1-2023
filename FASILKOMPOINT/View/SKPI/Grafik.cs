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

namespace FASILKOMPOINT.View.SKPI
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }

        private void Grafik_Load(object sender, EventArgs e)
        {

        }
        private void Halaman_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllForms.CloseHiddenForms(this);
        }
    }
}
