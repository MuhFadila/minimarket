using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace minimarket
{
    public partial class Penjualan : Form
    {
        public static string id_barang;
        public static string nm_barang;
        public static string jml_barang;
        public static string harga_barang;
        public static string total;
        public static string Bayar;
        public static string Kembalian;
        public static string tgl;

        string connectionString = "data source=LAPTOP-U3C1SDFR\\MUHAMMADFADILA;database=minimarket3;MultipleActiveResultSets=True;User ID = sa; Password = 123";
        private SqlConnection koneksi;
        public Penjualan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
        }
        private void fetchData()
        {
            koneksi.Open();
            string query = "select * from barang";
            SqlDataAdapter sda = new SqlDataAdapter(query, koneksi);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            dataGridViewPenjualan.DataSource = data.Tables[0];
            koneksi.Close();
        }

        private void fetchData1()
        {
            koneksi.Open();
            string query = "select Id_barang, Nama_barang, Jumlah_barang, Harga_jual from Barang";
            SqlDataAdapter sda = new SqlDataAdapter(query, koneksi);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            koneksi.Close();
        }

        private void refreshform()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            clearBinding();
            
        }

        private void clearBinding()
        {
            this.comboBox1.DataBindings.Clear();
            this.textBox1.DataBindings.Clear();
            this.textBox2.DataBindings.Clear();
            this.textBox3.DataBindings.Clear();
            this.textBox4.DataBindings.Clear();
        }

        



        private void Penjualan_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            this.barangTableAdapter.Fill(this.dataSet2.Barang);
            fetchData();
            fetchData1();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Membuat perintah SQL untuk mengambil daftar id_barang dari tabel "barang"
                string sql = "SELECT id_barang FROM barang";
                SqlCommand command = new SqlCommand(sql, connection);

                // Membaca hasil perintah SQL menggunakan SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> idBarangList = new List<string>();

                    while (reader.Read())
                    {
                        string idBarang = reader.GetString(0); // Anggap id_barang berada di kolom pertama (indeks 0)
                        idBarangList.Add(idBarang);
                    }

                    // Menyimpan daftar id_barang ke dalam ComboBox
                    comboBox1.DataSource = idBarangList;
                    dataGridViewPenjualan.DataSource = dataSet2;
                }
            }
        }

        
    

    private void dataGridViewPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fetchDataSpecific()
        {
            koneksi.Open();
            string query = "select id_barang from barang where id_barang ='" + comboBox1.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, koneksi);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            dataGridViewPenjualan.DataSource = data.Tables[0];
            koneksi.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchDataSpecific();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        

        private void buttonDone_Click(object sender, EventArgs e)
        {
            id_barang = comboBox1.Text;
            nm_barang = textBox1.Text; 
            jml_barang = textBox2.Text; 
            harga_barang = textBox3.Text;
            total = Gtotal.Text; 
            Bayar = textBox4.Text;
            Kembalian = labelchange.Text;
            tgl = Date.Text;
            HISTORI n=new HISTORI();
            n.Show();
        }

        private void buttoncalt_Click(object sender, EventArgs e)
        {
            // Mengambil nilai dari TextBox1 dan TextBox2
            decimal textBox4Value;
            decimal GtotalValue;

            if (decimal.TryParse(textBox4.Text, out textBox4Value) && decimal.TryParse(Gtotal.Text, out GtotalValue))
            {
                if (GtotalValue > textBox4Value)
                {
                    decimal result = textBox4Value - GtotalValue;

                    labelchange.Text = result.ToString();
                    MessageBox.Show("Paid Amount Not Enough To Complete Purchase");
                }
                else if (textBox4Value > GtotalValue)
                {
                    decimal result = GtotalValue-textBox4Value;

                    labelchange.Text = result.ToString();
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void Gtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            // Mengambil nilai dari TextBox jumlah dan harga
            int jumlah;
            decimal harga;

            if (int.TryParse(textBox1.Text, out jumlah) && decimal.TryParse(textBox3.Text, out harga))
            {
                // Melakukan perhitungan penjumlahan
                decimal total = jumlah * harga;

                // Menampilkan total pada TextBox total
                Gtotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input in TextBox Jumlah or Harga");
            }
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 fe = new Form1();
            fe.Show();
            this.Hide();
        }
    }
}
