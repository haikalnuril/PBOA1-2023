using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT
{
    public partial class HalamanLogin : Form
    {
        public static HalamanLogin instance;
        public TextBox tb1;
        private TextBox tb2;
        private bool isButton1Hovered = false;
        public HalamanLogin()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
            tb2 = textBox2;

            tb2.PasswordChar = '*';
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void FasilkomPOint_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = tb2.Text;

            if (password == "1")
            {
                //Form2 form = new Form2();
                //form.Show();
            }
            else if (password == "2")
            {
                Form1 berandaMahasiswa = new Form1();
                berandaMahasiswa.Show();
                this.Hide();
            }
            else if (password == "3")
            {
                //BerandaTU BerandaTU = new BerandaTU();
                //BerandaTU.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal. Coba lagi.");
            }

            button1.ForeColor = Color.Blue;

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // Mengubah warna tombol button1 saat cursor mendekatinya
            isButton1Hovered = true;
            button1.ForeColor = Color.DarkBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // Mengembalikan warna tombol button1 saat cursor menjauh
            isButton1Hovered = false;
            button1.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
