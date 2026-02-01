using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PENJUALAN_TOKO
{
    public partial class Data_Laporan_Transaksi : Form
    {
        private FormMenu formMenu;

        public Data_Laporan_Transaksi(FormMenu menu)
        {
            InitializeComponent();
            formMenu = menu;
        }

        private void Data_Laporan_Transaksi_Load(object sender, EventArgs e)
        {
            {
                dtpDari.Value = DateTime.Today;
                dtpSampai.Value = DateTime.Today;
            }
        }

        private void LoadDataTransaksi()
        {
            using (MySqlConnection conn = KoneksiDB.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    id_transaksi AS 'No Transaksi',
                    Tanggal AS 'Tanggal',
                    id_barang AS 'Kode Barang',
                    nama_barang AS 'Nama Barang',
                    jumlah AS 'Qty',
                    harga AS 'Harga',
                    subtotal AS 'Subtotal'
                FROM tb_transaksi
                WHERE Tanggal BETWEEN @dari AND @sampai";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dari", dtpDari.Value.Date);
                cmd.Parameters.AddWithValue("@sampai", dtpSampai.Value.Date);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTransaksi.DataSource = dt;
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    FileName = "Laporan_Transaksi.pdf"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    doc.Add(new Paragraph("LAPORAN TRANSAKSI"));
                    doc.Add(new Paragraph($"Periode: {dtpDari.Value:dd-MM-yyyy} s/d {dtpSampai.Value:dd-MM-yyyy}"));
                    doc.Add(new Paragraph(" "));

                    PdfPTable table = new PdfPTable(dgvTransaksi.Columns.Count);
                    table.WidthPercentage = 100;

                    foreach (DataGridViewColumn col in dgvTransaksi.Columns)
                        table.AddCell(new Phrase(col.HeaderText));

                    foreach (DataGridViewRow row in dgvTransaksi.Rows)
                        foreach (DataGridViewCell cell in row.Cells)
                            table.AddCell(cell.Value?.ToString());

                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("PDF berhasil dibuat");
                }
            }
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            LoadDataTransaksi();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            Close();
        }
    }
}
