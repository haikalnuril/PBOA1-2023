namespace FASILKOMPOINT
{
    partial class Form1
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
            this.TabelData = new System.Windows.Forms.DataGridView();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.caributton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelData)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelData
            // 
            this.TabelData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TabelData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelData.Location = new System.Drawing.Point(41, 65);
            this.TabelData.Name = "TabelData";
            this.TabelData.RowHeadersWidth = 51;
            this.TabelData.RowTemplate.Height = 24;
            this.TabelData.Size = new System.Drawing.Size(706, 361);
            this.TabelData.TabIndex = 0;
            // 
            // searchtb
            // 
            this.searchtb.Location = new System.Drawing.Point(501, 37);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(161, 22);
            this.searchtb.TabIndex = 1;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // caributton
            // 
            this.caributton.Location = new System.Drawing.Point(668, 36);
            this.caributton.Name = "caributton";
            this.caributton.Size = new System.Drawing.Size(75, 23);
            this.caributton.TabIndex = 2;
            this.caributton.Text = "Cari";
            this.caributton.UseVisualStyleBackColor = true;
            this.caributton.Click += new System.EventHandler(this.caributton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caributton);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.TabelData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TabelData;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Button caributton;
    }
}