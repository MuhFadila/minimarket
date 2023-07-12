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
    public partial class HISTORI : Form
    {
        string connectionString = "data source=LAPTOP-U3C1SDFR\\MUHAMMADFADILA;database=minimarket3;MultipleActiveResultSets=True;User ID = sa; Password = 123";
        private SqlConnection koneksi;
        public HISTORI()
        {
            InitializeComponent();
        }



        private void HISTORI_Load(object sender, EventArgs e)
        {
            label1.Text = Penjualan.id_barang;
            label2.Text = Penjualan.nm_barang;
            label3.Text = Penjualan.jml_barang;
            label4.Text = Penjualan.harga_barang;
            label5.Text = Penjualan.total;
            label6.Text = Penjualan.Bayar;
            label7.Text = Penjualan.Kembalian;
            labeltgl.Text = Penjualan.tgl;



        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
