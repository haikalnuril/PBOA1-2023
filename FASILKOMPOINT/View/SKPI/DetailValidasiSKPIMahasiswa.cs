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

namespace FASILKOMPOINT.View.SKPI
{
    public partial class DetailValidasiSKPIMahasiswa : Form
    {
        public string nim { get; set; }
        public DetailValidasiSKPIMahasiswa()
        {
            InitializeComponent();
            ValidasiSKPIMahasiswa validasiSKPIMahasiswa = Application.OpenForms["ValidasiSKPIMahasiswa"] as ValidasiSKPIMahasiswa;
            if (validasiSKPIMahasiswa != null)
            {
                string nim = validasiSKPIMahasiswa.nim;
                this.nim = nim;

                dataGridView1.DataSource = MahasiswaContext.showDetailValidasiSKPI(nim);
                dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            };
            DataGridViewButtonColumn terimaButton = new DataGridViewButtonColumn();
            terimaButton.HeaderText = "Terima";
            terimaButton.Text = "Terima";
            terimaButton.Name = "terimaButton";
            terimaButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(3, terimaButton);

            DataGridViewButtonColumn tolakButton = new DataGridViewButtonColumn();
            tolakButton.HeaderText = "Tolak";
            tolakButton.Text = "Tolak";
            tolakButton.Name = "tolakButton";
            tolakButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(4, tolakButton);

            dataGridView1.Columns["id_aktivitas"].Visible = false;
            dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["komentar"].ReadOnly = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ValidasiSKPIMahasiswa validasiSKPIMahasiswa = new ValidasiSKPIMahasiswa();
            validasiSKPIMahasiswa.Show();
            this.Hide();
        }

        private void DetailValidasiSKPIMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["tolakButton"].Index && e.RowIndex >= 0)
            {
                int idAktivitas = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_aktivitas"].Value);

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menolak data aktivitas ini?", "Konfirmasi Tolak", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    MahasiswaContext.updateStatustoDitolak(idAktivitas);
                    DialogResult messageTolak = MessageBox.Show("Data berhasil ditolak", "Sukses", MessageBoxButtons.OK);
                }
                dataGridView1.Columns["komentar"].ReadOnly = false;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["terimaButton"].Index && e.RowIndex >= 0)
            {
                int idAktivitas = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_aktivitas"].Value);

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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MahasiswaContext.showDetailValidasiSKPI("222410101001");
            dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void SimpanValidasibutton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int idAktivitas = Convert.ToInt32(row.Cells["id_aktivitas"].Value);

                object cellValue = row.Cells["Komentar"].Value;

                string komentar = (cellValue != null) ? cellValue.ToString() : "";

                MahasiswaContext.updateKomentarDitolak(idAktivitas, komentar);
            }
            MessageBox.Show("Komentar berhasil disimpan!", "Sukses", MessageBoxButtons.OK);
            refreshform();
        }
    }
}
