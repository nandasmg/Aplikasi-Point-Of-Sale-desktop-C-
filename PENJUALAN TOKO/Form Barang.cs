using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PENJUALAN_TOKO
{
    public partial class FormBarang : Form
    {
        private FormMenu formMenu;

        public FormBarang(FormMenu menu)
        {
            InitializeComponent();
            formMenu = menu;
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            TampilkanDataBarang();
        }

        private void TampilkanDataBarang()
        {
            try
            {
                using (MySqlConnection conn = KoneksiDB.GetConnection())
                {
                    conn.Open();


                    string sql = "SELECT ID, NamaBarang, Harga, Stok FROM tb_barang";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTampilData.DataSource = dt;
                    AturDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data:\n" + ex.Message);
            }
        }

        private void AturDataGridView()
        {
            dgvTampilData.ReadOnly = true;
            dgvTampilData.AllowUserToAddRows = false;
            dgvTampilData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTampilData.MultiSelect = false;

            if (dgvTampilData.Columns["ID"] != null)
                dgvTampilData.Columns["ID"]!.HeaderText = "ID";

            if (dgvTampilData.Columns["NamaBarang"] != null)
                dgvTampilData.Columns["NamaBarang"]!.HeaderText = "Nama Barang";

            if (dgvTampilData.Columns["Harga"] != null)
            {
                dgvTampilData.Columns["Harga"]!.HeaderText = "Harga";
                dgvTampilData.Columns["Harga"]!.DefaultCellStyle.Format = "N0";
            }

            if (dgvTampilData.Columns["Stok"] != null)
                dgvTampilData.Columns["Stok"]!.HeaderText = "Stok";
        }


        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarang frm = new FormTambahBarang();
            frm.ShowDialog();
            TampilkanDataBarang();
        }


        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvTampilData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No) return;

            int id = Convert.ToInt32(dgvTampilData.SelectedRows[0].Cells["ID"].Value);

            HapusDataBarang(id);
        }

        private void HapusDataBarang(int id)
        {
            try
            {
                using (MySqlConnection conn = KoneksiDB.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM tb_barang WHERE ID=@id", conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data berhasil dihapus");
                TampilkanDataBarang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data:\n" + ex.Message);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            {
                if (dgvTampilData.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih data yang akan diedit");
                    return;
                }



                DataGridViewRow r = dgvTampilData.SelectedRows[0];

                int id = Convert.ToInt32(r.Cells["ID"].Value);
                string nama = r.Cells["NamaBarang"].Value?.ToString() ?? "";
                decimal harga = Convert.ToDecimal(r.Cells["Harga"].Value);
                int stok = Convert.ToInt32(r.Cells["Stok"].Value);



                FormEditBarang frm = new FormEditBarang(id, nama, harga, stok);
                frm.ShowDialog();

                TampilkanDataBarang();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            Close();
        }
    }
}
