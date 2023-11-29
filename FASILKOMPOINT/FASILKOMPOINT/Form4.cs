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
            DataGridViewButtonColumn terimaButton = new DataGridViewButtonColumn();
            terimaButton.HeaderText = "Terima";
            terimaButton.Text = "Terima";
            terimaButton.Name = "terimaButton";
            terimaButton.UseColumnTextForButtonValue = true;
            TabelData2.Columns.Insert(3,terimaButton);

            DataGridViewButtonColumn tolakButton = new DataGridViewButtonColumn();
            tolakButton.HeaderText = "Tolak";
            tolakButton.Text = "Tolak";
            tolakButton.Name = "tolakButton";
            tolakButton.UseColumnTextForButtonValue = true;
            TabelData2.Columns.Insert(4,tolakButton);

            TabelData2.Columns["id_aktivitas"].Visible = false;
            TabelData2.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            TabelData2.Columns["komentar"].ReadOnly = true;


        }
        private void TabelData2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TabelData2.Columns["tolakButton"].Index && e.RowIndex >= 0)
            {
                int idAktivitas = Convert.ToInt32(TabelData2.Rows[e.RowIndex].Cells["id_aktivitas"].Value);

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menolak data aktivitas ini?", "Konfirmasi Tolak", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    MahasiswaContext.updateStatustoDitolak(idAktivitas);
                    DialogResult messageTolak = MessageBox.Show("Data berhasil ditolak", "Sukses", MessageBoxButtons.OK);
                }
                TabelData2.Columns["komentar"].ReadOnly = false;
            }
            else if (e.ColumnIndex == TabelData2.Columns["terimaButton"].Index && e.RowIndex >= 0)
            {
                int idAktivitas = Convert.ToInt32(TabelData2.Rows[e.RowIndex].Cells["id_aktivitas"].Value);

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menerima data aktivitas ini?", "Konfirmasi Terima", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    MahasiswaContext.updateStatustoDisetujui(idAktivitas);
                    DialogResult messageTerima = MessageBox.Show("Data berhasil disetujui", "Sukses", MessageBoxButtons.OK);
                }
                refreshform();
            }
        }
        private void refreshform()
        {
            TabelData2.DataSource = null;
            TabelData2.DataSource = MahasiswaContext.showDetailValidasiSKPI("222410101001");
            TabelData2.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void SimpanValidasibutton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in TabelData2.Rows)
            {
                int idAktivitas = Convert.ToInt32(row.Cells["id_aktivitas"].Value);

                // Check for null before accessing the Value property
                object cellValue = row.Cells["Komentar"].Value;

                // Convert the cell value to a string or use an empty string if it's null
                string komentar = (cellValue != null) ? cellValue.ToString() : "";

                // Update the database with the new comment
                MahasiswaContext.updateKomentarDitolak(idAktivitas, komentar);
            }
            MessageBox.Show("Komentar berhasil disimpan!", "Sukses", MessageBoxButtons.OK);
            refreshform();
        }
    }
}
