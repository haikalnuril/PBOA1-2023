namespace FASILKOMPOINT
{
    partial class Form4
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
            this.TabelData2 = new System.Windows.Forms.DataGridView();
            this.SimpanValidasibutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelData2)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelData2
            // 
            this.TabelData2.AllowUserToAddRows = false;
            this.TabelData2.AllowUserToDeleteRows = false;
            this.TabelData2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TabelData2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabelData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelData2.Location = new System.Drawing.Point(45, 70);
            this.TabelData2.Margin = new System.Windows.Forms.Padding(4);
            this.TabelData2.Name = "TabelData2";
            this.TabelData2.RowHeadersWidth = 51;
            this.TabelData2.Size = new System.Drawing.Size(980, 450);
            this.TabelData2.TabIndex = 0;
            this.TabelData2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelData2_CellContentClick);
            // 
            // SimpanValidasibutton
            // 
            this.SimpanValidasibutton.Location = new System.Drawing.Point(887, 34);
            this.SimpanValidasibutton.Margin = new System.Windows.Forms.Padding(4);
            this.SimpanValidasibutton.Name = "SimpanValidasibutton";
            this.SimpanValidasibutton.Size = new System.Drawing.Size(139, 28);
            this.SimpanValidasibutton.TabIndex = 1;
            this.SimpanValidasibutton.Text = "Simpan";
            this.SimpanValidasibutton.UseVisualStyleBackColor = true;
            this.SimpanValidasibutton.Click += new System.EventHandler(this.SimpanValidasibutton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SimpanValidasibutton);
            this.Controls.Add(this.TabelData2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelData2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TabelData2;
        private System.Windows.Forms.Button SimpanValidasibutton;
    }
}