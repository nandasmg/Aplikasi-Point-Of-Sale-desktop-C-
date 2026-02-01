
namespace PENJUALAN_TOKO
{
    partial class FormEditBarang
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
            btnSimpan = new Button();
            numStokBarang = new NumericUpDown();
            numHargaBarang = new NumericUpDown();
            txtNamaBarang = new TextBox();
            txtid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBatal = new Button();
            ((System.ComponentModel.ISupportInitialize)numStokBarang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHargaBarang).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(184, 228);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 40);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // numStokBarang
            // 
            numStokBarang.Location = new Point(184, 179);
            numStokBarang.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numStokBarang.Name = "numStokBarang";
            numStokBarang.Size = new Size(227, 31);
            numStokBarang.TabIndex = 10;
            // 
            // numHargaBarang
            // 
            numHargaBarang.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            numHargaBarang.Location = new Point(184, 129);
            numHargaBarang.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numHargaBarang.Name = "numHargaBarang";
            numHargaBarang.Size = new Size(227, 31);
            numHargaBarang.TabIndex = 11;
            numHargaBarang.ThousandsSeparator = true;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Location = new Point(184, 79);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(227, 31);
            txtNamaBarang.TabIndex = 8;
            // 
            // txtid
            // 
            txtid.Location = new Point(184, 31);
            txtid.Name = "txtid";
            txtid.Size = new Size(227, 31);
            txtid.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 181);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 4;
            label4.Text = "Stok Barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 131);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 5;
            label3.Text = "Harga Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 6;
            label2.Text = "Nama Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(302, 228);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(112, 40);
            btnBatal.TabIndex = 12;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click_1;
            // 
            // FormEditBarang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 295);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(numStokBarang);
            Controls.Add(numHargaBarang);
            Controls.Add(txtNamaBarang);
            Controls.Add(txtid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEditBarang";
            Text = "Form Edit Barang";
            ((System.ComponentModel.ISupportInitialize)numStokBarang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHargaBarang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnSimpan;
        private NumericUpDown numStokBarang;
        private NumericUpDown numHargaBarang;
        private TextBox txtNamaBarang;
        private TextBox txtid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBatal;
    }
}