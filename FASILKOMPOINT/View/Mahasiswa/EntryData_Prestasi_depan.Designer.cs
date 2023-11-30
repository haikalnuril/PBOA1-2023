namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class EntryData_Prestasi_depan
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
            Nama_prestasi = new DataGridViewTextBoxColumn();
            Tanggal_Pelaksanaan = new DataGridViewTextBoxColumn();
            Keterangan = new DataGridViewTextBoxColumn();
            Approval = new DataGridViewTextBoxColumn();
            Aksi = new DataGridViewTextBoxColumn();
            btn_prestasi = new Button();
            btn_kegiatan = new Button();
            btn_sertifikasi = new Button();
            btnTambah_Click = new Button();
            Nama = new DataGridViewTextBoxColumn();
            cmb_prestasi = new ComboBox();
            lbl_cari = new Label();
            txt_cari = new TextBox();
            lbl_tampilkan = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btn_previous = new Button();
            cmb_tahun = new ComboBox();
            lbl_tahun_dan_prestasi = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Nama_prestasi, Tanggal_Pelaksanaan, Keterangan, Approval, Aksi });
            dataGridView.Location = new Point(140, 150);
            dataGridView.Margin = new Padding(2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(640, 294);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Nama_prestasi
            // 
            Nama_prestasi.HeaderText = "Nama Prestasi";
            Nama_prestasi.MinimumWidth = 8;
            Nama_prestasi.Name = "Nama_prestasi";
            Nama_prestasi.Width = 150;
            // 
            // Tanggal_Pelaksanaan
            // 
            Tanggal_Pelaksanaan.HeaderText = "Tanggal Pelaksanaan";
            Tanggal_Pelaksanaan.MinimumWidth = 8;
            Tanggal_Pelaksanaan.Name = "Tanggal_Pelaksanaan";
            Tanggal_Pelaksanaan.Width = 150;
            // 
            // Keterangan
            // 
            Keterangan.HeaderText = "Keterangan";
            Keterangan.MinimumWidth = 8;
            Keterangan.Name = "Keterangan";
            Keterangan.Width = 150;
            // 
            // Approval
            // 
            Approval.HeaderText = "Approval";
            Approval.MinimumWidth = 8;
            Approval.Name = "Approval";
            Approval.Width = 150;
            // 
            // Aksi
            // 
            Aksi.HeaderText = "Aksi";
            Aksi.MinimumWidth = 8;
            Aksi.Name = "Aksi";
            Aksi.Width = 150;
            // 
            // btn_prestasi
            // 
            btn_prestasi.BackColor = SystemColors.HighlightText;
            btn_prestasi.ForeColor = SystemColors.ActiveCaptionText;
            btn_prestasi.Location = new Point(26, 150);
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
            btn_kegiatan.BackColor = SystemColors.HighlightText;
            btn_kegiatan.ForeColor = SystemColors.ActiveCaptionText;
            btn_kegiatan.Location = new Point(26, 206);
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
            btn_sertifikasi.BackColor = SystemColors.HighlightText;
            btn_sertifikasi.ForeColor = SystemColors.ActiveCaptionText;
            btn_sertifikasi.Location = new Point(26, 264);
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
            btnTambah_Click.BackColor = Color.DarkGreen;
            btnTambah_Click.ForeColor = SystemColors.ButtonHighlight;
            btnTambah_Click.Location = new Point(683, 44);
            btnTambah_Click.Margin = new Padding(2);
            btnTambah_Click.Name = "btnTambah_Click";
            btnTambah_Click.Size = new Size(98, 31);
            btnTambah_Click.TabIndex = 4;
            btnTambah_Click.Text = "Tambah";
            btnTambah_Click.UseVisualStyleBackColor = false;
            btnTambah_Click.Click += btnTambah_Click_Click;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama Prestasi";
            Nama.MinimumWidth = 8;
            Nama.Name = "Nama";
            Nama.Width = 150;
            // 
            // cmb_prestasi
            // 
            cmb_prestasi.FormattingEnabled = true;
            cmb_prestasi.Items.AddRange(new object[] { "Semua", "Ormawa Universitas", "Ormawa Fakultas", "Mandiri" });
            cmb_prestasi.Location = new Point(501, 44);
            cmb_prestasi.Margin = new Padding(2);
            cmb_prestasi.Name = "cmb_prestasi";
            cmb_prestasi.Size = new Size(114, 28);
            cmb_prestasi.TabIndex = 7;
            // 
            // lbl_cari
            // 
            lbl_cari.AutoSize = true;
            lbl_cari.Location = new Point(573, 108);
            lbl_cari.Margin = new Padding(2, 0, 2, 0);
            lbl_cari.Name = "lbl_cari";
            lbl_cari.Size = new Size(42, 20);
            lbl_cari.TabIndex = 8;
            lbl_cari.Text = "Cari :";
            // 
            // txt_cari
            // 
            txt_cari.Location = new Point(617, 106);
            txt_cari.Margin = new Padding(2);
            txt_cari.Name = "txt_cari";
            txt_cari.Size = new Size(164, 27);
            txt_cari.TabIndex = 29;
            // 
            // lbl_tampilkan
            // 
            lbl_tampilkan.AutoSize = true;
            lbl_tampilkan.Location = new Point(140, 108);
            lbl_tampilkan.Margin = new Padding(2, 0, 2, 0);
            lbl_tampilkan.Name = "lbl_tampilkan";
            lbl_tampilkan.Size = new Size(76, 20);
            lbl_tampilkan.TabIndex = 30;
            lbl_tampilkan.Text = "Tampilkan";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "20", "10", "5", "3" });
            comboBox1.Location = new Point(218, 106);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(45, 28);
            comboBox1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 454);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 32;
            label2.Text = "Menampikan 0 dari 0 data";
            // 
            // btn_previous
            // 
            btn_previous.BackColor = Color.White;
            btn_previous.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btn_previous.ForeColor = SystemColors.ControlText;
            btn_previous.Location = new Point(26, 44);
            btn_previous.Margin = new Padding(2);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(98, 39);
            btn_previous.TabIndex = 34;
            btn_previous.Text = "Kembali";
            btn_previous.UseVisualStyleBackColor = false;
            btn_previous.Click += btn_previous_Click;
            // 
            // cmb_tahun
            // 
            cmb_tahun.FormattingEnabled = true;
            cmb_tahun.Items.AddRange(new object[] { "2023", "2022", "2021", "2020", "2019", "2018", "2017" });
            cmb_tahun.Location = new Point(407, 43);
            cmb_tahun.Margin = new Padding(2);
            cmb_tahun.Name = "cmb_tahun";
            cmb_tahun.Size = new Size(80, 28);
            cmb_tahun.TabIndex = 6;
            // 
            // lbl_tahun_dan_prestasi
            // 
            lbl_tahun_dan_prestasi.AutoSize = true;
            lbl_tahun_dan_prestasi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tahun_dan_prestasi.Location = new Point(223, 43);
            lbl_tahun_dan_prestasi.Margin = new Padding(2, 0, 2, 0);
            lbl_tahun_dan_prestasi.Name = "lbl_tahun_dan_prestasi";
            lbl_tahun_dan_prestasi.Size = new Size(178, 25);
            lbl_tahun_dan_prestasi.TabIndex = 5;
            lbl_tahun_dan_prestasi.Text = "Tahun dan Prestasi";
            // 
            // EntryData_Prestasi_depan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 523);
            Controls.Add(btn_previous);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(lbl_tampilkan);
            Controls.Add(txt_cari);
            Controls.Add(lbl_cari);
            Controls.Add(cmb_prestasi);
            Controls.Add(cmb_tahun);
            Controls.Add(lbl_tahun_dan_prestasi);
            Controls.Add(btnTambah_Click);
            Controls.Add(btn_sertifikasi);
            Controls.Add(btn_kegiatan);
            Controls.Add(btn_prestasi);
            Controls.Add(dataGridView);
            Margin = new Padding(2);
            Name = "EntryData_Prestasi_depan";
            Text = "EntryData";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btn_prestasi;
        private Button btn_kegiatan;
        private Button btn_sertifikasi;
        private Button btnTambah_Click;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Nama_prestasi;
        private DataGridViewTextBoxColumn Tanggal_Pelaksanaan;
        private DataGridViewTextBoxColumn Keterangan;
        private DataGridViewTextBoxColumn Approval;
        private DataGridViewTextBoxColumn Aksi;
        private ComboBox cmb_prestasi;
        private Label lbl_cari;
        private TextBox txt_cari;
        private Label lbl_tampilkan;
        private ComboBox comboBox1;
        private Label label2;
        private Button btn_previous;
        private ComboBox cmb_tahun;
        private Label lbl_tahun_dan_prestasi;
    }
}