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
    public partial class DATA_PELANGGAN : Form
    {
        string connectionString = "data source=LAPTOP-U3C1SDFR\\MUHAMMADFADILA;database=minimarket3;MultipleActiveResultSets=True;User ID = sa; Password = 123";
        private SqlConnection koneksi;
        public DATA_PELANGGAN()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
            refreshform();
            clearBinding();
        }

        private void refreshform()
        {
            textBoxid_pembeli.Enabled = false;
            clearBinding();
            FormDATA_PEMBELI_Load();
        }

        private void fetchData()
        {
            koneksi.Open();
            string query = "select * from pembeli";
            SqlDataAdapter sda = new SqlDataAdapter(query, koneksi);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            dataGridViewPelanggan.DataSource = data.Tables[0];
            koneksi.Close();
        }

        private void clearBinding()
        {
            this.textBoxid_pembeli.DataBindings.Clear();
        }

        private void FormDATA_PEMBELI_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT id_pembeli FROM pembeli", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.PembelibindingSource.DataSource = ds.Tables[0];
            this.textBoxid_pembeli.DataBindings.Add(
                new Binding("Text", this.PembelibindingSource, "id_pembeli", true));

            koneksi.Close();
        }

        private void DATA_PELANGGAN_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form1 fe = new Form1();
            fe.Show();
            this.Hide();
        }

        private void dataGridViewPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxid_pembeli.Enabled = true;
           ;
        }

        private void textBoxid_pembeli_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxid_pembeli.Text == "")
                {
                    MessageBox.Show("Can't Add !\t\n Missing Info");
                }
                else
                {
                    koneksi.Open();
                    String query = "insert into pembeli (id_pembeli) values ('" + textBoxid_pembeli.Text + "')";
                    SqlCommand command = new SqlCommand(query, koneksi);
                    command.ExecuteNonQuery();
                    MessageBox.Show("data Added Successfully");
                    koneksi.Close();
                    textBoxid_pembeli.Text = "";
     
                    pembeli();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.Close();
            }
        }

        private void pembeli()
        {
            koneksi.Open();
            string query = "select * from pembeli";
            SqlDataAdapter sda = new SqlDataAdapter(query, koneksi);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            dataGridViewPelanggan.DataSource = data.Tables[0];
            koneksi.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxid_pembeli.Text == "")
                {
                    MessageBox.Show("id Not Selected \nPlease select the id to delete");
                }
                else
                {
                    koneksi.Open();
                    String query = "delete from pembeli where id_pembeli =" + textBoxid_pembeli.Text + "";
                    SqlCommand command = new SqlCommand(query, koneksi);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    koneksi.Close();
                    textBoxid_pembeli.Text = "";
                    pembeli();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.Close();
            }
        }
    }
}
