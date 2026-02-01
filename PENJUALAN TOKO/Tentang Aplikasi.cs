using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PENJUALAN_TOKO
{
    public partial class Tentang_Aplikasi : Form
    {
        private FormMenu formMenu;

        public Tentang_Aplikasi(FormMenu menu)
        {
            InitializeComponent();
            formMenu = menu;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
