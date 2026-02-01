using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PENJUALAN_TOKO
{
    public partial class FormTransaksi : Form
    {
        private FormMenu formMenu;

        public FormTransaksi(FormMenu menu)
        {
            InitializeComponent();
            formMenu = menu;
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            dtTanggal.Value = DateTime.Now;
            numQTY.Minimum = 1;
            numQTY.Value = 1;

            AturGrid();
            LoadBarang();
            HitungTotal();
        }

        private void AturGrid()
        {
            dgvTampilData.Columns.Clear();

            dgvTampilData.Columns.Add("id_barang", "ID");
            dgvTampilData.Columns.Add("nama", "Nama Barang");
            dgvTampilData.Columns.Add("harga", "Harga");
            dgvTampilData.Columns.Add("qty", "Qty");
            dgvTampilData.Columns.Add("subtotal", "Subtotal");

            dgvTampilData.ReadOnly = true;
            dgvTampilData.AllowUserToAddRows = false;

            var colHarga = dgvTampilData.Columns["harga"];
            if (colHarga != null)
                colHarga.DefaultCellStyle.Format = "N0";

            var colSubtotal = dgvTampilData.Columns["subtotal"];
            if (colSubtotal != null)
                colSubtotal.DefaultCellStyle.Format = "N0";
        }

        private void LoadBarang()
        {
            using (MySqlConnection conn = KoneksiDB.GetConnection())
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(
                    "SELECT ID, NamaBarang FROM tb_barang", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cboBarang.DataSource = dt;
                cboBarang.DisplayMember = "NamaBarang";
                cboBarang.ValueMember = "ID";
                cboBarang.SelectedIndex = -1;
            }
        }

        private void AmbilDataBarang(int id, out decimal harga, out int stok)
        {
            using (MySqlConnection conn = KoneksiDB.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT Harga, Stok FROM tb_barang WHERE ID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader rd = cmd.ExecuteReader())
                {
                    if (!rd.Read())
                        throw new Exception("Barang tidak ditemukan");

                    harga = rd.GetDecimal("Harga");
                    stok = rd.GetInt32("Stok");
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cboBarang.SelectedValue == null)
            {
                MessageBox.Show("Pilih barang");
                return;
            }

            int id = Convert.ToInt32(cboBarang.SelectedValue);
            string nama = cboBarang.Text;
            int qty = (int)numQTY.Value;

            AmbilDataBarang(id, out decimal harga, out int stok);

            if (qty > stok)
            {
                MessageBox.Show("Stok tidak mencukupi");
                return;
            }

            foreach (DataGridViewRow r in dgvTampilData.Rows)
            {
                if (Convert.ToInt32(r.Cells["id_barang"].Value) == id)
                {
                    int qtyLama = Convert.ToInt32(r.Cells["qty"].Value);
                    int qtyBaru = qtyLama + qty;

                    if (qtyBaru > stok)
                    {
                        MessageBox.Show("Stok tidak mencukupi");
                        return;
                    }

                    r.Cells["qty"].Value = qtyBaru;
                    r.Cells["subtotal"].Value = qtyBaru * harga;
                    HitungTotal();
                    return;
                }
            }

            dgvTampilData.Rows.Add(id, nama, harga, qty, harga * qty);
            HitungTotal();
        }


        private void HitungTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow r in dgvTampilData.Rows)
                total += Convert.ToDecimal(r.Cells["subtotal"].Value);

            lblSubtotal.Text = "Total : " + total.ToString("N0");
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (dgvTampilData.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang kosong");
                return;
            }

            using (MySqlConnection conn = KoneksiDB.GetConnection())
            {
                conn.Open();
                MySqlTransaction trx = conn.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow r in dgvTampilData.Rows)
                    {
                        int idBarang = Convert.ToInt32(r.Cells["id_barang"].Value);
                        string nama = r.Cells["nama"].Value?.ToString() ?? "";
                        int qty = Convert.ToInt32(r.Cells["qty"].Value);
                        decimal harga = Convert.ToDecimal(r.Cells["harga"].Value);
                        decimal subtotal = Convert.ToDecimal(r.Cells["subtotal"].Value);


                        MySqlCommand cek = new MySqlCommand(
                            "SELECT Stok FROM tb_barang WHERE ID=@id",
                            conn, trx);
                        cek.Parameters.AddWithValue("@id", idBarang);

                        int stok = Convert.ToInt32(cek.ExecuteScalar());

                        if (stok < qty)
                            throw new Exception("Stok berubah, tidak mencukupi");

                        MySqlCommand ins = new MySqlCommand(
                            @"INSERT INTO tb_transaksi
                      (tanggal, id_barang, nama_barang, jumlah, harga, subtotal)
                      VALUES (@tgl,@id,@nama,@qty,@harga,@sub)",
                            conn, trx);

                        ins.Parameters.AddWithValue("@tgl", dtTanggal.Value);
                        ins.Parameters.AddWithValue("@id", idBarang);
                        ins.Parameters.AddWithValue("@nama", nama);
                        ins.Parameters.AddWithValue("@qty", qty);
                        ins.Parameters.AddWithValue("@harga", harga);
                        ins.Parameters.AddWithValue("@sub", subtotal);
                        ins.ExecuteNonQuery();


                        MySqlCommand upd = new MySqlCommand(
                            "UPDATE tb_barang SET Stok = Stok - @qty WHERE ID=@id",
                            conn, trx);
                        upd.Parameters.AddWithValue("@qty", qty);
                        upd.Parameters.AddWithValue("@id", idBarang);
                        upd.ExecuteNonQuery();
                    }

                    trx.Commit();
                    MessageBox.Show("Transaksi berhasil");
                    dgvTampilData.Rows.Clear();
                    HitungTotal();
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            dgvTampilData.Rows.Clear();
            HitungTotal();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            Close();
        }
    }
}
