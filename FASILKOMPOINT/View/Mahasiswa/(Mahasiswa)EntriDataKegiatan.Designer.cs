namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class EntriDataKegiatan
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
            txt_bukti = new TextBox();
            txt_tingkat = new TextBox();
            lbl_bukti = new Label();
            lbl_tingkat = new Label();
            txt_url = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txt_nama = new TextBox();
            lbl_ket = new Label();
            lbl_tgl = new Label();
            lbl_nama = new Label();
            lbl_judul = new Label();
            button2 = new Button();
            btn_simpan = new Button();
            SuspendLayout();
            // 
            // txt_bukti
            // 
            txt_bukti.Location = new Point(245, 297);
            txt_bukti.Margin = new Padding(2, 3, 2, 3);
            txt_bukti.Name = "txt_bukti";
            txt_bukti.Size = new Size(349, 27);
            txt_bukti.TabIndex = 52;
            // 
            // txt_tingkat
            // 
            txt_tingkat.Location = new Point(245, 252);
            txt_tingkat.Margin = new Padding(2, 3, 2, 3);
            txt_tingkat.Name = "txt_tingkat";
            txt_tingkat.Size = new Size(349, 27);
            txt_tingkat.TabIndex = 51;
            // 
            // lbl_bukti
            // 
            lbl_bukti.AutoSize = true;
            lbl_bukti.Location = new Point(32, 297);
            lbl_bukti.Margin = new Padding(2, 0, 2, 0);
            lbl_bukti.Name = "lbl_bukti";
            lbl_bukti.Size = new Size(69, 20);
            lbl_bukti.TabIndex = 50;
            lbl_bukti.Text = "File Bukti";
            // 
            // lbl_tingkat
            // 
            lbl_tingkat.AutoSize = true;
            lbl_tingkat.Location = new Point(32, 247);
            lbl_tingkat.Margin = new Padding(2, 0, 2, 0);
            lbl_tingkat.Name = "lbl_tingkat";
            lbl_tingkat.Size = new Size(98, 20);
            lbl_tingkat.TabIndex = 49;
            lbl_tingkat.Text = "Level/Tingkat";
            // 
            // txt_url
            // 
            txt_url.Location = new Point(245, 197);
            txt_url.Margin = new Padding(2, 3, 2, 3);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(349, 27);
            txt_url.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(245, 149);
            dateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 27);
            dateTimePicker1.TabIndex = 45;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(245, 101);
            txt_nama.Margin = new Padding(2, 3, 2, 3);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(349, 27);
            txt_nama.TabIndex = 44;
            // 
            // lbl_ket
            // 
            lbl_ket.AutoSize = true;
            lbl_ket.Location = new Point(32, 203);
            lbl_ket.Margin = new Padding(2, 0, 2, 0);
            lbl_ket.Name = "lbl_ket";
            lbl_ket.Size = new Size(126, 20);
            lbl_ket.TabIndex = 43;
            lbl_ket.Text = "Jenis Kepesertaan";
            // 
            // lbl_tgl
            // 
            lbl_tgl.AutoSize = true;
            lbl_tgl.Location = new Point(32, 155);
            lbl_tgl.Margin = new Padding(2, 0, 2, 0);
            lbl_tgl.Name = "lbl_tgl";
            lbl_tgl.Size = new Size(145, 20);
            lbl_tgl.TabIndex = 42;
            lbl_tgl.Text = "Tanggal Pelaksanaan";
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.Location = new Point(32, 107);
            lbl_nama.Margin = new Padding(2, 0, 2, 0);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(112, 20);
            lbl_nama.TabIndex = 41;
            lbl_nama.Text = "Nama Kegiatan";
            // 
            // lbl_judul
            // 
            lbl_judul.AutoSize = true;
            lbl_judul.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_judul.Location = new Point(174, 25);
            lbl_judul.Margin = new Padding(2, 0, 2, 0);
            lbl_judul.Name = "lbl_judul";
            lbl_judul.Size = new Size(300, 41);
            lbl_judul.TabIndex = 40;
            lbl_judul.Text = "Entry Data Kegiatan";
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(390, 383);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(90, 37);
            button2.TabIndex = 54;
            button2.Text = "Kembali";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = SystemColors.HotTrack;
            btn_simpan.ForeColor = SystemColors.ButtonFace;
            btn_simpan.Location = new Point(502, 383);
            btn_simpan.Margin = new Padding(2, 3, 2, 3);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(90, 37);
            btn_simpan.TabIndex = 53;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // EntriDataKegiatan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 451);
            Controls.Add(button2);
            Controls.Add(btn_simpan);
            Controls.Add(txt_bukti);
            Controls.Add(txt_tingkat);
            Controls.Add(lbl_bukti);
            Controls.Add(lbl_tingkat);
            Controls.Add(txt_url);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_nama);
            Controls.Add(lbl_ket);
            Controls.Add(lbl_tgl);
            Controls.Add(lbl_nama);
            Controls.Add(lbl_judul);
            Margin = new Padding(2, 3, 2, 3);
            Name = "EntriDataKegiatan";
            Text = "EntriDataKegiatan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_bukti;
        private TextBox txt_tingkat;
        private Label lbl_bukti;
        private Label lbl_tingkat;
        private TextBox txt_url;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_nama;
        private Label lbl_ket;
        private Label lbl_tgl;
        private Label lbl_nama;
        private Label lbl_judul;
        private Button button2;
        private Button btn_simpan;
    }
}