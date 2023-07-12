using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minimarket
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void DATABARANG_Click(object sender, EventArgs e)
        {
            {
                DATA_BARANG fe = new DATA_BARANG();
                fe.Show();
                this.Hide();
            }
        }

        private void DATASUPPLIER_Click(object sender, EventArgs e)
        {
            DATA_SUPPLIER fe = new DATA_SUPPLIER();
            fe.Show();
            this.Hide();
        }

        private void DATAPELANGGAN_Click(object sender, EventArgs e)
        {
            DATA_PELANGGAN fe = new DATA_PELANGGAN();
            fe.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PENJUALAN_Click(object sender, EventArgs e)
        {
            Penjualan fe = new Penjualan();
            fe.Show();
            this.Hide();
        }
    }
}
