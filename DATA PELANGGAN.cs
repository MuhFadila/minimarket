using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minimarket
{
    public partial class DATA_PELANGGAN : Form
    {
        public DATA_PELANGGAN()
        {
            InitializeComponent();
        }

    

        private void DATA_PELANGGAN_Load(object sender, EventArgs e)
        {

        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form1 fe = new Form1();
            fe.Show();
            this.Hide();
        }
    }
}
