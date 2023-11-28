namespace FASILKOMPOINT
{
    partial class Form2
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
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.masukbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(210, 171);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(283, 22);
            this.usernametb.TabIndex = 0;
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(210, 210);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(261, 22);
            this.passwordtb.TabIndex = 1;
            // 
            // masukbutton
            // 
            this.masukbutton.Location = new System.Drawing.Point(210, 263);
            this.masukbutton.Name = "masukbutton";
            this.masukbutton.Size = new System.Drawing.Size(75, 23);
            this.masukbutton.TabIndex = 2;
            this.masukbutton.Text = "button1";
            this.masukbutton.UseVisualStyleBackColor = true;
            this.masukbutton.Click += new System.EventHandler(this.masukbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.masukbutton);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Button masukbutton;
    }
}