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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace minimarket
{
    public partial class DATA_BARANG : Form
    {

        string connectionString = "data source=LAPTOP-U3C1SDFR\\MUHAMMADFADILA;database=minimarket;MultipleActiveResultSets=True;User ID = sa; Password = 123";
        private SqlConnection koneksi;
        public DATA_BARANG()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
            refreshform();
        }

        private void refreshform()
        {
            textBoxid_barang.Enabled = false;
            textBoxnm_barang.Enabled = false;
            textBoxharga_beli.Enabled = false;
            textBoxharga_jual.Enabled = false;
            textBoxjml_barang.Enabled = false;
            clearBinding();
            FormDATA_BARANG_Load();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form1 fe = new Form1();
            fe.Show();
            this.Hide();
        }

        private void DATA_BARANG_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            textBoxid_barang.Enabled = true;
            textBoxnm_barang.Enabled = true;
            textBoxharga_beli.Enabled = true;
            textBoxharga_jual.Enabled = true;
            textBoxjml_barang.Enabled = true;

        }

        private void clearBinding()
        {
            this.textBoxid_barang.DataBindings.Clear();
            this.textBoxnm_barang.DataBindings.Clear();
            this.textBoxharga_beli.DataBindings.Clear();
            this.textBoxharga_jual.DataBindings.Clear();
            this.textBoxjml_barang.DataBindings.Clear();
        }

        private void FormDATA_BARANG_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT id_barang, nama_barang, harga_beli, harga_jual, jumlah_barang FROM barang", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.BarangbindingSource.DataSource = ds.Tables[0];
            this.textBoxid_barang.DataBindings.Add(
                new Binding("Text", this.BarangbindingSource, "id_barang", true));
            this.textBoxnm_barang.DataBindings.Add(
                new Binding("Text", this.BarangbindingSource, "nama_barang", true));
            this.textBoxharga_beli.DataBindings.Add(
                new Binding("Text", this.BarangbindingSource, "harga_beli", true));
            this.textBoxharga_jual.DataBindings.Add(
                new Binding("Text", this.BarangbindingSource, "harga_jual", true));
            this.textBoxjml_barang.DataBindings.Add(
                new Binding("Text", this.BarangbindingSource, "jumlah_barang", true));

            koneksi.Close();
        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BarangbindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
