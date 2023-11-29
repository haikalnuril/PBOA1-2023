namespace FASILKOMPOINT
{
    partial class Form3
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
            this.TabelData1 = new System.Windows.Forms.DataGridView();
            this.TitleAkumulasiLabel = new System.Windows.Forms.Label();
            this.AkumulasiLabel = new System.Windows.Forms.Label();
            this.prestasibutton = new System.Windows.Forms.Button();
            this.keikutsertaanbutton = new System.Windows.Forms.Button();
            this.sertifikasibutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelData1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelData1
            // 
            this.TabelData1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TabelData1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabelData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelData1.Location = new System.Drawing.Point(147, 71);
            this.TabelData1.Name = "TabelData1";
            this.TabelData1.RowHeadersWidth = 51;
            this.TabelData1.RowTemplate.Height = 24;
            this.TabelData1.Size = new System.Drawing.Size(594, 305);
            this.TabelData1.TabIndex = 0;
            this.TabelData1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelData1_CellContentClick);
            // 
            // TitleAkumulasiLabel
            // 
            this.TitleAkumulasiLabel.AutoSize = true;
            this.TitleAkumulasiLabel.Location = new System.Drawing.Point(144, 39);
            this.TitleAkumulasiLabel.Name = "TitleAkumulasiLabel";
            this.TitleAkumulasiLabel.Size = new System.Drawing.Size(148, 16);
            this.TitleAkumulasiLabel.TabIndex = 1;
            this.TitleAkumulasiLabel.Text = "Total Poin Keseluruhan:";
            // 
            // AkumulasiLabel
            // 
            this.AkumulasiLabel.AutoSize = true;
            this.AkumulasiLabel.Location = new System.Drawing.Point(298, 39);
            this.AkumulasiLabel.Name = "AkumulasiLabel";
            this.AkumulasiLabel.Size = new System.Drawing.Size(44, 16);
            this.AkumulasiLabel.TabIndex = 2;
            this.AkumulasiLabel.Text = "label2";
            // 
            // prestasibutton
            // 
            this.prestasibutton.Location = new System.Drawing.Point(23, 85);
            this.prestasibutton.Name = "prestasibutton";
            this.prestasibutton.Size = new System.Drawing.Size(105, 23);
            this.prestasibutton.TabIndex = 3;
            this.prestasibutton.Text = "Prestasi";
            this.prestasibutton.UseVisualStyleBackColor = true;
            this.prestasibutton.Click += new System.EventHandler(this.prestasibutton_Click);
            // 
            // keikutsertaanbutton
            // 
            this.keikutsertaanbutton.Location = new System.Drawing.Point(23, 114);
            this.keikutsertaanbutton.Name = "keikutsertaanbutton";
            this.keikutsertaanbutton.Size = new System.Drawing.Size(105, 23);
            this.keikutsertaanbutton.TabIndex = 4;
            this.keikutsertaanbutton.Text = "Keikutsertaan";
            this.keikutsertaanbutton.UseVisualStyleBackColor = true;
            this.keikutsertaanbutton.Click += new System.EventHandler(this.keikutsertaanbutton_Click);
            // 
            // sertifikasibutton
            // 
            this.sertifikasibutton.Location = new System.Drawing.Point(23, 143);
            this.sertifikasibutton.Name = "sertifikasibutton";
            this.sertifikasibutton.Size = new System.Drawing.Size(105, 23);
            this.sertifikasibutton.TabIndex = 5;
            this.sertifikasibutton.Text = "Sertifikasi";
            this.sertifikasibutton.UseVisualStyleBackColor = true;
            this.sertifikasibutton.Click += new System.EventHandler(this.sertifikasibutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sertifikasibutton);
            this.Controls.Add(this.keikutsertaanbutton);
            this.Controls.Add(this.prestasibutton);
            this.Controls.Add(this.AkumulasiLabel);
            this.Controls.Add(this.TitleAkumulasiLabel);
            this.Controls.Add(this.TabelData1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelData1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TabelData1;
        private System.Windows.Forms.Label TitleAkumulasiLabel;
        private System.Windows.Forms.Label AkumulasiLabel;
        private System.Windows.Forms.Button prestasibutton;
        private System.Windows.Forms.Button keikutsertaanbutton;
        private System.Windows.Forms.Button sertifikasibutton;
    }
}