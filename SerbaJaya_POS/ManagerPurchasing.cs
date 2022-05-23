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
using Microsoft.VisualBasic;

namespace SerbaJaya_POS
{
    public partial class ManagerPurchasing : Form
    {
        string managerID;

        void loadReport()
        {
            string query = "{PurchaseOrder.PurchaseOrderID} = '" + tbPOid.Text + "' ";
            LoadReport report = new LoadReport(query, "po");
            report.Show();
        }

        void insertPO()
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                string insertQuery =
                      "INSERT INTO PurchaseOrder(PurchaseOrderID, SupplierID, OrderDate, EmployeeID, IsDone) " +
                      $"VALUES('{tbPOid.Text}', '{tbSupplierID.Text}', '{DateTime.Now.ToString("MM/dd/yyyy")}' ,'{tbManager.Text}', 'false')";

                conn.ExecuteQueires(insertQuery);               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fail to create Purchase Order:" + ex.ToString());
                return;
            }
            finally
            {
                conn.CloseConnectoin();
            }

            insertPODetail();
            loadReport();            
            MessageBox.Show("Purchase Order successfully created!");
            refreshForm();
        }

        void insertPODetail()
        {
            var conn = new Connection.Connection_Query();

            foreach(DataGridViewRow row in dgvCart.Rows)
            {
                string itemID = row.Cells[1].Value.ToString();
                string Qty = row.Cells[3].Value.ToString();
                string cost = row.Cells[4].Value.ToString();

                try
                {
                    conn.OpenConnection();
                    string query = "INSERT INTO PurchaseOrderDetail(PurchaseOrderID, ItemID, Quantity, Price, IsComplete) " +
                        $"VALUES('{tbPOid.Text}', '{itemID}', '{Qty}', '{cost}', 'false')";

                    conn.ExecuteQueires(query);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("fail to insert data: " + ex.ToString());
                }
                finally
                {
                    conn.CloseConnectoin();
                }
            }
        }

        void loadDGV(string query, DataGridView dgv)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {               
                dgv.DataSource = conn.ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void loadSupplier(string filter = null)
        {
            string query = "SELECT SupplierID, SupplierName, SupplierAddress, SupplierPhone " +
                "FROM Supplier WHERE IsActive = 'true' AND (" +
                $"(SupplierID IS NULL OR SupplierID LIKE '%{filter}%' ) OR " +
                $"(SupplierName IS NULL OR SupplierName LIKE '%{filter}%' ) OR " +
                $"(SupplierAddress IS NULL OR SupplierAddress LIKE '%{filter}%' ) OR " +
                $"(SupplierPhone IS NULL OR SupplierPhone LIKE '%{filter}%' ))";
            loadDGV(query, dgvSupplier);
        }

        void loadItem(string filter = null)
        {
            string query =
                "SELECT ItemID, ItemName, Cost, SalesPrice, Stock " +
                "FROM DataItem WHERE IsDiscontinued = 'false' AND (" +
                $"(ItemID IS NULL OR ItemID LIKE '%{filter}%') OR " +
                $"(ItemName IS NULL OR ItemName LIKE '%{filter}%') OR " +
                $"(Cost IS NULL OR Cost LIKE '%{filter}%') OR " +
                $"(SalesPrice IS NULL OR SalesPrice LIKE '%{filter}%') OR " +
                $"(Stock IS NULL OR Stock LIKE '%{filter}%') ) ";
            loadDGV(query, dgvItem);
        }

        string getID()
        {
            var conn = new Connection.Connection_Query();
            string query =
                "SELECT COUNT(*) FROM PurchaseOrder";

            int row = 0;

            try
            {
                conn.OpenConnection();

                row = conn.ExecuteScalar(query) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.CloseConnectoin();

            int digit = 4;


            var id = $"P{row.ToString().PadLeft(digit, '0')}";

            return id;
        }


        void updateSubTotal()
        {
            int total = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                total += Convert.ToInt32(row.Cells["TotalCost"].Value);
            }


            tbCost.Text = total.ToString();
        }

        //Get QTY Input
        string getQtyBox(int curStock = 0)
        {

            try
            {
                string input = Interaction.InputBox("Insert Quantity",
                       "Title",
                       "1");

                int finalQty = Convert.ToInt32(input) + curStock;

                if (input == "" || finalQty <= 0)
                {
                    return "1";
                }

                return (finalQty.ToString());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        string getCost(int cost, string currentCost)
        {
            if (Convert.ToInt32(currentCost) <= 0) currentCost = "10000";

            try
            {
                string input = Interaction.InputBox("How much is it cost?",
                           "Title",
                           currentCost);

                if (Convert.ToInt32(input) > cost)
                {
                    MessageBox.Show("Cost cannot over sell price");
                    return cost.ToString();
                }
                else if(input == "" || Convert.ToInt32(input) <= 0)
                {
                    return currentCost;
                }

                return input;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ManagerPurchasing(string employeeID)
        {
            InitializeComponent();
            managerID = employeeID;
        }

        void refreshForm()
        {
            dgvCart.Rows.Clear();
            tbManager.Text = managerID;
            tbPOid.Text = getID();
            tbDate.Text = DateTime.Now.ToString();
            loadSupplier();
            loadItem();
        }

        private void ManagerPurchasing_Load(object sender, EventArgs e)
        {
            refreshForm();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCreatePO_Click(object sender, EventArgs e)
        {
            if(dgvCart.Rows.Count > 0 && tbSupplierID.Text != "")
            {
                insertPO();
            }
            else
            {
                MessageBox.Show("Please fill all the required information!");
            }
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvItem.Rows[e.RowIndex];
                string itemID = row.Cells[1].Value.ToString();
                string itemName = row.Cells[2].Value.ToString();
                string cost = row.Cells[3].Value.ToString();
                string price = row.Cells[4].Value.ToString();



                foreach (DataGridViewRow rowCart in dgvCart.Rows)
                {
                    if (rowCart.Cells[1].Value.ToString() == itemID)
                    {
                        int curQty = Convert.ToInt32(rowCart.Cells[3].Value);
                        string UpdatedQTY = getQtyBox(curQty);

                        if (UpdatedQTY == null) return;

                        int CurrentCost = Convert.ToInt32(rowCart.Cells[4].Value);

                        rowCart.Cells[3].Value = UpdatedQTY;
                        rowCart.Cells[5].Value = CurrentCost * Convert.ToInt32(UpdatedQTY);
                        return;
                    }
                }

                string qty = getQtyBox();
                if (qty == null) return;

                string costUpdt = getCost(Convert.ToInt32(price), cost);
                if (costUpdt == null) return;


                int totalCost = Convert.ToInt32(qty) * Convert.ToInt32(costUpdt);

                string[] addRow = { null, itemID, itemName, qty, costUpdt, totalCost.ToString() };
                dgvCart.Rows.Add(addRow);
            }
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];

                tbSupplierID.Text = row.Cells[1].Value.ToString();
                tbSupplierName.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dgvCart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updateSubTotal();
        }

        private void dgvCart_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateSubTotal();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Hapus Item?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvCart.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void tbItem_TextChanged(object sender, EventArgs e)
        {
            loadItem(tbItem.Text);
        }

        private void tbSupplier_TextChanged(object sender, EventArgs e)
        {
            loadSupplier(tbSupplier.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
        }
    }
}
