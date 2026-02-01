namespace PENJUALAN_TOKO
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            menuStrip2 = new MenuStrip();
            dataTransaksiToolStripMenuItem = new ToolStripMenuItem();
            MenuBarang = new ToolStripMenuItem();
            dataLaporanToolStripMenuItem = new ToolStripMenuItem();
            laporanDataTransaksiToolStripMenuItem = new ToolStripMenuItem();
            tentangToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { dataTransaksiToolStripMenuItem, MenuBarang, dataLaporanToolStripMenuItem, laporanDataTransaksiToolStripMenuItem, tentangToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(832, 33);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // dataTransaksiToolStripMenuItem
            // 
            dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            dataTransaksiToolStripMenuItem.Size = new Size(140, 29);
            dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            dataTransaksiToolStripMenuItem.Click += dataTransaksiToolStripMenuItem_Click;
            // 
            // MenuBarang
            // 
            MenuBarang.Name = "MenuBarang";
            MenuBarang.Size = new Size(125, 29);
            MenuBarang.Text = "Data Barang";
            MenuBarang.Click += MenuBarang_Click_1;
            // 
            // dataLaporanToolStripMenuItem
            // 
            dataLaporanToolStripMenuItem.Name = "dataLaporanToolStripMenuItem";
            dataLaporanToolStripMenuItem.Size = new Size(194, 29);
            dataLaporanToolStripMenuItem.Text = "Laporan Data Barang";
            dataLaporanToolStripMenuItem.Click += dataLaporanToolStripMenuItem_Click;
            // 
            // laporanDataTransaksiToolStripMenuItem
            // 
            laporanDataTransaksiToolStripMenuItem.Name = "laporanDataTransaksiToolStripMenuItem";
            laporanDataTransaksiToolStripMenuItem.Size = new Size(209, 29);
            laporanDataTransaksiToolStripMenuItem.Text = "Laporan Data Transaksi";
            laporanDataTransaksiToolStripMenuItem.Click += laporanDataTransaksiToolStripMenuItem_Click;
            // 
            // tentangToolStripMenuItem
            // 
            tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            tentangToolStripMenuItem.Size = new Size(156, 29);
            tentangToolStripMenuItem.Text = "Tentang Aplikasi";
            tentangToolStripMenuItem.Click += tentangToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(832, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(925, 520);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip2);
            Name = "FormMenu";
            Text = "APLIKASI KASIR";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem MenuBarang;
        private ToolStripMenuItem dataLaporanToolStripMenuItem;
        private ToolStripMenuItem dataTransaksiToolStripMenuItem;
        private ToolStripMenuItem laporanDataTransaksiToolStripMenuItem;
        private ToolStripMenuItem tentangToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
