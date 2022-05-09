using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerbaJaya_POS
{
    public partial class PersediaanStok : Form
    {
        public PersediaanStok()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersediaanStok_Load(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            dataGridView1.DataSource = conn.ShowDataInGridVIew("SELECT ItemID, ItemName, Stock FROM DataItem ORDER BY Stock");
            conn.CloseConnectoin();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            dataGridView1.DataSource = conn.ShowDataInGridVIew("SELECT ItemID, ItemName, Stock FROM DataItem WHERE ItemName LIKE '%" + textBox1.Text + "%' ORDER BY Stock");
            conn.CloseConnectoin();
        }
    }
}
