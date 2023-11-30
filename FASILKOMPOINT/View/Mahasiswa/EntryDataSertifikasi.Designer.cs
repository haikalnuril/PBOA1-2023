using System.ComponentModel;

namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class EntryDataSertifikasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(EntryDataSertifikasi));
            dataGridView = new DataGridView();
            btn_prestasi = new Button();
            btn_kegiatan = new Button();
            btn_sertifikasi = new Button();
            btnTambah_Click = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            ((ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(142, 92);
            dataGridView.Margin = new Padding(2, 3, 2, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(766, 416);
            dataGridView.TabIndex = 0;
            // 
            // btn_prestasi
            // 
            btn_prestasi.BackColor = Color.Transparent;
            btn_prestasi.Location = new Point(16, 57);
            btn_prestasi.Margin = new Padding(2, 3, 2, 3);
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
            btn_kegiatan.Margin = new Padding(2, 3, 2, 3);
            btn_kegiatan.Name = "btn_kegiatan";
            btn_kegiatan.Size = new Size(98, 31);
            btn_kegiatan.TabIndex = 2;
            btn_kegiatan.Text = "Kegiatan";
            btn_kegiatan.UseVisualStyleBackColor = false;
            btn_kegiatan.Click += btn_kegiatan_Click;
            // 
            // btn_sertifikasi
            // 
            btn_sertifikasi.BackColor = SystemColors.GradientActiveCaption;
            btn_sertifikasi.Location = new Point(16, 127);
            btn_sertifikasi.Margin = new Padding(2, 3, 2, 3);
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
            btnTambah_Click.Location = new Point(811, 11);
            btnTambah_Click.Margin = new Padding(2, 3, 2, 3);
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
            panel1.Size = new Size(127, 520);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(16, 453);
            button1.Name = "button1";
            button1.Size = new Size(98, 29);
            button1.TabIndex = 4;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(382, 36);
            label1.Name = "label1";
            label1.Size = new Size(291, 37);
            label1.TabIndex = 6;
            label1.Text = "Entry Data Sertifikasi";
            // 
            // EntryDataSertifikasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(919, 520);
            Controls.Add(label1);
            Controls.Add(btnTambah_Click);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 3, 2, 3);
            Name = "EntryDataSertifikasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entry Data SKPI";
            Load += EntryDataSertifikasi_Load;
            ((ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btn_prestasi;
        private Button btn_kegiatan;
        private Button btn_sertifikasi;
        private Button btnTambah_Click;
        private Panel panel1;
        private Button button1;
        private Label label1;
    }
}