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
            tabelDataSKPIMahasiswa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelDataSKPIMahasiswa).BeginInit();
            SuspendLayout();
            // 
            // tabelDataSKPIMahasiswa
            // 
            tabelDataSKPIMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelDataSKPIMahasiswa.Location = new Point(12, 12);
            tabelDataSKPIMahasiswa.Name = "tabelDataSKPIMahasiswa";
            tabelDataSKPIMahasiswa.RowHeadersWidth = 51;
            tabelDataSKPIMahasiswa.RowTemplate.Height = 29;
            tabelDataSKPIMahasiswa.Size = new Size(865, 351);
            tabelDataSKPIMahasiswa.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(889, 469);
            Controls.Add(tabelDataSKPIMahasiswa);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tabelDataSKPIMahasiswa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelDataSKPIMahasiswa;
    }
}