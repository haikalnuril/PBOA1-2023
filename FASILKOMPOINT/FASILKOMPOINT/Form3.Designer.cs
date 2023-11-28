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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TitleAkumulasiLabel = new System.Windows.Forms.Label();
            this.AkumulasiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(594, 305);
            this.dataGridView1.TabIndex = 0;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AkumulasiLabel);
            this.Controls.Add(this.TitleAkumulasiLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TitleAkumulasiLabel;
        private System.Windows.Forms.Label AkumulasiLabel;
    }
}