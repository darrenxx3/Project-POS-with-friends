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
    public partial class DataItem : Form
    {
        public DataItem()
        {
            InitializeComponent();
        }

        private void DataItem_Load(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            dataGridView1.DataSource = conn.ShowDataInGridView("SELECT ItemID, ItemName, Cost FROM DataItem ORDER BY ItemID");
            conn.CloseConnectoin();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            dataGridView1.DataSource = conn.ShowDataInGridView("SELECT ItemID, ItemName, Cost FROM DataItem WHERE ItemName LIKE '%" + textBox1.Text + "%'");
            conn.CloseConnectoin();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManagerPurchasing purchasing = new ManagerPurchasing();
            purchasing.textBoxItemID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            purchasing.textBoxItemName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            purchasing.textBoxCost.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            purchasing.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
