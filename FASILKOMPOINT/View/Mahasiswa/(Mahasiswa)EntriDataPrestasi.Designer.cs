namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class EntriDataPrestasi
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lbl_nama = new Label();
            lbl_tgl = new Label();
            lbl_ket = new Label();
            txt_nama = new TextBox();
            imageList1 = new ImageList(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dateTimePicker1 = new DateTimePicker();
            txt_url = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_jenis = new TextBox();
            txt_tingkat = new TextBox();
            txt_juara = new TextBox();
            txt_bukti = new TextBox();
            button2 = new Button();
            btn_simpan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 32);
            label1.TabIndex = 0;
            label1.Text = "Entry Data Prestasi";
            label1.Click += label1_Click;
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.Location = new Point(26, 79);
            lbl_nama.Margin = new Padding(2, 0, 2, 0);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(82, 15);
            lbl_nama.TabIndex = 1;
            lbl_nama.Text = "Nama Prestasi";
            lbl_nama.Click += lbl_nama_Click;
            // 
            // lbl_tgl
            // 
            lbl_tgl.AutoSize = true;
            lbl_tgl.Location = new Point(26, 115);
            lbl_tgl.Margin = new Padding(2, 0, 2, 0);
            lbl_tgl.Name = "lbl_tgl";
            lbl_tgl.Size = new Size(116, 15);
            lbl_tgl.TabIndex = 4;
            lbl_tgl.Text = "Tanggal Pelaksanaan";
            lbl_tgl.Click += label5_Click;
            // 
            // lbl_ket
            // 
            lbl_ket.AutoSize = true;
            lbl_ket.Location = new Point(26, 150);
            lbl_ket.Margin = new Padding(2, 0, 2, 0);
            lbl_ket.Name = "lbl_ket";
            lbl_ket.Size = new Size(103, 15);
            lbl_ket.TabIndex = 5;
            lbl_ket.Text = "Url Penyelenggara";
            lbl_ket.Click += label6_Click;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(212, 75);
            txt_nama.Margin = new Padding(2);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(306, 23);
            txt_nama.TabIndex = 7;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(212, 111);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(78, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // txt_url
            // 
            txt_url.Location = new Point(212, 146);
            txt_url.Margin = new Padding(2);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(306, 23);
            txt_url.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 249);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 19;
            label2.Text = "Juara";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 185);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 20;
            label3.Text = "Jenis Kepesertaan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 249);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 216);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 22;
            label5.Text = "Level/Tingkat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 286);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 23;
            label6.Text = "File Bukti";
            // 
            // txt_jenis
            // 
            txt_jenis.Location = new Point(212, 182);
            txt_jenis.Margin = new Padding(2);
            txt_jenis.Name = "txt_jenis";
            txt_jenis.Size = new Size(306, 23);
            txt_jenis.TabIndex = 24;
            // 
            // txt_tingkat
            // 
            txt_tingkat.Location = new Point(212, 216);
            txt_tingkat.Margin = new Padding(2);
            txt_tingkat.Name = "txt_tingkat";
            txt_tingkat.Size = new Size(306, 23);
            txt_tingkat.TabIndex = 25;
            // 
            // txt_juara
            // 
            txt_juara.Location = new Point(212, 249);
            txt_juara.Margin = new Padding(2);
            txt_juara.Name = "txt_juara";
            txt_juara.Size = new Size(306, 23);
            txt_juara.TabIndex = 26;
            // 
            // txt_bukti
            // 
            txt_bukti.Location = new Point(212, 283);
            txt_bukti.Margin = new Padding(2);
            txt_bukti.Name = "txt_bukti";
            txt_bukti.Size = new Size(306, 23);
            txt_bukti.TabIndex = 27;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(340, 334);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(79, 25);
            button2.TabIndex = 34;
            button2.Text = "Kembali";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.Blue;
            btn_simpan.ForeColor = SystemColors.ButtonFace;
            btn_simpan.Location = new Point(438, 334);
            btn_simpan.Margin = new Padding(2);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(79, 25);
            btn_simpan.TabIndex = 33;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            // 
            // EntriDataPrestasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 367);
            Controls.Add(button2);
            Controls.Add(btn_simpan);
            Controls.Add(txt_bukti);
            Controls.Add(txt_juara);
            Controls.Add(txt_tingkat);
            Controls.Add(txt_jenis);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_url);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_nama);
            Controls.Add(lbl_ket);
            Controls.Add(lbl_tgl);
            Controls.Add(lbl_nama);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "EntriDataPrestasi";
            Text = "EntriDataSKPI";
            Load += EntriDataSKPI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_nama;
        private Label lbl_tgl;
        private Label lbl_ket;
        private TextBox txt_nama;
        private ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_url;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_jenis;
        private TextBox txt_tingkat;
        private TextBox txt_juara;
        private TextBox txt_bukti;
        private Button button2;
        private Button btn_simpan;
    }
}