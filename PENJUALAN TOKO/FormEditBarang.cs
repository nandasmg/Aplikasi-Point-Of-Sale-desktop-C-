using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PENJUALAN_TOKO
{
    public partial class FormEditBarang : Form
    {
        private int idBarang;

        public FormEditBarang(int id, string nama, decimal harga, int stok)
        {
            InitializeComponent();

            idBarang = id;

            txtid.Text = idBarang.ToString();
            txtNamaBarang.Text = nama;
            numHargaBarang.Value = harga;
            numStokBarang.Value = stok;

            AturNumericUpDown();

        }

        private void FormEditBarang_Load(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AturNumericUpDown()
        {
            numHargaBarang.Minimum = 0;
            numHargaBarang.Maximum = 100000000;

            numStokBarang.Minimum = 0;
            numStokBarang.Maximum = 100000;
        }  

        private void UpdateDataBarang()
        {
            try
            {
                using (MySqlConnection conn = KoneksiDB.GetConnection())
                {
                    conn.Open();

                    string query =
                        "UPDATE tb_barang " +
                        "SET NamaBarang = @nama, Harga = @harga, Stok = @stok " +
                        "WHERE ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", txtNamaBarang.Text.Trim());
                        cmd.Parameters.AddWithValue("@harga", numHargaBarang.Value);
                        cmd.Parameters.AddWithValue("@stok", numStokBarang.Value);
                        cmd.Parameters.AddWithValue("@id", idBarang);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil diperbarui.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat update data:\n" + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaBarang.Text.Trim() == "")
            {
                MessageBox.Show("Nama barang tidak boleh kosong.");
                return;
            }

            UpdateDataBarang();
        }
    }
}
