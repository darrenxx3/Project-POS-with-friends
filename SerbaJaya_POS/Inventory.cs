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
    public partial class Inventory : Form
    {
        string selectStr = "ItemID, itemName, SalesPrice, Stock, Descriptions";
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
                    $"IsDiscontinued = 'false' AND " +
                    $"Stock > 0 ";

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

        void loadDataEmpty(string filter = null)
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
                    $"IsDiscontinued = 'false' AND " +
                    $"Stock = 0";

                dgvItemEmpty.DataSource = conn.ShowDataInGridView(query);
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

        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            loadData();
            loadDataEmpty();
        }


        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            loadData(tbFilter.Text);
            loadDataEmpty(tbFilter.Text);
        }
    }
}
