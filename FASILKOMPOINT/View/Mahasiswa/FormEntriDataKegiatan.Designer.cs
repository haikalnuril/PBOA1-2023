namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class FormEntriDataKegiatan
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
            lbl_bukti = new Label();
            lbl_tingkat = new Label();
            dateTimePicker1 = new DateTimePicker();
            txt_nama = new TextBox();
            lbl_tgl = new Label();
            lbl_nama = new Label();
            lbl_judul = new Label();
            button2 = new Button();
            btn_simpan = new Button();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            check_hari = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // txt_bukti
            // 
            txt_bukti.Location = new Point(244, 292);
            txt_bukti.Margin = new Padding(2);
            txt_bukti.Name = "txt_bukti";
            txt_bukti.Size = new Size(349, 27);
            txt_bukti.TabIndex = 52;
            // 
            // lbl_bukti
            // 
            lbl_bukti.AutoSize = true;
            lbl_bukti.Location = new Point(32, 292);
            lbl_bukti.Margin = new Padding(2, 0, 2, 0);
            lbl_bukti.Name = "lbl_bukti";
            lbl_bukti.Size = new Size(69, 20);
            lbl_bukti.TabIndex = 50;
            lbl_bukti.Text = "File Bukti";
            // 
            // lbl_tingkat
            // 
            lbl_tingkat.AutoSize = true;
            lbl_tingkat.Location = new Point(32, 242);
            lbl_tingkat.Margin = new Padding(2, 0, 2, 0);
            lbl_tingkat.Name = "lbl_tingkat";
            lbl_tingkat.Size = new Size(98, 20);
            lbl_tingkat.TabIndex = 49;
            lbl_tingkat.Text = "Level/Tingkat";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(244, 150);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(91, 27);
            dateTimePicker1.TabIndex = 45;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(244, 102);
            txt_nama.Margin = new Padding(2);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(349, 27);
            txt_nama.TabIndex = 44;
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
            lbl_judul.Click += lbl_judul_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(390, 355);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 54;
            button2.Text = "Kembali";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.MidnightBlue;
            btn_simpan.ForeColor = SystemColors.ButtonFace;
            btn_simpan.Location = new Point(502, 355);
            btn_simpan.Margin = new Padding(2);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(90, 27);
            btn_simpan.TabIndex = 53;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 154);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 55;
            label1.Text = "s/d";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(374, 151);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(91, 27);
            dateTimePicker2.TabIndex = 56;
            // 
            // check_hari
            // 
            check_hari.AutoSize = true;
            check_hari.Location = new Point(484, 154);
            check_hari.Margin = new Padding(2);
            check_hari.Name = "check_hari";
            check_hari.Size = new Size(135, 24);
            check_hari.TabIndex = 57;
            check_hari.Text = "lebih dari 1 hari";
            check_hari.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 202);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 58;
            label2.Text = "NIM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 202);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 59;
            label3.Text = "(Tampilan NIM)";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(354, 198);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(31, 27);
            button1.TabIndex = 60;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Pilih Level", "Fakultas", "Universitas", "Jurusan", "Nasional", "Internasional", "Propinsi", "Kab/Kota", "Wilayah/Regional" });
            comboBox2.Location = new Point(246, 242);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(346, 28);
            comboBox2.TabIndex = 78;
            // 
            // FormEntriDataKegiatan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 419);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(check_hari);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btn_simpan);
            Controls.Add(txt_bukti);
            Controls.Add(lbl_bukti);
            Controls.Add(lbl_tingkat);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_nama);
            Controls.Add(lbl_tgl);
            Controls.Add(lbl_nama);
            Controls.Add(lbl_judul);
            Margin = new Padding(2);
            Name = "FormEntriDataKegiatan";
            Text = "EntriDataKegiatan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_bukti;
        private Label lbl_bukti;
        private Label lbl_tingkat;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_nama;
        private Label lbl_tgl;
        private Label lbl_nama;
        private Label lbl_judul;
        private Button button2;
        private Button btn_simpan;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private CheckBox check_hari;
        private Label label2;
        private Label label3;
        private Button button1;
        private ComboBox comboBox2;
    }
}