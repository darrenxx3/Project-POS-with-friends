using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Connection.Connection_Query;

namespace SerbaJaya_POS
{
    public partial class ManagerPurchasing : Form
    {
        public ManagerPurchasing()
        {
            InitializeComponent();
        }
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem vitem = new AddItem();
            vitem.Show();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupplier vsupplier = new AddSupplier();
            vsupplier.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersediaanStok persediaanStok = new PersediaanStok();
            persediaanStok.Show();
        }
        private void ManagerPurchasing_Load(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            dataGridView1.DataSource = conn.ShowDataInGridVIew("SELECT POD.PurchaseOrderID, ItemID, Quantity, SupplierID, OrderDate, EmployeeID, OrderStatus, WarehouseNote FROM PurchaseOrderDetail POD JOIN PurchaseOrder PO ON POD.PurchaseOrderID = PO.PurchaseOrderID");
            conn.CloseConnectoin();
        }        
        private void textBoxItemName_TextChanged(object sender, EventArgs e)
        {

        }        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
