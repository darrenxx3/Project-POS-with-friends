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
using System.Data.SqlClient;

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
            AdminItem vitem = new AdminItem();
            vitem.Show();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSupplier vsupplier = new AdminSupplier();
            vsupplier.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*PersediaanStok persediaanStok = new PersediaanStok();
            persediaanStok.Show();*/
        }
        private void ManagerPurchasing_Load(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            dataGridView1.DataSource = conn.ShowDataInGridView("SELECT OrderDate, PO.SupplierID, SupplierName, POD.ItemID, ItemName, Cost ,Quantity FROM PurchaseOrderDetail POD JOIN PurchaseOrder PO ON POD.PurchaseOrderID = PO.PurchaseOrderID JOIN DataItem DI ON POD.ItemID = DI.ItemID JOIN Supplier S ON PO.SupplierID = S.SupplierID WHERE POD.PurchaseOrderID = '" + textBoxPOID + "'");
            conn.CloseConnectoin();
        }        
        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            DataSupplier vsupplier = new DataSupplier();
            vsupplier.Show();
        }        
        
        private void btnSearchItemName_Click(object sender, EventArgs e)
        {
        }        
        
        private void textBoxPOID_Leave(object sender, EventArgs e)
        {
            //apabila po id sudah pernah dibuat, maka tampilkan datagridview berisikan data po id tsb
            /*
            var conn = new Connection.Connection_Query();
            try
            {
                conn.OpenConnection();
                string query = "SELECT * FROM MstDosen WHERE KdDosen = @kode";
                SqlCommand CheckUser = new SqlCommand(query, conn);
                CheckUser.Parameters.AddWithValue("@kode", tbKode.Text);
                SqlDataReader DR = CheckUser.ExecuteReader();

                if (DR.Read())
                {
                    handleButton(true);
                    tbNama.Text = DR.GetValue(1).ToString();
                    tbAlamat.Text = DR.GetValue(2).ToString();
                    tbTelp.Text = DR.GetValue(3).ToString();
                    tbHp.Text = DR.GetValue(4).ToString();
                }
                else
                {
                    handleButton(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.ToString());
            }
            finally
            {
                conn.CloseConnectoin();
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add to database
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            conn.ExecuteQueires("INSERT INTO PurchaseOrder (PurchaseOrderID, SupplierID, OrderDate, EmployeeID, OrderStatus, WarehouseNote) VALUES ('" + textBoxPOID.Text + "', '" + textBoxSupplierID.Text + "', '" + this.dateTimeOrder.Text + "', 'E0002', 'Not Done', '')");
            conn.ExecuteQueires("INSERT INTO PurchaseOrderDetail (PurchaseOrderID, ItemID, Quantity) VALUES ('" + textBoxPOID.Text + "', '" + textBoxItemID + "', '" + textBoxQuantity + "')");
        }
        private void btnClearData_Click(object sender, EventArgs e)
        {
            textBoxSupplierID.Text = "";
            textBoxSupplierName.Text = "";
            textBoxItemID.Text = "";
            textBoxItemName.Text = "";
            textBoxCost.Text = "";
            textBoxQuantity.Text = "";
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



        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelTotalCost_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }


    }
}
