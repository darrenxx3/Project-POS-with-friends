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
    public partial class ReportMenu : Form
    {

        void loadEmployee(
            string ID = null, 
            string nama = null,
            string role = null
        )
        {
            string query = 
                "SELECT E.*, P.PositionName FROM Employee E " +
                "INNER JOIN Position P " +
                "ON P.PositionID = E.PositionID " +
                $"WHERE (EmployeeID IS NULL OR EmployeeID like '%{ID}%') OR " +
                $"(EmployeeName IS NULL OR EmployeeName like '%{nama}%') OR" +
                $"(PositionName IS NULL OR PositionName like '%{role}%')";

            MessageBox.Show(query);

            loadDataItem(query);
        }

        void loadDataItem(string query)
        {
            
            var conn = new Connection.Connection_Query();

            try
            {
                conn.OpenConnection();
                dgvReport.DataSource = conn.ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak ada data dari Database, harap hubungi admin." + ex.ToString());
            }

            conn.CloseConnectoin();
        }

        public ReportMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ReportMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void tabControlReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlReport.SelectedIndex)
            {

                case 0:
                    {
                        loadEmployee();
                        break;
                    }
                case 1:
                    {
                        loadDataItem("DataItem");
                        break;
                    }
                case 2:
                    {
                        loadDataItem("Supplier");
                        break;
                    }
                case 3:
                    {
                        loadDataItem("Sales");
                        break;
                    }
                case 4:
                    {
                        loadDataItem("PurchaseOrder");
                        break;
                    }
            }
        }
    }

}

        




