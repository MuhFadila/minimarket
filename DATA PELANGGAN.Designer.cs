namespace minimarket
{
    partial class DATA_PELANGGAN
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
            this.dataGridViewPelanggan = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxid_pembeli = new System.Windows.Forms.TextBox();
            this.labelid_pembeli = new System.Windows.Forms.Label();
            this.PembelibindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PembelibindingSource)).BeginInit();
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
            // dataGridViewPelanggan
            // 
            this.dataGridViewPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPelanggan.Location = new System.Drawing.Point(60, 54);
            this.dataGridViewPelanggan.Name = "dataGridViewPelanggan";
            this.dataGridViewPelanggan.RowHeadersWidth = 51;
            this.dataGridViewPelanggan.RowTemplate.Height = 24;
            this.dataGridViewPelanggan.Size = new System.Drawing.Size(465, 303);
            this.dataGridViewPelanggan.TabIndex = 1;
            this.dataGridViewPelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPelanggan_CellContentClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(583, 296);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(685, 296);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(624, 179);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxid_pembeli
            // 
            this.textBoxid_pembeli.Location = new System.Drawing.Point(624, 235);
            this.textBoxid_pembeli.Name = "textBoxid_pembeli";
            this.textBoxid_pembeli.Size = new System.Drawing.Size(136, 22);
            this.textBoxid_pembeli.TabIndex = 5;
            this.textBoxid_pembeli.TextChanged += new System.EventHandler(this.textBoxid_pembeli_TextChanged);
            // 
            // labelid_pembeli
            // 
            this.labelid_pembeli.AutoSize = true;
            this.labelid_pembeli.Location = new System.Drawing.Point(542, 238);
            this.labelid_pembeli.Name = "labelid_pembeli";
            this.labelid_pembeli.Size = new System.Drawing.Size(70, 16);
            this.labelid_pembeli.TabIndex = 6;
            this.labelid_pembeli.Text = "Id pembeli";
            // 
            // DATA_PELANGGAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelid_pembeli);
            this.Controls.Add(this.textBoxid_pembeli);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewPelanggan);
            this.Controls.Add(this.BACK);
            this.Name = "DATA_PELANGGAN";
            this.Text = "DATA_PELANGGAN";
            this.Load += new System.EventHandler(this.DATA_PELANGGAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PembelibindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.DataGridView dataGridViewPelanggan;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxid_pembeli;
        private System.Windows.Forms.Label labelid_pembeli;
        private System.Windows.Forms.BindingSource PembelibindingSource;
    }
}