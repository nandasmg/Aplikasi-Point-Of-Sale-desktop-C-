

namespace PENJUALAN_TOKO
{
    partial class FormBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarang));
            dgvTampilData = new DataGridView();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTampilData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvTampilData
            // 
            dgvTampilData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTampilData.Location = new Point(12, 43);
            dgvTampilData.Name = "dgvTampilData";
            dgvTampilData.RowHeadersWidth = 62;
            dgvTampilData.Size = new Size(776, 335);
            dgvTampilData.TabIndex = 0;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(417, 407);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(546, 407);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(673, 407);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 1;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormBarang
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(pictureBox1);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(dgvTampilData);
            Name = "FormBarang";
            Text = "Form Barang";
            Load += FormBarang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTampilData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private DataGridView dgvTampilData;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
        private PictureBox pictureBox1;
    }
}