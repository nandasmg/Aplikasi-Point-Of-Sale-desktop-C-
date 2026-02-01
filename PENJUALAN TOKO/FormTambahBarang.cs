using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PENJUALAN_TOKO
{
    public partial class FormTambahBarang : Form
    {
        public FormTambahBarang()
        {
            InitializeComponent();
            this.Load += FormTambahBarang_Load;
        }

        private void FormTambahBarang_Load(object? sender, EventArgs e)
        {
            numHargaBarang.Minimum = 0;
            numHargaBarang.Maximum = 100000000;
            numHargaBarang.Value = 0;

            numStokBarang.Minimum = 0;
            numStokBarang.Maximum = 100000;
            numStokBarang.Value = 0;

            txtID.ReadOnly = true;

            AmbilIDBerikutnya();
        }

        private void AmbilIDBerikutnya()
        {
            try
            {
                using (MySqlConnection conn = KoneksiDB.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT IFNULL(MAX(ID), 0) + 1 FROM tb_barang";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    object hasil = cmd.ExecuteScalar();

                    txtID.Text = hasil.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil ID:\n" + ex.Message);
                txtID.Text = "1";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaBarang.Text))
            {
                MessageBox.Show("Nama barang wajib diisi");
                return;
            }

            try
            {
                using (MySqlConnection conn = KoneksiDB.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO tb_barang
                                   (NamaBarang, Harga, Stok)
                                   VALUES (@nama, @harga, @stok)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", txtNamaBarang.Text.Trim());
                        cmd.Parameters.AddWithValue("@harga", numHargaBarang.Value);
                        cmd.Parameters.AddWithValue("@stok", numStokBarang.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Barang berhasil ditambahkan");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
