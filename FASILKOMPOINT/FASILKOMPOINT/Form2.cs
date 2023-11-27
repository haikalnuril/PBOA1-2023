using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.App.Models;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void masukbutton_Click(object sender, EventArgs e)
        {
            string username = usernametb.Text;
            string password = passwordtb.Text;
            int id_role = UserContext.CekLogin(username, password);
            if (id_role == 1)
            {
                MessageBox.Show("Halo SKPI", "Halo", MessageBoxButtons.OK);

            }
            else if (id_role == 2)
            {
                MessageBox.Show("Halo Tata Usaha", "Halo", MessageBoxButtons.OK);

            }
            else if (id_role == 3)
            {
                MessageBox.Show("Halo Mahasiswa", "Halo", MessageBoxButtons.OK);

            }

        }

        private void passwordtb_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}