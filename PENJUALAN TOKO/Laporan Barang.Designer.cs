namespace PENJUALAN_TOKO
{
    partial class Data_Laporan_Barang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Laporan_Barang));
            dgvBarang = new DataGridView();
            btnCetak = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvBarang
            // 
            dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarang.Location = new Point(12, 35);
            dgvBarang.Name = "dgvBarang";
            dgvBarang.RowHeadersWidth = 62;
            dgvBarang.Size = new Size(776, 409);
            dgvBarang.TabIndex = 0;
            // 
            // btnCetak
            // 
            btnCetak.BackColor = SystemColors.ButtonHighlight;
            btnCetak.Location = new Point(12, 460);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(119, 44);
            btnCetak.TabIndex = 2;
            btnCetak.Text = "Cetak";
            btnCetak.UseVisualStyleBackColor = false;
            btnCetak.Click += btnCetak_Click;
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
            // Data_Laporan_Barang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(pictureBox1);
            Controls.Add(btnCetak);
            Controls.Add(dgvBarang);
            Name = "Data_Laporan_Barang";
            Text = "Data Laporan Barang";
            Load += Data_Laporan_Barang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBarang;
        private Button btnCetak;
        private PictureBox pictureBox1;
    }
}