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
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace SerbaJaya_POS
{
    public partial class Kasir : Form
    {

        public string employeeID;

        //-------------Database Method---------------------

        void insertDataDetail()
        {
            foreach(DataGridViewRow row in dgvSales.Rows)
            {
                int qty = Convert.ToInt32(row.Cells[2].Value);
                string itemID = row.Cells[0].Value.ToString();
                int price = Convert.ToInt32(row.Cells[3].Value);

                string queryAdd = 
                    "INSERT INTO SalesDetail " +
                    "(SalesID, ItemID, Quantit, salesPrice) " +
                    $"VALUES ('{tbID.Text}', '{ itemID }', { qty }, {price})";

                string queryUpdt =
                    "UPDATE DataItem " +
                    $"SET Stock = Stock - {qty} " +
                    $"WHERE ItemID = '{itemID}' ";

                var conn = new Connection.Connection_Query();

                try
                {
                    conn.OpenConnection();
                    conn.ExecuteQueires(queryAdd);
                    conn.ExecuteQueires(queryUpdt);
                    conn.CloseConnectoin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void insertDataSales()
        {
            var conn = new Connection.Connection_Query();
            string query1 =
                "INSERT INTO Sales " +
                "(SalesID, TransactionDate, EmployeeID) " +
                $"VALUES ('{tbID.Text}', '{DateTime.Now}', '{tbCashier.Text}')";

            try
            {
                conn.OpenConnection();
                conn.ExecuteQueires(query1);
                conn.CloseConnectoin();

                insertDataDetail();

                MessageBox.Show("Transaksi Selesai! Terima kasih.");
                RefreshPage();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int getSubtotal(DataGridView dgv)
        {
            int total = 0;

            foreach(DataGridViewRow row in dgv.Rows)
            {
                total+= Convert.ToInt32(row.Cells["Total"].Value);
            }

            return total;
        }

        //Get Increment of Sales ID
        string idIncrement()
        {
            var conn = new Connection.Connection_Query();
            string query =
                "SELECT COUNT(*) FROM Sales";

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


            var id = $"S{row.ToString().PadLeft(digit, '0')}";

            return id;
        }

        //Load Datagridview Items
        void loadDataItem(string filter = null)
        {
            string query =
                "SELECT ItemID, ItemName, SalesPrice, Stock " +
                "FROM DataItem WHERE Stock > 0 AND " +
                $"(ItemID IS NULL OR ItemID like '%{filter}%' ) OR " +
                $"(ItemName IS NULL OR ItemName like '%{filter}%' )";

            var conn = new Connection.Connection_Query();

            try
            {
                conn.OpenConnection();
                dgvItem.DataSource = conn.ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak ada data dari Database, harap hubungi admin.");
            }

            conn.CloseConnectoin();
        }


        //----------------------------Handler-----------------------------------
        void updateSubTotal()
        {
            int subtotal = getSubtotal(dgvSales);
            double Tax = (double) subtotal * 0.11;

            tbSub.Text = subtotal.ToString("N0");
            tbTax.Text = Tax.ToString("N0");

            tbTotal.Text = (subtotal + Tax).ToString("N0");
        }

        void updateCells(int qty, int price, DataGridViewRow row)
        {
            row.Cells[2].Value = qty;
            row.Cells[4].Value = qty * price;
        }

        //Get QTY Input
        int getQtyBox(int stock, int curStock = 0)
        {
            string input = Interaction.InputBox("Insert Quantity",
                       "Title",
                       "1".Trim());

            int finalQty = Convert.ToInt32(input) + curStock;

            if (input == "")
            {
                return 0;
            }
            else if( finalQty > stock)
            {

                return stock;
            }
            return (finalQty);
        }

        void loadPage()
        {
            tbDate.Text = DateTime.Now.ToString("dd MMMM,yyyy");
            tbID.Text = idIncrement();
            tbCashier.Text = employeeID;
            loadDataItem();
        }

        void RefreshPage()
        {
            dgvSales.Rows.Clear();
            tbSearch.Clear();

            loadPage();
        }

        public Kasir(string ID)
        {
            InitializeComponent();
            employeeID = ID;
        }


        private void Kasir_Load(object sender, EventArgs e)
        {
            loadPage();
        }

        //----------------Text Box------------------------
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadDataItem(tbSearch.Text);
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

            if (Convert.ToDouble(tbTotal.Text) > 0)
            {
                btnFinish.Enabled = true;
            }
            else
            {
                btnFinish.Enabled = false;
            }

        }

        //----------------------------DataGridView------------------------------------
        private void dgvSales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updateSubTotal();
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Hapus Item?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvSales.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int index = dgvItem.CurrentCell.RowIndex;
                int stock = Convert.ToInt32(dgvItem.Rows[index].Cells[4].Value);


                string itemID = dgvItem.Rows[index].Cells[1].Value.ToString();
                string itemName = dgvItem.Rows[index].Cells[2].Value.ToString();
                string price = dgvItem.Rows[index].Cells[3].Value.ToString();

                foreach (DataGridViewRow rowSales in dgvSales.Rows)
                {
                    if (rowSales.Cells[0].Value.ToString() == itemID)
                    {
                        int curQty = Convert.ToInt32(rowSales.Cells[2].Value);
                        int finalQty = getQtyBox(stock, curQty);

                        updateCells(finalQty, Convert.ToInt32(price), rowSales);
                        return;
                    }

                }

                int qty = getQtyBox(Convert.ToInt32(stock));

                if (qty == 0) return;

                string total = (Convert.ToInt32(price) * qty).ToString();

                string[] row = { itemID,
                             itemName,
                             qty.ToString(),
                             price,
                             total
                            };
                dgvSales.Rows.Add(row);

            }
        }

        private void dgvSales_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateSubTotal();
        }

        private void dgvSales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateSubTotal();
        }

        //-------------------------------Button------------------------

        private void btnFinish_Click(object sender, EventArgs e)
        {
            insertDataSales();
        }


    }
}
