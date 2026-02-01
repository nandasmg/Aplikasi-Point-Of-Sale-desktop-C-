namespace PENJUALAN_TOKO
{
    partial class FormTambahBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahBarang));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtNamaBarang = new TextBox();
            numHargaBarang = new NumericUpDown();
            numStokBarang = new NumericUpDown();
            btnSimpan = new Button();
            ((System.ComponentModel.ISupportInitialize)numHargaBarang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStokBarang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(18, 72);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 0;
            label2.Text = "Nama Barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(18, 121);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 0;
            label3.Text = "Harga Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(18, 171);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 0;
            label4.Text = "Stok Barang";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.ControlLight;
            txtID.Location = new Point(180, 21);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(227, 31);
            txtID.TabIndex = 1;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.BackColor = SystemColors.ControlLight;
            txtNamaBarang.Location = new Point(180, 69);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(227, 31);
            txtNamaBarang.TabIndex = 1;
            // 
            // numHargaBarang
            // 
            numHargaBarang.BackColor = SystemColors.ControlLight;
            numHargaBarang.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            numHargaBarang.Location = new Point(180, 119);
            numHargaBarang.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            numHargaBarang.Name = "numHargaBarang";
            numHargaBarang.Size = new Size(227, 31);
            numHargaBarang.TabIndex = 2;
            numHargaBarang.ThousandsSeparator = true;
            // 
            // numStokBarang
            // 
            numStokBarang.BackColor = SystemColors.ControlLight;
            numStokBarang.Location = new Point(180, 169);
            numStokBarang.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numStokBarang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numStokBarang.Name = "numStokBarang";
            numStokBarang.Size = new Size(227, 31);
            numStokBarang.TabIndex = 2;
            numStokBarang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(295, 215);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 40);
            btnSimpan.TabIndex = 3;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // FormTambahBarang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(435, 283);
            Controls.Add(btnSimpan);
            Controls.Add(numStokBarang);
            Controls.Add(numHargaBarang);
            Controls.Add(txtNamaBarang);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormTambahBarang";
            Text = "Form Tambah Barang";
            ((System.ComponentModel.ISupportInitialize)numHargaBarang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStokBarang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtNamaBarang;
        private NumericUpDown numHargaBarang;
        private NumericUpDown numStokBarang;
        private Button btnSimpan;
    }
}