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
    public partial class DATA_SUPPLIER : Form
    {
        string connectionString = "data source=LAPTOP-U3C1SDFR\\MUHAMMADFADILA;database=minimarket3;MultipleActiveResultSets=True;User ID = sa; Password = 123";
        private SqlConnection koneksi;
        public DATA_SUPPLIER()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
            refreshform();
            clearBinding();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form1 fe = new Form1();
            fe.Show();
            this.Hide();
        }

        private void refreshform()
        {
            textBoxid_supp.Enabled = false;
            textBoxnm_supp.Enabled = false;
            textBoxno_telp.Enabled = false;
            clearBinding();
            FormDATA_SUPP_Load();
        }

        private void fetchData()
        {
            koneksi.Open();
            string query = "select * from supplier";
            SqlDataAdapter sda = new SqlDataAdapter(query, koneksi);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            dataGridViewSupp.DataSource = data.Tables[0];
            koneksi.Close();
        }

        private void clearBinding()
        {
            this.textBoxid_supp.DataBindings.Clear();
            this.textBoxnm_supp.DataBindings.Clear();
            this.textBoxno_telp.DataBindings.Clear();
        }

        private void FormDATA_SUPP_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT id_supplier, nama_supplier, no_hp FROM supplier", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.SuppbindingSource.DataSource = ds.Tables[0];
            this.textBoxid_supp.DataBindings.Add(
                new Binding("Text", this.SuppbindingSource, "id_supplier", true));
            this.textBoxnm_supp.DataBindings.Add(
                new Binding("Text", this.SuppbindingSource, "nama_supplier", true));
            this.textBoxno_telp.DataBindings.Add(
                new Binding("Text", this.SuppbindingSource, "no_hp", true));

            koneksi.Close();
        }

        private void DATA_SUPPLIER_Load(object sender, EventArgs e)
        {
            
            
            
            fetchData();
        }

        private void dataGridViewSupp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBoxid_supp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnm_supp_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxno_telp_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxid_supp.Text == "" || textBoxnm_supp.Text == "" || textBoxno_telp.Text == "")
                {
                    MessageBox.Show("Can't Add !\t\n Missing Info");
                }
                else
                {
                    koneksi.Open();
                    String query = "insert into supplier (id_supplier, nama_supplier, no_hp) values ('" + textBoxid_supp.Text + "','" + textBoxnm_supp.Text + "','" + textBoxno_telp.Text + "')";
                    SqlCommand command = new SqlCommand(query, koneksi);
                    command.ExecuteNonQuery();
                    MessageBox.Show("data Added Successfully");
                    koneksi.Close();
                    textBoxid_supp.Text = "";
                    textBoxnm_supp.Text = "";
                    textBoxno_telp.Text = "";
                    supplier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.Close();
            }
        }

        private void supplier()
        {
            koneksi.Open();
            string query = "select * from supplier";
            SqlDataAdapter sda = new SqlDataAdapter(query, koneksi);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            dataGridViewSupp.DataSource = data.Tables[0];
            koneksi.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxid_supp.Text == "")
                {
                    MessageBox.Show("Product Not Selected \nPlease select the product to delete");
                }
                else
                {
                    koneksi.Open();
                    String query = "delete from supplier where id_supplier=" + textBoxid_supp.Text + "";
                    SqlCommand command = new SqlCommand(query, koneksi);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    koneksi.Close();
                    textBoxid_supp.Text = "";
                    textBoxnm_supp.Text = "";
                    textBoxno_telp.Text = "";
                    supplier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.Close();
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            textBoxid_supp.Enabled = true;
            textBoxnm_supp.Enabled = true;
            textBoxno_telp.Enabled = true;
        }
    }
}
