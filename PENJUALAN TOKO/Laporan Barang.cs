using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PENJUALAN_TOKO
{
    public partial class Data_Laporan_Barang : Form
    {
        private FormMenu formMenu;

        public Data_Laporan_Barang(FormMenu menu)
        {
            InitializeComponent();
            formMenu = menu;
        }

        private void Data_Laporan_Barang_Load(object sender, EventArgs e)
        {
            LoadDataBarang();
        }

        private void LoadDataBarang()
        {
            using (MySqlConnection conn = KoneksiDB.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    ID AS 'Kode',
                    NamaBarang AS 'Nama Barang',
                    Harga AS 'Harga',
                    Stok AS 'Stok'
                FROM tb_barang";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBarang.DataSource = dt;
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    FileName = "Laporan_Barang.pdf"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    doc.Add(new Paragraph("LAPORAN DATA BARANG"));
                    doc.Add(new Paragraph("Tanggal: " + DateTime.Now.ToString("dd-MM-yyyy")));
                    doc.Add(new Paragraph(" "));

                    PdfPTable table = new PdfPTable(dgvBarang.Columns.Count);
                    table.WidthPercentage = 100;

                    foreach (DataGridViewColumn col in dgvBarang.Columns)
                        table.AddCell(new Phrase(col.HeaderText));

                    foreach (DataGridViewRow row in dgvBarang.Rows)
                        foreach (DataGridViewCell cell in row.Cells)
                            table.AddCell(cell.Value?.ToString());

                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("PDF berhasil dibuat");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            Close();
        }
    }
}
