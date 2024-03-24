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
            this.components = new System.ComponentModel.Container();
            this.BACK = new System.Windows.Forms.Button();
            this.dataGridViewSupp = new System.Windows.Forms.DataGridView();
            this.id_supp = new System.Windows.Forms.Label();
            this.nm_supp = new System.Windows.Forms.Label();
            this.no_telp = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.textBoxid_supp = new System.Windows.Forms.TextBox();
            this.textBoxnm_supp = new System.Windows.Forms.TextBox();
            this.textBoxno_telp = new System.Windows.Forms.TextBox();
            this.SuppbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppbindingSource)).BeginInit();
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
            this.dataGridViewSupp.Size = new System.Drawing.Size(436, 346);
            this.dataGridViewSupp.TabIndex = 1;
            this.dataGridViewSupp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupp_CellContentClick);
            // 
            // id_supp
            // 
            this.id_supp.AutoSize = true;
            this.id_supp.Location = new System.Drawing.Point(492, 179);
            this.id_supp.Name = "id_supp";
            this.id_supp.Size = new System.Drawing.Size(77, 16);
            this.id_supp.TabIndex = 2;
            this.id_supp.Text = "ID_Supplier";
            // 
            // nm_supp
            // 
            this.nm_supp.AutoSize = true;
            this.nm_supp.Location = new System.Drawing.Point(492, 236);
            this.nm_supp.Name = "nm_supp";
            this.nm_supp.Size = new System.Drawing.Size(97, 16);
            this.nm_supp.TabIndex = 3;
            this.nm_supp.Text = "Nama Supplier";
            // 
            // no_telp
            // 
            this.no_telp.AutoSize = true;
            this.no_telp.Location = new System.Drawing.Point(492, 285);
            this.no_telp.Name = "no_telp";
            this.no_telp.Size = new System.Drawing.Size(56, 16);
            this.no_telp.TabIndex = 5;
            this.no_telp.Text = "No Telp";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(524, 360);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(677, 360);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 11;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // textBoxid_supp
            // 
            this.textBoxid_supp.Location = new System.Drawing.Point(615, 179);
            this.textBoxid_supp.Name = "textBoxid_supp";
            this.textBoxid_supp.Size = new System.Drawing.Size(166, 22);
            this.textBoxid_supp.TabIndex = 12;
            this.textBoxid_supp.TextChanged += new System.EventHandler(this.textBoxid_supp_TextChanged);
            // 
            // textBoxnm_supp
            // 
            this.textBoxnm_supp.Location = new System.Drawing.Point(615, 230);
            this.textBoxnm_supp.Name = "textBoxnm_supp";
            this.textBoxnm_supp.Size = new System.Drawing.Size(166, 22);
            this.textBoxnm_supp.TabIndex = 13;
            this.textBoxnm_supp.TextChanged += new System.EventHandler(this.textBoxnm_supp_TextChanged);
            // 
            // textBoxno_telp
            // 
            this.textBoxno_telp.Location = new System.Drawing.Point(615, 282);
            this.textBoxno_telp.Name = "textBoxno_telp";
            this.textBoxno_telp.Size = new System.Drawing.Size(166, 22);
            this.textBoxno_telp.TabIndex = 15;
            this.textBoxno_telp.TextChanged += new System.EventHandler(this.textBoxno_telp_TextChanged);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(600, 115);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 23);
            this.buttonadd.TabIndex = 16;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // DATA_SUPPLIER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBoxno_telp);
            this.Controls.Add(this.textBoxnm_supp);
            this.Controls.Add(this.textBoxid_supp);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.no_telp);
            this.Controls.Add(this.nm_supp);
            this.Controls.Add(this.id_supp);
            this.Controls.Add(this.dataGridViewSupp);
            this.Controls.Add(this.BACK);
            this.Name = "DATA_SUPPLIER";
            this.Text = "DATA_SUPPLIER";
            this.Load += new System.EventHandler(this.DATA_SUPPLIER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.DataGridView dataGridViewSupp;
        private System.Windows.Forms.Label id_supp;
        private System.Windows.Forms.Label nm_supp;
        private System.Windows.Forms.Label no_telp;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox textBoxid_supp;
        private System.Windows.Forms.TextBox textBoxnm_supp;
        private System.Windows.Forms.TextBox textBoxno_telp;
        private System.Windows.Forms.BindingSource SuppbindingSource;
        private System.Windows.Forms.Button buttonadd;
    }
}