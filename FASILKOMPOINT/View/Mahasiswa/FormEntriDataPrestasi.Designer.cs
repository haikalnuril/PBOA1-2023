namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class FormEntriDataPrestasi
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
            txt_url = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_bukti = new TextBox();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            check_hari = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            label9 = new Label();
            button3 = new Button();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            txt_nampem = new TextBox();
            txt_notugas = new TextBox();
            lbl_pembimbing = new Label();
            lbl_nosurat = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(195, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 41);
            label1.TabIndex = 0;
            label1.Text = "Entry Data Prestasi";
            label1.Click += label1_Click;
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.Location = new Point(30, 105);
            lbl_nama.Margin = new Padding(2, 0, 2, 0);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(103, 20);
            lbl_nama.TabIndex = 1;
            lbl_nama.Text = "Nama Prestasi";
            lbl_nama.Click += lbl_nama_Click;
            // 
            // lbl_tgl
            // 
            lbl_tgl.AutoSize = true;
            lbl_tgl.Location = new Point(30, 153);
            lbl_tgl.Margin = new Padding(2, 0, 2, 0);
            lbl_tgl.Name = "lbl_tgl";
            lbl_tgl.Size = new Size(145, 20);
            lbl_tgl.TabIndex = 4;
            lbl_tgl.Text = "Tanggal Pelaksanaan";
            lbl_tgl.Click += label5_Click;
            // 
            // lbl_ket
            // 
            lbl_ket.AutoSize = true;
            lbl_ket.Location = new Point(30, 200);
            lbl_ket.Margin = new Padding(2, 0, 2, 0);
            lbl_ket.Name = "lbl_ket";
            lbl_ket.Size = new Size(129, 20);
            lbl_ket.TabIndex = 5;
            lbl_ket.Text = "Url Penyelenggara";
            lbl_ket.Click += label6_Click;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(242, 100);
            txt_nama.Margin = new Padding(2, 2, 2, 2);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(349, 27);
            txt_nama.TabIndex = 7;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // txt_url
            // 
            txt_url.Location = new Point(242, 195);
            txt_url.Margin = new Padding(2, 2, 2, 2);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(349, 27);
            txt_url.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 347);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 19;
            label2.Text = "Juara";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 332);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 251);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 22;
            label5.Text = "Level/Tingkat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 397);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 23;
            label6.Text = "File Bukti";
            // 
            // txt_bukti
            // 
            txt_bukti.Location = new Point(245, 392);
            txt_bukti.Margin = new Padding(2, 2, 2, 2);
            txt_bukti.Name = "txt_bukti";
            txt_bukti.Size = new Size(349, 27);
            txt_bukti.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(354, 295);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(31, 27);
            button1.TabIndex = 69;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(245, 299);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 68;
            label7.Text = "(Tampilan NIM)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 299);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 67;
            label8.Text = "NIM Peserta";
            // 
            // check_hari
            // 
            check_hari.AutoSize = true;
            check_hari.Location = new Point(485, 151);
            check_hari.Margin = new Padding(2, 2, 2, 2);
            check_hari.Name = "check_hari";
            check_hari.Size = new Size(135, 24);
            check_hari.TabIndex = 66;
            check_hari.Text = "lebih dari 1 hari";
            check_hari.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(375, 149);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(91, 27);
            dateTimePicker2.TabIndex = 65;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(340, 152);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(30, 20);
            label9.TabIndex = 64;
            label9.Text = "s/d";
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(386, 549);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 63;
            button3.Text = "Kembali";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(498, 549);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(90, 27);
            button4.TabIndex = 62;
            button4.Text = "Simpan";
            button4.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(245, 148);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(91, 27);
            dateTimePicker1.TabIndex = 61;
            // 
            // txt_nampem
            // 
            txt_nampem.Location = new Point(245, 487);
            txt_nampem.Margin = new Padding(2, 2, 2, 2);
            txt_nampem.Name = "txt_nampem";
            txt_nampem.Size = new Size(349, 27);
            txt_nampem.TabIndex = 73;
            // 
            // txt_notugas
            // 
            txt_notugas.Location = new Point(245, 442);
            txt_notugas.Margin = new Padding(2, 2, 2, 2);
            txt_notugas.Name = "txt_notugas";
            txt_notugas.Size = new Size(349, 27);
            txt_notugas.TabIndex = 72;
            // 
            // lbl_pembimbing
            // 
            lbl_pembimbing.AutoSize = true;
            lbl_pembimbing.Location = new Point(33, 492);
            lbl_pembimbing.Margin = new Padding(2, 0, 2, 0);
            lbl_pembimbing.Name = "lbl_pembimbing";
            lbl_pembimbing.Size = new Size(137, 20);
            lbl_pembimbing.TabIndex = 71;
            lbl_pembimbing.Text = "Nama Pembimbing";
            // 
            // lbl_nosurat
            // 
            lbl_nosurat.AutoSize = true;
            lbl_nosurat.Location = new Point(33, 442);
            lbl_nosurat.Margin = new Padding(2, 0, 2, 0);
            lbl_nosurat.Name = "lbl_nosurat";
            lbl_nosurat.Size = new Size(201, 20);
            lbl_nosurat.TabIndex = 70;
            lbl_nosurat.Text = "No. Surat Tugas Pembimbing";
            lbl_nosurat.Click += label11_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Pilih Level", "Fakultas", "Universitas", "Jurusan", "Nasional", "Internasional", "Propinsi", "Kab/Kota", "Wilayah/Regional" });
            comboBox2.Location = new Point(242, 245);
            comboBox2.Margin = new Padding(2, 2, 2, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(346, 28);
            comboBox2.TabIndex = 75;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Pilih Juara", "Juara Lain", "Juara I", "Juara II", "Juara III" });
            comboBox3.Location = new Point(242, 341);
            comboBox3.Margin = new Padding(2, 2, 2, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(346, 28);
            comboBox3.TabIndex = 76;
            // 
            // FormEntriDataPrestasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 599);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(txt_nampem);
            Controls.Add(txt_notugas);
            Controls.Add(lbl_pembimbing);
            Controls.Add(lbl_nosurat);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(check_hari);
            Controls.Add(dateTimePicker2);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_bukti);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txt_url);
            Controls.Add(txt_nama);
            Controls.Add(lbl_ket);
            Controls.Add(lbl_tgl);
            Controls.Add(lbl_nama);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormEntriDataPrestasi";
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
        private TextBox txt_url;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_bukti;
        private Button button1;
        private Label label7;
        private Label label8;
        private CheckBox check_hari;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_nampem;
        private TextBox txt_notugas;
        private Label lbl_pembimbing;
        private Label lbl_nosurat;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}