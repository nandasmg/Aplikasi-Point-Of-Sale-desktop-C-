
namespace PENJUALAN_TOKO
{
    partial class Data_Laporan_Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Laporan_Transaksi));
            dtpDari = new DateTimePicker();
            dgvTransaksi = new DataGridView();
            dtpSampai = new DateTimePicker();
            btnCetak = new Button();
            btnTampilkan = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpDari
            // 
            dtpDari.Format = DateTimePickerFormat.Short;
            dtpDari.Location = new Point(12, 39);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(300, 31);
            dtpDari.TabIndex = 0;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Location = new Point(12, 76);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.RowHeadersWidth = 62;
            dgvTransaksi.Size = new Size(776, 341);
            dgvTransaksi.TabIndex = 1;
            // 
            // dtpSampai
            // 
            dtpSampai.Format = DateTimePickerFormat.Short;
            dtpSampai.Location = new Point(488, 39);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(300, 31);
            dtpSampai.TabIndex = 0;
            // 
            // btnCetak
            // 
            btnCetak.Location = new Point(142, 433);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(115, 45);
            btnCetak.TabIndex = 2;
            btnCetak.Text = "Cetak";
            btnCetak.UseVisualStyleBackColor = true;
            btnCetak.Click += btnCetak_Click;
            // 
            // btnTampilkan
            // 
            btnTampilkan.Location = new Point(12, 433);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(111, 45);
            btnTampilkan.TabIndex = 3;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = true;
            btnTampilkan.Click += btnTampilkan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Data_Laporan_Transaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(pictureBox1);
            Controls.Add(btnTampilkan);
            Controls.Add(btnCetak);
            Controls.Add(dgvTransaksi);
            Controls.Add(dtpSampai);
            Controls.Add(dtpDari);
            Name = "Data_Laporan_Transaksi";
            Text = "Data Laporan Transaksi";
            Load += Data_Laporan_Transaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpDari;
        private DataGridView dgvTransaksi;
        private DateTimePicker dtpSampai;
        private Button btnCetak;
        private Button btnTampilkan;
        private PictureBox pictureBox1;
    }
}