using System;
using System.Windows.Forms;

namespace PENJUALAN_TOKO
{
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void MenuBarang_Click_1(object sender, EventArgs e)
        {
            FormBarang ft = new FormBarang(this);
            ft.Show();
        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksi ft = new FormTransaksi(this);
            ft.Show();
        }

        private void dataLaporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Laporan_Barang ft = new Data_Laporan_Barang(this);
            ft.Show();
        }

        private void laporanDataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Laporan_Transaksi ft = new Data_Laporan_Transaksi(this);
            ft.Show();
        }

        private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tentang_Aplikasi ft = new Tentang_Aplikasi(this);
            ft.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Yakin ingin Keluar?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
