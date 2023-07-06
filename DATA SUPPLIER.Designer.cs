namespace minimarket
{
    partial class DATA_SUPPLIER
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
            this.dataGridViewSupp = new System.Windows.Forms.DataGridView();
            this.id_supp = new System.Windows.Forms.Label();
            this.nm_supp = new System.Windows.Forms.Label();
            this.alamat_supp = new System.Windows.Forms.Label();
            this.no_telp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupp)).BeginInit();
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
            // dataGridViewSupp
            // 
            this.dataGridViewSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupp.Location = new System.Drawing.Point(30, 37);
            this.dataGridViewSupp.Name = "dataGridViewSupp";
            this.dataGridViewSupp.RowHeadersWidth = 51;
            this.dataGridViewSupp.RowTemplate.Height = 24;
            this.dataGridViewSupp.Size = new System.Drawing.Size(401, 346);
            this.dataGridViewSupp.TabIndex = 1;
            // 
            // id_supp
            // 
            this.id_supp.AutoSize = true;
            this.id_supp.Location = new System.Drawing.Point(462, 116);
            this.id_supp.Name = "id_supp";
            this.id_supp.Size = new System.Drawing.Size(77, 16);
            this.id_supp.TabIndex = 2;
            this.id_supp.Text = "ID_Supplier";
            // 
            // nm_supp
            // 
            this.nm_supp.AutoSize = true;
            this.nm_supp.Location = new System.Drawing.Point(462, 173);
            this.nm_supp.Name = "nm_supp";
            this.nm_supp.Size = new System.Drawing.Size(97, 16);
            this.nm_supp.TabIndex = 3;
            this.nm_supp.Text = "Nama Supplier";
            // 
            // alamat_supp
            // 
            this.alamat_supp.AutoSize = true;
            this.alamat_supp.Location = new System.Drawing.Point(462, 227);
            this.alamat_supp.Name = "alamat_supp";
            this.alamat_supp.Size = new System.Drawing.Size(49, 16);
            this.alamat_supp.TabIndex = 4;
            this.alamat_supp.Text = "Alamat";
            // 
            // no_telp
            // 
            this.no_telp.AutoSize = true;
            this.no_telp.Location = new System.Drawing.Point(462, 285);
            this.no_telp.Name = "no_telp";
            this.no_telp.Size = new System.Drawing.Size(56, 16);
            this.no_telp.TabIndex = 5;
            this.no_telp.Text = "No Telp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(582, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(582, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(582, 285);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 9;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(494, 360);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(610, 360);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // DATA_SUPPLIER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.no_telp);
            this.Controls.Add(this.alamat_supp);
            this.Controls.Add(this.nm_supp);
            this.Controls.Add(this.id_supp);
            this.Controls.Add(this.dataGridViewSupp);
            this.Controls.Add(this.BACK);
            this.Name = "DATA_SUPPLIER";
            this.Text = "DATA_SUPPLIER";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.DataGridView dataGridViewSupp;
        private System.Windows.Forms.Label id_supp;
        private System.Windows.Forms.Label nm_supp;
        private System.Windows.Forms.Label alamat_supp;
        private System.Windows.Forms.Label no_telp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
    }
}