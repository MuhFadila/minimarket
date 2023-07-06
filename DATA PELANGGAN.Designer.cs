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
            this.BACK = new System.Windows.Forms.Button();
            this.dataGridViewPelanggan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelanggan)).BeginInit();
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
            // 
            // DATA_PELANGGAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPelanggan);
            this.Controls.Add(this.BACK);
            this.Name = "DATA_PELANGGAN";
            this.Text = "DATA_PELANGGAN";
            this.Load += new System.EventHandler(this.DATA_PELANGGAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelanggan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.DataGridView dataGridViewPelanggan;
    }
}