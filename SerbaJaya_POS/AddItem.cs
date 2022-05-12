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
    public partial class AddItem : Form
    {
        string idIncrement()
        {
            var conn = new Connection.Connection_Query();
            string query =
                "SELECT TOP 1 * FROM DataItem ORDER BY ItemID DESC";

            int temp = 0;

            try
            {
                conn.OpenConnection();

                var dr = conn.DataReader(query);

                if (dr.Read())
                {
                    string tempID = dr.GetValue(0).ToString().Trim();
                    string lastDigit = tempID.Substring(tempID.Length - 3);
                    temp = Convert.ToInt32(lastDigit);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.CloseConnectoin();

            int digit = 3;

            int increment = temp + 1;

            var id = $"MK{increment.ToString().PadLeft(digit, '0')}";

            return id;
        }

        void insertData()
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                string query = "INSERT INTO DataItem " +
                    "(ItemID, ItemName, Cost, SalesPrice, Stock, Descriptions, IsDiscontinued)" +
                    $"VALUES('{tbID.Text}', '{tbName.Text}', '{tbCost.Text}', '{tbPrice.Text}', " +
                    $" '{tbStock.Text}', '{tbDesc.Text}', 'false' )";

                conn.ExecuteQueires(query);

                MessageBox.Show("Data Successfully Inserted");
                refreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void updateData()
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                string query = "UPDATE DataItem " +
                    $"SET ItemName = '{tbName.Text}', " +
                    $"Cost = '{tbCost.Text}'," +
                    $"SalesPrice = '{tbPrice.Text}'," +
                    $"Stock = '{tbStock.Text}', " +
                    $"Descriptions = '{tbDesc.Text}' " +
                    $"WHERE ItemID = '{tbID.Text}' ";

                conn.ExecuteQueires(query);
                MessageBox.Show("Data Berhasil di update!");
                refreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void handleStatus(string status)
        {

            var conn = new Connection.Connection_Query();

            conn.OpenConnection();
            try
            {
                string queryUpdtDisc = $"Update DataItem SET IsDiscontinued = '{status}' ";
                conn.ExecuteQueires(queryUpdtDisc);
                MessageBox.Show("data berhasil di non-aktifkan!");
            }
            catch (Exception ex2)
            {
                MessageBox.Show("terjadi error pada database, harap hubungi pihak terkait.");
            }
            finally
            {
                conn.CloseConnectoin();
            }

        }

        void deleteData(String itemID)
        {
            DialogResult result = MessageBox.Show("Hapus Supplier?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var conn = new Connection.Connection_Query();
                conn.OpenConnection();

                try
                {
                    string query = $"DELETE FROM DataItem WHERE ItemID = '{itemID}' ";

                    conn.ExecuteQueires(query);
                    MessageBox.Show("Supplier berhasil dihapus!");
                    refreshForm();
                }
                catch (Exception ex)
                {
                    conn.CloseConnectoin();
                    DialogResult confirmDisc = MessageBox.Show("Data tidak dapat dihapus karena terikat dengan data lain,  Ingin non-aktifkan barang?",
                   "Confirmation", MessageBoxButtons.YesNo);
                    if (confirmDisc == DialogResult.Yes)
                    {
                        handleStatus("true");
                    }
                }
            }
        }

        string selectStr = "ItemID, itemName, Cost, SalesPrice, Stock, Descriptions, IsDiscontinued";
        void loadData(string filter = null)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                string query = $"SELECT {selectStr} FROM DataItem WHERE " +
                      $"(( ItemID IS NULL OR ItemID LIKE '%{filter}%' ) OR " +
                    $"( ItemName IS NULL or ItemName LIKE '%{filter}%' ) OR " +
                    $"( Cost IS NULL or Cost LIKE '%{filter}%' ) OR " +
                    $"( SalesPrice IS NULL or SalesPrice LIKE '%{filter}%' ) OR " +
                    $"( Stock IS NULL or Stock LIKE '%{filter}%' ) OR " +
                    $"( Descriptions IS NULL or Descriptions LIKE '%{filter}%' )) AND " +
                    $"IsDiscontinued = 'false' ";

                dgvItem.DataSource = conn.ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.CloseConnectoin();                
            }
        }

        void loadDataDisc(string filter = null)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                string query = $"SELECT {selectStr} FROM DataItem WHERE " +
                      $"(( ItemID IS NULL OR ItemID LIKE '%{filter}%' ) OR " +
                    $"( ItemName IS NULL or ItemName LIKE '%{filter}%' ) OR " +
                    $"( Cost IS NULL or Cost LIKE '%{filter}%' ) OR " +
                    $"( SalesPrice IS NULL or SalesPrice LIKE '%{filter}%' ) OR " +
                    $"( Stock IS NULL or Stock LIKE '%{filter}%' ) OR " +
                    $"( Descriptions IS NULL or Descriptions LIKE '%{filter}%' )) AND " +
                    $"IsDiscontinued = 'true' ";

                dgvItemDisc.DataSource = conn.ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.CloseConnectoin();
            }
        }

        bool checkFormEmpty()
        {
            if (tbName.Text != "" && tbCost.Text != "" && tbPrice.Text != "" &&
                tbStock.Text != "" && tbDesc.Text != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //clearForm
        void clearForm()
        {
            tbID.Clear();
            tbName.Clear();
            tbPrice.Clear();
            tbCost.Clear();
            tbStock.Clear();
            tbDesc.Clear();
        }

        //handle Button
        void handleButtonUpdate(bool status)
        {
            if (status == true)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnCancel.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        //handle load form
        void refreshForm()
        {
            clearForm();
            tbID.Text = idIncrement();
            tbStock.Text = "0";
            tbCost.Text = "0";
            handleButtonUpdate(false);
            loadData();
            loadDataDisc();
        }

        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            refreshForm();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            loadData(tbFilter.Text);
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var currentColumn = senderGrid.Columns[e.ColumnIndex];

            if (currentColumn is DataGridViewButtonColumn &&
               e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvItem.Rows[e.RowIndex];

                string id = row.Cells[2].Value.ToString();
                string nama = row.Cells[3].Value.ToString();
                string cost = row.Cells[4].Value.ToString();
                string price = row.Cells[5].Value.ToString();
                string stock = row.Cells[6].Value.ToString();
                string desc = row.Cells[7].Value.ToString();

                if (currentColumn.HeaderText == "Delete")
                {
                    deleteData(id);
                }
                else if (currentColumn.HeaderText == "Edit")
                {

                    tbID.Text = id;
                    tbName.Text = nama;
                    tbCost.Text = cost;
                    tbPrice.Text = price;
                    tbStock.Text = stock;
                    tbDesc.Text = desc;

                    handleButtonUpdate(true);

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkFormEmpty() == false)
            {
                insertData();
            }
            else
            {
                MessageBox.Show("Harap isi semua data terlebih dahulu");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkFormEmpty() == false)
            {
                updateData();
            }
            else
            {
                MessageBox.Show("Harap isi semua data terlebih dahulu");
            }
        }

        private void dgvItemDisc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            var currentColumn = senderGrid.Columns[e.ColumnIndex];

            if (currentColumn is DataGridViewButtonColumn &&
               e.RowIndex >= 0)
            {
                DialogResult confirmDisc = MessageBox.Show("Aktifkan item kembali?",
                   "Confirmation", MessageBoxButtons.YesNo);
                if (confirmDisc == DialogResult.Yes)
                {
                    handleStatus("false");
                }
            }

        }
    }

}
