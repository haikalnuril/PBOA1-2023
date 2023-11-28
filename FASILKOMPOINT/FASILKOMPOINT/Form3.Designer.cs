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
            dataGridView1 = new DataGridView();
            TitleAkumulasiLabel = new Label();
            AkumulasiLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(698, 309);
            dataGridView1.TabIndex = 0;
            // 
            // TitleAkumulasiLabel
            // 
            TitleAkumulasiLabel.AutoSize = true;
            TitleAkumulasiLabel.Location = new Point(581, 19);
            TitleAkumulasiLabel.Name = "TitleAkumulasiLabel";
            TitleAkumulasiLabel.Size = new Size(81, 20);
            TitleAkumulasiLabel.TabIndex = 2;
            TitleAkumulasiLabel.Text = "Total Poin: ";
            TitleAkumulasiLabel.Click += TitleAkumulasiLabel_Click;
            // 
            // AkumulasiLabel
            // 
            AkumulasiLabel.AutoSize = true;
            AkumulasiLabel.Location = new Point(658, 19);
            AkumulasiLabel.Name = "AkumulasiLabel";
            AkumulasiLabel.Size = new Size(50, 20);
            AkumulasiLabel.TabIndex = 3;
            AkumulasiLabel.Text = "label1";
            AkumulasiLabel.Click += label1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AkumulasiLabel);
            Controls.Add(TitleAkumulasiLabel);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label TitleAkumulasiLabel;
        private Label AkumulasiLabel;
    }
}