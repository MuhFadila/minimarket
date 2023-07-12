namespace minimarket
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.DATABARANG = new System.Windows.Forms.ToolStripMenuItem();
            this.DATASUPPLIER = new System.Windows.Forms.ToolStripMenuItem();
            this.DATAPELANGGAN = new System.Windows.Forms.ToolStripMenuItem();
            this.TRANSAKSI = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.HISTORI = new System.Windows.Forms.ToolStripMenuItem();
            this.PENJUALAN = new System.Windows.Forms.ToolStripMenuItem();
            this.APKMINIMARKET = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripDropDownButton1,
            this.TRANSAKSI,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "MASTER";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DATABARANG,
            this.DATASUPPLIER,
            this.DATAPELANGGAN});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // DATABARANG
            // 
            this.DATABARANG.Name = "DATABARANG";
            this.DATABARANG.Size = new System.Drawing.Size(218, 26);
            this.DATABARANG.Text = "DATA BARANG";
            this.DATABARANG.Click += new System.EventHandler(this.DATABARANG_Click);
            // 
            // DATASUPPLIER
            // 
            this.DATASUPPLIER.Name = "DATASUPPLIER";
            this.DATASUPPLIER.Size = new System.Drawing.Size(218, 26);
            this.DATASUPPLIER.Text = "DATA SUPPLIER";
            this.DATASUPPLIER.Click += new System.EventHandler(this.DATASUPPLIER_Click);
            // 
            // DATAPELANGGAN
            // 
            this.DATAPELANGGAN.Name = "DATAPELANGGAN";
            this.DATAPELANGGAN.Size = new System.Drawing.Size(218, 26);
            this.DATAPELANGGAN.Text = "DATA PELANGGAN";
            this.DATAPELANGGAN.Click += new System.EventHandler(this.DATAPELANGGAN_Click);
            // 
            // TRANSAKSI
            // 
            this.TRANSAKSI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TRANSAKSI.Name = "TRANSAKSI";
            this.TRANSAKSI.Size = new System.Drawing.Size(100, 27);
            this.TRANSAKSI.Text = "TRANSAKSI";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HISTORI,
            this.PENJUALAN});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // HISTORI
            // 
            this.HISTORI.Name = "HISTORI";
            this.HISTORI.Size = new System.Drawing.Size(224, 26);
            this.HISTORI.Text = "HISTORI";
            // 
            // PENJUALAN
            // 
            this.PENJUALAN.Name = "PENJUALAN";
            this.PENJUALAN.Size = new System.Drawing.Size(224, 26);
            this.PENJUALAN.Text = "PENJUALAN";
            this.PENJUALAN.Click += new System.EventHandler(this.PENJUALAN_Click);
            // 
            // APKMINIMARKET
            // 
            this.APKMINIMARKET.AutoSize = true;
            this.APKMINIMARKET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.APKMINIMARKET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.APKMINIMARKET.Location = new System.Drawing.Point(307, 211);
            this.APKMINIMARKET.Name = "APKMINIMARKET";
            this.APKMINIMARKET.Size = new System.Drawing.Size(152, 18);
            this.APKMINIMARKET.TabIndex = 1;
            this.APKMINIMARKET.Text = "APLIKASI MINIMARKET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.APKMINIMARKET);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem DATABARANG;
        private System.Windows.Forms.ToolStripMenuItem DATASUPPLIER;
        private System.Windows.Forms.ToolStripMenuItem DATAPELANGGAN;
        private System.Windows.Forms.ToolStripTextBox TRANSAKSI;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem HISTORI;
        private System.Windows.Forms.ToolStripMenuItem PENJUALAN;
        private System.Windows.Forms.Label APKMINIMARKET;
    }
}

