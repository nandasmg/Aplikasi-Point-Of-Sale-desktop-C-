namespace PENJUALAN_TOKO
{
    partial class FormTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
            numQTY = new NumericUpDown();
            btnTambah = new Button();
            cboBarang = new ComboBox();
            label = new Label();
            dtTanggal = new DateTimePicker();
            dgvTampilData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lblSubtotal = new Label();
            btnBatal = new Button();
            btnSimpan = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numQTY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTampilData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numQTY
            // 
            numQTY.Location = new Point(154, 135);
            numQTY.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numQTY.Name = "numQTY";
            numQTY.Size = new Size(300, 31);
            numQTY.TabIndex = 0;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(140, 557);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(98, 39);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // cboBarang
            // 
            cboBarang.FormattingEnabled = true;
            cboBarang.Location = new Point(154, 86);
            cboBarang.Name = "cboBarang";
            cboBarang.Size = new Size(300, 33);
            cboBarang.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(20, 137);
            label.Name = "label";
            label.Size = new Size(67, 25);
            label.TabIndex = 3;
            label.Text = "Jumlah";
            // 
            // dtTanggal
            // 
            dtTanggal.Location = new Point(154, 37);
            dtTanggal.Name = "dtTanggal";
            dtTanggal.Size = new Size(300, 31);
            dtTanggal.TabIndex = 4;
            // 
            // dgvTampilData
            // 
            dgvTampilData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTampilData.Location = new Point(16, 187);
            dgvTampilData.Name = "dgvTampilData";
            dgvTampilData.RowHeadersWidth = 62;
            dgvTampilData.Size = new Size(758, 320);
            dgvTampilData.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 43);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 3;
            label1.Text = "Tanggal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 89);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 3;
            label2.Text = "Barang";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(20, 521);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(111, 25);
            lblSubtotal.TabIndex = 6;
            lblSubtotal.Text = "Total Bayar : ";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(258, 557);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(98, 39);
            btnBatal.TabIndex = 1;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(20, 559);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 611);
            Controls.Add(pictureBox1);
            Controls.Add(btnSimpan);
            Controls.Add(lblSubtotal);
            Controls.Add(dgvTampilData);
            Controls.Add(dtTanggal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(cboBarang);
            Controls.Add(btnBatal);
            Controls.Add(btnTambah);
            Controls.Add(numQTY);
            Name = "FormTransaksi";
            Text = "Form Input Data Transaksi";
            Load += FormTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)numQTY).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTampilData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numQTY;
        private Button btnTambah;
        private ComboBox cboBarang;
        private Label label;
        private DateTimePicker dtTanggal;
        private DataGridView dgvTampilData;
        private Label label1;
        private Label label2;
        private Label lblSubtotal;
        private Button btnBatal;
        private Button btnSimpan;
        private PictureBox pictureBox1;
    }
}