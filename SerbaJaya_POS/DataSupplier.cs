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
    public partial class DataSupplier : Form
    {
        public DataSupplier()
        {
            InitializeComponent();
        }
        private void DataSupplier_Load(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            dataGridView1.DataSource = conn.ShowDataInGridView("SELECT SupplierID, SupplierName FROM Supplier ORDER BY SupplierID");
            conn.CloseConnectoin();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            dataGridView1.DataSource = conn.ShowDataInGridView("SELECT SupplierID, SupplierName FROM Supplier WHERE SupplierName LIKE '%" + textBox1.Text + "%'");
            conn.CloseConnectoin();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManagerPurchasing purchasing = new ManagerPurchasing();
            purchasing.tbSupplierID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            purchasing.tbSupplierName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            purchasing.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
