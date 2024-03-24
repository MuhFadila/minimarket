namespace minimarket
{
    partial class DATA_BARANG
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
            this.BACK = new System.Windows.Forms.Button();
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.id_barang = new System.Windows.Forms.Label();
            this.nm_barang = new System.Windows.Forms.Label();
            this.harga_beli = new System.Windows.Forms.Label();
            this.harga_jual = new System.Windows.Forms.Label();
            this.jml_barang = new System.Windows.Forms.Label();
            this.textBoxid_barang = new System.Windows.Forms.TextBox();
            this.textBoxnm_barang = new System.Windows.Forms.TextBox();
            this.textBoxharga_beli = new System.Windows.Forms.TextBox();
            this.textBoxharga_jual = new System.Windows.Forms.TextBox();
            this.textBoxjml_barang = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.BarangbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarangbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(13, 415);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(75, 23);
            this.BACK.TabIndex = 0;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(30, 33);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.RowHeadersWidth = 51;
            this.dataGridViewBarang.RowTemplate.Height = 24;
            this.dataGridViewBarang.Size = new System.Drawing.Size(736, 142);
            this.dataGridViewBarang.TabIndex = 1;
            this.dataGridViewBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBarang_CellContentClick);
            // 
            // id_barang
            // 
            this.id_barang.AutoSize = true;
            this.id_barang.Location = new System.Drawing.Point(152, 236);
            this.id_barang.Name = "id_barang";
            this.id_barang.Size = new System.Drawing.Size(67, 16);
            this.id_barang.TabIndex = 2;
            this.id_barang.Text = "ID Barang";
            // 
            // nm_barang
            // 
            this.nm_barang.AutoSize = true;
            this.nm_barang.Location = new System.Drawing.Point(152, 283);
            this.nm_barang.Name = "nm_barang";
            this.nm_barang.Size = new System.Drawing.Size(91, 16);
            this.nm_barang.TabIndex = 3;
            this.nm_barang.Text = "Nama Barang";
            // 
            // harga_beli
            // 
            this.harga_beli.AutoSize = true;
            this.harga_beli.Location = new System.Drawing.Point(152, 323);
            this.harga_beli.Name = "harga_beli";
            this.harga_beli.Size = new System.Drawing.Size(71, 16);
            this.harga_beli.TabIndex = 4;
            this.harga_beli.Text = "Harga Beli";
            // 
            // harga_jual
            // 
            this.harga_jual.AutoSize = true;
            this.harga_jual.Location = new System.Drawing.Point(152, 364);
            this.harga_jual.Name = "harga_jual";
            this.harga_jual.Size = new System.Drawing.Size(70, 16);
            this.harga_jual.TabIndex = 5;
            this.harga_jual.Text = "harga_jual";
            // 
            // jml_barang
            // 
            this.jml_barang.AutoSize = true;
            this.jml_barang.Location = new System.Drawing.Point(152, 406);
            this.jml_barang.Name = "jml_barang";
            this.jml_barang.Size = new System.Drawing.Size(101, 16);
            this.jml_barang.TabIndex = 6;
            this.jml_barang.Text = "Jumlah_Barang";
            // 
            // textBoxid_barang
            // 
            this.textBoxid_barang.Location = new System.Drawing.Point(276, 236);
            this.textBoxid_barang.Name = "textBoxid_barang";
            this.textBoxid_barang.Size = new System.Drawing.Size(122, 22);
            this.textBoxid_barang.TabIndex = 7;
            // 
            // textBoxnm_barang
            // 
            this.textBoxnm_barang.Location = new System.Drawing.Point(276, 279);
            this.textBoxnm_barang.Name = "textBoxnm_barang";
            this.textBoxnm_barang.Size = new System.Drawing.Size(122, 22);
            this.textBoxnm_barang.TabIndex = 9;
            // 
            // textBoxharga_beli
            // 
            this.textBoxharga_beli.Location = new System.Drawing.Point(276, 320);
            this.textBoxharga_beli.Name = "textBoxharga_beli";
            this.textBoxharga_beli.Size = new System.Drawing.Size(122, 22);
            this.textBoxharga_beli.TabIndex = 10;
            // 
            // textBoxharga_jual
            // 
            this.textBoxharga_jual.Location = new System.Drawing.Point(276, 361);
            this.textBoxharga_jual.Name = "textBoxharga_jual";
            this.textBoxharga_jual.Size = new System.Drawing.Size(122, 22);
            this.textBoxharga_jual.TabIndex = 11;
            // 
            // textBoxjml_barang
            // 
            this.textBoxjml_barang.Location = new System.Drawing.Point(276, 406);
            this.textBoxjml_barang.Name = "textBoxjml_barang";
            this.textBoxjml_barang.Size = new System.Drawing.Size(122, 22);
            this.textBoxjml_barang.TabIndex = 12;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(457, 276);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 13;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(561, 204);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // BarangbindingSource
            // 
            this.BarangbindingSource.CurrentChanged += new System.EventHandler(this.BarangbindingSource_CurrentChanged);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(561, 276);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 16;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(664, 276);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 17;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // DATA_BARANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBoxjml_barang);
            this.Controls.Add(this.textBoxharga_jual);
            this.Controls.Add(this.textBoxharga_beli);
            this.Controls.Add(this.textBoxnm_barang);
            this.Controls.Add(this.textBoxid_barang);
            this.Controls.Add(this.jml_barang);
            this.Controls.Add(this.harga_jual);
            this.Controls.Add(this.harga_beli);
            this.Controls.Add(this.nm_barang);
            this.Controls.Add(this.id_barang);
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.BACK);
            this.Name = "DATA_BARANG";
            this.Text = "DATA_BARANG";
            this.Load += new System.EventHandler(this.DATA_BARANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarangbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.Label id_barang;
        private System.Windows.Forms.Label nm_barang;
        private System.Windows.Forms.Label harga_beli;
        private System.Windows.Forms.Label harga_jual;
        private System.Windows.Forms.Label jml_barang;
        private System.Windows.Forms.TextBox textBoxid_barang;
        private System.Windows.Forms.TextBox textBoxnm_barang;
        private System.Windows.Forms.TextBox textBoxharga_beli;
        private System.Windows.Forms.TextBox textBoxharga_jual;
        private System.Windows.Forms.TextBox textBoxjml_barang;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.BindingSource BarangbindingSource;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
    }
}