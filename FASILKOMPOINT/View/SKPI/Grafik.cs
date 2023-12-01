using FASILKOMPOINT.App.Context;
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
using System.Windows.Forms.DataVisualization.Charting;

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
            DataTable result = GrafikContext.grafikPrestasi();

            Series seriesPrestasi = chart1.Series.Add("Prestasi");

            chart1.DataSource = result;

            seriesPrestasi.XValueMember = "tahun";
            seriesPrestasi.YValueMembers = "jumlah_prestasi";

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            seriesPrestasi.ChartType = SeriesChartType.Column;
        }
        private void Halaman_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllForms.CloseHiddenForms(this);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
