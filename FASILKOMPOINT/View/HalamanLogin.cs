using FASILKOMPOINT.View.Mahasiswa;
using FASILKOMPOINT.View.SKPI;
using FASILKOMPOINT.View.TU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.View
{
    public partial class Halaman : Form
    {
        public static Halaman instance;
        public TextBox tb1;
        private TextBox tb2;
        private bool isButton1Hovered = false;
        public Halaman()
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
                Beranda BerandaSKPI = new Beranda();
                BerandaSKPI.Show();
                this.Hide();
            }
            else if (password == "2")
            {
                Form1 berandaMahasiswa = new Form1();
                berandaMahasiswa.Show();
                this.Hide();
            }
            else if (password == "3")
            {
                BerandaTU BerandaTU = new BerandaTU();
                BerandaTU.Show();
                this.Hide();
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
    }
}
