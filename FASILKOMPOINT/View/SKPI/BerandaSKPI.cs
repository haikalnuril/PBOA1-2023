﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.View.SKPI
{
    public partial class BerandaSKPI : Form
    {
        public BerandaSKPI()
        {
            InitializeComponent();

            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;

            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;

            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GrafikPrestasi form = new GrafikPrestasi();
            //form.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ValidasiSKPIMahasiswa ValidasiSKPIMahasiswa = new ValidasiSKPIMahasiswa();
            ValidasiSKPIMahasiswa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSKPIMahasiswa DataSKPIMahasiswa = new DataSKPIMahasiswa();
            DataSKPIMahasiswa.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

            button2.BackColor = Color.Blue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Control;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {

            button3.BackColor = Color.Blue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.Control;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Halaman HalamanLogin = new Halaman();
                //HalamanLogin.Show();
                //this.Hide();

            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BerandaSKPI_Load(object sender, EventArgs e)
        {

        }
    }
}
