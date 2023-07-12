namespace minimarket
{
    partial class Penjualan
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewPenjualan = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new minimarket.DataSet2();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new minimarket.DataSet2TableAdapters.BarangTableAdapter();
            this.labelId_barang = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelnm_barang = new System.Windows.Forms.Label();
            this.labeljml_barang = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelBayar = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSourcePenjualan = new System.Windows.Forms.BindingSource(this.components);
            this.Date = new System.Windows.Forms.Label();
            this.buttoncalt = new System.Windows.Forms.Button();
            this.labelchange = new System.Windows.Forms.Label();
            this.Gtotal = new System.Windows.Forms.TextBox();
            this.labeltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.dATABARANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABARANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPenjualan
            // 
            this.dataGridViewPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPenjualan.Location = new System.Drawing.Point(-1, 373);
            this.dataGridViewPenjualan.Name = "dataGridViewPenjualan";
            this.dataGridViewPenjualan.RowHeadersWidth = 51;
            this.dataGridViewPenjualan.RowTemplate.Height = 24;
            this.dataGridViewPenjualan.Size = new System.Drawing.Size(10, 175);
            this.dataGridViewPenjualan.TabIndex = 0;
            this.dataGridViewPenjualan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPenjualan_CellContentClick);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.dataSet2;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // labelId_barang
            // 
            this.labelId_barang.AutoSize = true;
            this.labelId_barang.Location = new System.Drawing.Point(59, 25);
            this.labelId_barang.Name = "labelId_barang";
            this.labelId_barang.Size = new System.Drawing.Size(66, 16);
            this.labelId_barang.TabIndex = 1;
            this.labelId_barang.Text = "ID barang";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelnm_barang
            // 
            this.labelnm_barang.AutoSize = true;
            this.labelnm_barang.Location = new System.Drawing.Point(59, 66);
            this.labelnm_barang.Name = "labelnm_barang";
            this.labelnm_barang.Size = new System.Drawing.Size(90, 16);
            this.labelnm_barang.TabIndex = 4;
            this.labelnm_barang.Text = "Nama Produk";
            // 
            // labeljml_barang
            // 
            this.labeljml_barang.AutoSize = true;
            this.labeljml_barang.Location = new System.Drawing.Point(59, 108);
            this.labeljml_barang.Name = "labeljml_barang";
            this.labeljml_barang.Size = new System.Drawing.Size(50, 16);
            this.labeljml_barang.TabIndex = 5;
            this.labeljml_barang.Text = "Jumlah";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(59, 153);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(45, 16);
            this.labelHarga.TabIndex = 6;
            this.labelHarga.Text = "Harga";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(216, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 8;
            // 
            // labelBayar
            // 
            this.labelBayar.AutoSize = true;
            this.labelBayar.Location = new System.Drawing.Point(54, 267);
            this.labelBayar.Name = "labelBayar";
            this.labelBayar.Size = new System.Drawing.Size(43, 16);
            this.labelBayar.TabIndex = 9;
            this.labelBayar.Text = "Bayar";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(216, 267);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 22);
            this.textBox4.TabIndex = 10;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(87, 304);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 11;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(216, 304);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 175);
            this.dataGridView1.TabIndex = 13;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(949, 9);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(36, 16);
            this.Date.TabIndex = 14;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // buttoncalt
            // 
            this.buttoncalt.Location = new System.Drawing.Point(394, 267);
            this.buttoncalt.Name = "buttoncalt";
            this.buttoncalt.Size = new System.Drawing.Size(75, 23);
            this.buttoncalt.TabIndex = 15;
            this.buttoncalt.Text = "Calt";
            this.buttoncalt.UseVisualStyleBackColor = true;
            this.buttoncalt.Click += new System.EventHandler(this.buttoncalt_Click);
            // 
            // labelchange
            // 
            this.labelchange.AutoSize = true;
            this.labelchange.Location = new System.Drawing.Point(577, 273);
            this.labelchange.Name = "labelchange";
            this.labelchange.Size = new System.Drawing.Size(54, 16);
            this.labelchange.TabIndex = 16;
            this.labelchange.Text = "Change";
            // 
            // Gtotal
            // 
            this.Gtotal.Location = new System.Drawing.Point(216, 216);
            this.Gtotal.Name = "Gtotal";
            this.Gtotal.Size = new System.Drawing.Size(121, 22);
            this.Gtotal.TabIndex = 17;
            this.Gtotal.TextChanged += new System.EventHandler(this.Gtotal_TextChanged);
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(57, 216);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(38, 16);
            this.labeltotal.TabIndex = 18;
            this.labeltotal.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kembalian";
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(394, 132);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(75, 23);
            this.buttonTotal.TabIndex = 20;
            this.buttonTotal.Text = "Total";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // dATABARANGBindingSource
            // 
            this.dATABARANGBindingSource.DataSource = typeof(minimarket.DATA_BARANG);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1034, 510);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 545);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.Gtotal);
            this.Controls.Add(this.labelchange);
            this.Controls.Add(this.buttoncalt);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelBayar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labeljml_barang);
            this.Controls.Add(this.labelnm_barang);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelId_barang);
            this.Controls.Add(this.dataGridViewPenjualan);
            this.Name = "Penjualan";
            this.Text = "Penjualan";
            this.Load += new System.EventHandler(this.Penjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABARANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPenjualan;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private DataSet2TableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.BindingSource dATABARANGBindingSource;
        private System.Windows.Forms.Label labelId_barang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelnm_barang;
        private System.Windows.Forms.Label labeljml_barang;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelBayar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourcePenjualan;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button buttoncalt;
        private System.Windows.Forms.Label labelchange;
        private System.Windows.Forms.TextBox Gtotal;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.Button buttonBack;
    }
}