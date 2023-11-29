using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FASILKOMPOINT.App.Context;
using System.Windows.Forms;

namespace FASILKOMPOINT
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            TabelData2.DataSource = MahasiswaContext.showDetailValidasiSKPI("222410101001");
            // Membuat kolom checkbox
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Terima";
            checkboxColumn.Name = "checkBoxColumn";
            TabelData2.Columns.Add(checkboxColumn);

            DataGridViewCheckBoxColumn checkboxColumn1 = new DataGridViewCheckBoxColumn();
            checkboxColumn1.HeaderText = "Tolak";
            checkboxColumn1.Name = "checkBoxColumn1";
            TabelData2.Columns.Add(checkboxColumn1);

            // Membuat kolom textbox
            DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn();
            textBoxColumn.HeaderText = "Nama Kolom";
            textBoxColumn.Name = "textBoxColumn";
            TabelData2.Columns.Add(textBoxColumn);

            TabelData2.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
