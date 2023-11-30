namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class FormEntryDataSertifikasi
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
            lbl_bukti = new Label();
            lbl_tingkat = new Label();
            txt_nama = new TextBox();
            lbl_ket = new Label();
            lbl_tgl = new Label();
            lbl_nama = new Label();
            lbl_judul = new Label();
            txt_bukti = new TextBox();
            txt_tingkat = new TextBox();
            check_hari = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            button2 = new Button();
            btn_simpan = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // lbl_bukti
            // 
            lbl_bukti.AutoSize = true;
            lbl_bukti.Location = new Point(40, 314);
            lbl_bukti.Margin = new Padding(2, 0, 2, 0);
            lbl_bukti.Name = "lbl_bukti";
            lbl_bukti.Size = new Size(69, 20);
            lbl_bukti.TabIndex = 36;
            lbl_bukti.Text = "File Bukti";
            // 
            // lbl_tingkat
            // 
            lbl_tingkat.AutoSize = true;
            lbl_tingkat.Location = new Point(40, 265);
            lbl_tingkat.Margin = new Padding(2, 0, 2, 0);
            lbl_tingkat.Name = "lbl_tingkat";
            lbl_tingkat.Size = new Size(150, 20);
            lbl_tingkat.TabIndex = 35;
            lbl_tingkat.Text = "Nama Penyelenggara";
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(252, 120);
            txt_nama.Margin = new Padding(2);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(349, 27);
            txt_nama.TabIndex = 28;
            // 
            // lbl_ket
            // 
            lbl_ket.AutoSize = true;
            lbl_ket.Location = new Point(40, 220);
            lbl_ket.Margin = new Padding(2, 0, 2, 0);
            lbl_ket.Name = "lbl_ket";
            lbl_ket.Size = new Size(159, 20);
            lbl_ket.TabIndex = 27;
            lbl_ket.Text = "Tingkat Penyelenggara";
            // 
            // lbl_tgl
            // 
            lbl_tgl.AutoSize = true;
            lbl_tgl.Location = new Point(40, 173);
            lbl_tgl.Margin = new Padding(2, 0, 2, 0);
            lbl_tgl.Name = "lbl_tgl";
            lbl_tgl.Size = new Size(145, 20);
            lbl_tgl.TabIndex = 26;
            lbl_tgl.Text = "Tanggal Pelaksanaan";
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.Location = new Point(40, 125);
            lbl_nama.Margin = new Padding(2, 0, 2, 0);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(117, 20);
            lbl_nama.TabIndex = 25;
            lbl_nama.Text = "Nama Sertifikasi";
            // 
            // lbl_judul
            // 
            lbl_judul.AutoSize = true;
            lbl_judul.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_judul.Location = new Point(182, 42);
            lbl_judul.Margin = new Padding(2, 0, 2, 0);
            lbl_judul.Name = "lbl_judul";
            lbl_judul.Size = new Size(318, 41);
            lbl_judul.TabIndex = 24;
            lbl_judul.Text = "Entry Data Sertifikasi";
            lbl_judul.Click += lbl_judul_Click;
            // 
            // txt_bukti
            // 
            txt_bukti.Location = new Point(252, 314);
            txt_bukti.Margin = new Padding(2);
            txt_bukti.Name = "txt_bukti";
            txt_bukti.Size = new Size(349, 27);
            txt_bukti.TabIndex = 39;
            // 
            // txt_tingkat
            // 
            txt_tingkat.Location = new Point(252, 270);
            txt_tingkat.Margin = new Padding(2);
            txt_tingkat.Name = "txt_tingkat";
            txt_tingkat.Size = new Size(349, 27);
            txt_tingkat.TabIndex = 38;
            // 
            // check_hari
            // 
            check_hari.AutoSize = true;
            check_hari.Location = new Point(492, 175);
            check_hari.Margin = new Padding(2);
            check_hari.Name = "check_hari";
            check_hari.Size = new Size(135, 24);
            check_hari.TabIndex = 66;
            check_hari.Text = "lebih dari 1 hari";
            check_hari.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(382, 173);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(91, 27);
            dateTimePicker2.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 176);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 64;
            label1.Text = "s/d";
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(398, 405);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 63;
            button2.Text = "Kembali";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.MidnightBlue;
            btn_simpan.ForeColor = SystemColors.ButtonFace;
            btn_simpan.Location = new Point(510, 405);
            btn_simpan.Margin = new Padding(2);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(90, 27);
            btn_simpan.TabIndex = 62;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(252, 172);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(91, 27);
            dateTimePicker1.TabIndex = 61;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Pilih Tingkat Penyeleggara", "Internasional", "Nasional" });
            comboBox3.Location = new Point(252, 220);
            comboBox3.Margin = new Padding(2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(346, 28);
            comboBox3.TabIndex = 79;
            // 
            // FormEntryDataSertifikasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 470);
            Controls.Add(comboBox3);
            Controls.Add(check_hari);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btn_simpan);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_bukti);
            Controls.Add(txt_tingkat);
            Controls.Add(lbl_bukti);
            Controls.Add(lbl_tingkat);
            Controls.Add(txt_nama);
            Controls.Add(lbl_ket);
            Controls.Add(lbl_tgl);
            Controls.Add(lbl_nama);
            Controls.Add(lbl_judul);
            Margin = new Padding(2);
            Name = "FormEntryDataSertifikasi";
            Text = "EntryDataSertifikasi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_bukti;
        private Label lbl_tingkat;
        private TextBox txt_nama;
        private Label lbl_ket;
        private Label lbl_tgl;
        private Label lbl_nama;
        private Label lbl_judul;
        private TextBox txt_bukti;
        private TextBox txt_tingkat;
        private CheckBox check_hari;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Button button2;
        private Button btn_simpan;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
    }
}