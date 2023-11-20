namespace Fasilkom_Point
{
    partial class RekapDataSKPI
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Nomer = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Keterangan = new DataGridViewTextBoxColumn();
            StatusValidasi = new DataGridViewTextBoxColumn();
            Poin = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(134, 520);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(21, 420);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(90, 27);
            button4.TabIndex = 17;
            button4.Text = "Kembali";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(21, 112);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Sertifikasi";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(21, 77);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Kegiatan";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(21, 42);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Prestasi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nomer, Nama, Keterangan, StatusValidasi, Poin });
            dataGridView1.Location = new Point(162, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(745, 434);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nomer
            // 
            Nomer.HeaderText = "No.";
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
            // Poin
            // 
            Poin.HeaderText = "Poin";
            Poin.MinimumWidth = 6;
            Poin.Name = "Poin";
            Poin.Width = 125;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 520);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nomer;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Keterangan;
        private DataGridViewTextBoxColumn StatusValidasi;
        private DataGridViewTextBoxColumn Poin;
        private Button button4;
    }
}