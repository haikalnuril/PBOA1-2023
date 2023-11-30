namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class EntryData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            Nomer = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Keterangan = new DataGridViewTextBoxColumn();
            StatusValidasi = new DataGridViewTextBoxColumn();
            Komentar = new DataGridViewTextBoxColumn();
            Poin = new DataGridViewTextBoxColumn();
            btn_prestasi = new Button();
            btn_kegiatan = new Button();
            btn_sertifikasi = new Button();
            btnTambah_Click = new Button();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Nomer, Nama, Keterangan, StatusValidasi, Komentar, Poin });
            dataGridView.Location = new Point(145, 57);
            dataGridView.Margin = new Padding(2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(765, 294);
            dataGridView.TabIndex = 0;
            // 
            // Nomer
            // 
            Nomer.HeaderText = "Nomer";
            Nomer.MinimumWidth = 6;
            Nomer.Name = "Nomer";
            Nomer.Width = 125;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            Nama.Width = 125;
            // 
            // Keterangan
            // 
            Keterangan.HeaderText = "Keterangan";
            Keterangan.MinimumWidth = 6;
            Keterangan.Name = "Keterangan";
            Keterangan.Width = 125;
            // 
            // StatusValidasi
            // 
            StatusValidasi.HeaderText = "Status Validasi";
            StatusValidasi.MinimumWidth = 6;
            StatusValidasi.Name = "StatusValidasi";
            StatusValidasi.Width = 125;
            // 
            // Komentar
            // 
            Komentar.HeaderText = "Komentar";
            Komentar.MinimumWidth = 6;
            Komentar.Name = "Komentar";
            Komentar.Width = 125;
            // 
            // Poin
            // 
            Poin.HeaderText = "Poin";
            Poin.MinimumWidth = 6;
            Poin.Name = "Poin";
            Poin.Width = 125;
            // 
            // btn_prestasi
            // 
            btn_prestasi.BackColor = Color.Transparent;
            btn_prestasi.Location = new Point(16, 57);
            btn_prestasi.Margin = new Padding(2);
            btn_prestasi.Name = "btn_prestasi";
            btn_prestasi.Size = new Size(98, 31);
            btn_prestasi.TabIndex = 1;
            btn_prestasi.Text = "Prestasi";
            btn_prestasi.UseVisualStyleBackColor = false;
            btn_prestasi.Click += button1_Click;
            // 
            // btn_kegiatan
            // 
            btn_kegiatan.BackColor = Color.Transparent;
            btn_kegiatan.Location = new Point(16, 92);
            btn_kegiatan.Margin = new Padding(2);
            btn_kegiatan.Name = "btn_kegiatan";
            btn_kegiatan.Size = new Size(98, 31);
            btn_kegiatan.TabIndex = 2;
            btn_kegiatan.Text = "Kegiatan";
            btn_kegiatan.UseVisualStyleBackColor = false;
            btn_kegiatan.Click += btn_kegiatan_Click;
            // 
            // btn_sertifikasi
            // 
            btn_sertifikasi.BackColor = Color.Transparent;
            btn_sertifikasi.Location = new Point(16, 127);
            btn_sertifikasi.Margin = new Padding(2);
            btn_sertifikasi.Name = "btn_sertifikasi";
            btn_sertifikasi.Size = new Size(98, 31);
            btn_sertifikasi.TabIndex = 3;
            btn_sertifikasi.Text = "Sertifikasi";
            btn_sertifikasi.UseVisualStyleBackColor = false;
            btn_sertifikasi.Click += btn_sertifikasi_Click;
            // 
            // btnTambah_Click
            // 
            btnTambah_Click.BackColor = SystemColors.ButtonHighlight;
            btnTambah_Click.ForeColor = SystemColors.ActiveCaptionText;
            btnTambah_Click.Location = new Point(812, 11);
            btnTambah_Click.Margin = new Padding(2);
            btnTambah_Click.Name = "btnTambah_Click";
            btnTambah_Click.Size = new Size(98, 31);
            btnTambah_Click.TabIndex = 4;
            btnTambah_Click.Text = "Tambah";
            btnTambah_Click.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_prestasi);
            panel1.Controls.Add(btn_sertifikasi);
            panel1.Controls.Add(btn_kegiatan);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 528);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(16, 454);
            button1.Name = "button1";
            button1.Size = new Size(98, 29);
            button1.TabIndex = 4;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // EntryData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 528);
            Controls.Add(btnTambah_Click);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "EntryData";
            Text = "EntryData";
            Load += EntryData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button btn_prestasi;
        private Button btn_kegiatan;
        private Button btn_sertifikasi;
        private Button btnTambah_Click;
        private DataGridViewTextBoxColumn Nomer;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Keterangan;
        private DataGridViewTextBoxColumn StatusValidasi;
        private DataGridViewTextBoxColumn Komentar;
        private DataGridViewTextBoxColumn Poin;
        private Panel panel1;
        private Button button1;
    }
}