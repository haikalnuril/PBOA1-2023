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
            SearchNama = new TextBox();
            ButtonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)tabelDataSKPIMahasiswa).BeginInit();
            SuspendLayout();
            // 
            // tabelDataSKPIMahasiswa
            // 
            tabelDataSKPIMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tabelDataSKPIMahasiswa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tabelDataSKPIMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelDataSKPIMahasiswa.Location = new Point(12, 89);
            tabelDataSKPIMahasiswa.Name = "tabelDataSKPIMahasiswa";
            tabelDataSKPIMahasiswa.RowHeadersWidth = 51;
            tabelDataSKPIMahasiswa.RowTemplate.Height = 29;
            tabelDataSKPIMahasiswa.Size = new Size(865, 351);
            tabelDataSKPIMahasiswa.TabIndex = 0;
            tabelDataSKPIMahasiswa.CellContentClick += tabelDataSKPIMahasiswa_CellContentClick;
            // 
            // SearchNama
            // 
            SearchNama.Cursor = Cursors.IBeam;
            SearchNama.Location = new Point(41, 44);
            SearchNama.Name = "SearchNama";
            SearchNama.Size = new Size(214, 27);
            SearchNama.TabIndex = 1;
            SearchNama.TextChanged += SearchNama_TextChanged;
            SearchNama.KeyPress += SearchNama_KeyPress;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(261, 42);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(94, 29);
            ButtonSearch.TabIndex = 2;
            ButtonSearch.Text = "Cari";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(889, 469);
            Controls.Add(ButtonSearch);
            Controls.Add(SearchNama);
            Controls.Add(tabelDataSKPIMahasiswa);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tabelDataSKPIMahasiswa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabelDataSKPIMahasiswa;
        private TextBox SearchNama;
        private Button ButtonSearch;
    }
}