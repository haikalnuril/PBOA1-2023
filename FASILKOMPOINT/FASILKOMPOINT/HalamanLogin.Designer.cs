using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FASILKOMPOINT
{
    partial class HalamanLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanLogin));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(677, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(678, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 22);
            this.textBox2.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(678, 220);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(102, 25);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(678, 298);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(98, 25);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(678, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label Username;
        private Label Password;
        private Button button1;
    }
}