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
            tabelDataSKPIMahasiswa.DataSource = MahasiswaContext.showDataSKPIMahasiswa();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tabelDataSKPIMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
