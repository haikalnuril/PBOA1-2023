using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

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
            usernametb = new TextBox();
            passwordtb = new TextBox();
            masukbutton = new Button();
            SuspendLayout();
            // 
            // usernametb
            // 
            usernametb.Location = new Point(234, 173);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(248, 27);
            usernametb.TabIndex = 0;
            // 
            // passwordtb
            // 
            passwordtb.Location = new Point(234, 230);
            passwordtb.Name = "passwordtb";
            passwordtb.Size = new Size(248, 27);
            passwordtb.TabIndex = 1;
            // 
            // masukbutton
            // 
            masukbutton.Location = new Point(442, 310);
            masukbutton.Name = "masukbutton";
            masukbutton.Size = new Size(94, 29);
            masukbutton.TabIndex = 2;
            masukbutton.Text = "button1";
            masukbutton.UseVisualStyleBackColor = true;
            masukbutton.Click += masukbutton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(masukbutton);
            Controls.Add(passwordtb);
            Controls.Add(usernametb);
            Name = "Form2";
            Text = "Form2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernametb;
        private TextBox passwordtb;
        private Button masukbutton;
    }
}