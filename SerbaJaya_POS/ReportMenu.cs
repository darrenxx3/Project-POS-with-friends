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
        Dictionary<string, string> employee = new Dictionary<string, string>();
        Dictionary<string, string> supplier = new Dictionary<string, string>();

        string handleStatus(string cbValue)
        {
            switch (cbValue)
            {
                case "Active":
                    {
                        return "false";
                    }
                case "Not Active":
                    {
                        return "true";
                    }
                case "- BOTH -":
                    {
                        return null;
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        string employeeQuery(
            string role = null,
            string status = null
        )
        {
            string query =
                "SELECT E.EmployeeID, E.EmployeeName , E.Address, E.PhoneNumber , P.PositionName FROM Employee E " +
                "INNER JOIN Position P " +
                "ON P.PositionID = E.PositionID " +
                $"WHERE (IsNotEmployee IS NULL OR IsNotEmployee LIKE '%{status}%') AND " +
                $"(PositionName IS NULL OR PositionName LIKE '%{role}%')";

            return query;
        }

        string itemQuery(string status = null)
        {
            string query =
                "SELECT * FROM DataItem WHERE " +
                $"(IsDiscontinued IS NULL OR IsDiscontinued LIKE '%{status}%') ";

            return query;
        }

        string handleCB(CheckBox inputCb, ComboBox inputCombo)
        {
            if (inputCb.Checked) return null;

            string employeeID = ((KeyValuePair<string, string>)inputCombo.SelectedItem).Key;
            return employeeID;
        }

        string handleDate(string start, string end, string columnName)
        {
            if (!string.IsNullOrEmpty(start) && !string.IsNullOrEmpty(end))
            {
                return $"AND (cast({columnName} AS DATE) >= '{start}' AND " +
                    $"cast({columnName} AS DATE) <= '{end}') ";
            }

            return null;
        }

        string salesQuery(
            string employeeID = null,
            string startDate = null,
            string endDate = null)
        {
            string query = "SELECT * FROM Sales WHERE " +
                $"(EmployeeID IS NULL OR EmployeeID LIKE '%{employeeID}%' ) ";

            query += handleDate(startDate, endDate, "TransactionDate");

            MessageBox.Show(query);
            return query;
        }

        string poQuery(
            string supplierID = null,
             string startDate = null,
            string endDate = null,
            string status = null
        )
        {
            string query = "SELECT PurchaseOrderID, S.SupplierName, OrderDate, E.EmployeeName,  FROM purchaseOrder P WHERE " +
                   $"(supplierID IS NULL OR supplierID LIKE '%{supplierID}%' ) AND " +
                   $"(IsDone IS NULL OR IsDone LIKE '%{status}%' )";

            query += handleDate(startDate, endDate, "OrderDate");

            MessageBox.Show(query);
            return query;
        }

        void loadDGV(string query)
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

        void loadCB(string query, ComboBox targetCB, Dictionary<string, string> targetDict)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                var dr = conn.DataReader(query);

                while (dr.Read())
                {
                    string id = dr.GetValue(0).ToString();
                    string name = dr.GetValue(1).ToString();

                    targetDict.Add(id, name);
                }

                targetCB.DataSource = new BindingSource(targetDict, null);
                targetCB.DisplayMember = "Value";
                targetCB.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("error to load combobox: " + ex.ToString());
            }
            finally
            {
                conn.CloseConnectoin();
            }
        }

        void loadAllCB()
        {
            string queryEmp = "SELECT DISTINCT S.EmployeeID, E.EmployeeName FROM Sales S " +
                    "INNER JOIN Employee E ON E.EmployeeID = S.EmployeeID ";
            loadCB(queryEmp, cbEmployeeSales, employee);

            string querySupplier = "SELECT DISTINCT P.SupplierID, S.SupplierName FROM PurchaseOrder P " +
                "INNER JOIN Supplier S ON S.SupplierID = P.SupplierID";
            loadCB(querySupplier, cbSupplierPO, supplier);
        }

        public ReportMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        void refreshPage()
        {
            switch (tabControlReport.SelectedIndex)
            {

                case 0:
                    {
                        loadDGV(employeeQuery());
                        break;
                    }
                case 1:
                    {
                        loadDGV(itemQuery());
                        break;
                    }
                case 2:
                    {
                        loadDGV(salesQuery());
                        break;
                    }
                case 3:
                    {
                        loadDGV(poQuery());
                        break;
                    }
            }
        }

        private void ReportMenu_Load(object sender, EventArgs e)
        {
            //untuk load semua data kedalam CB
            loadAllCB();
            refreshPage();
        }

        private void tabControlReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPage();
        }

        private void btnFilterEmployee_Click(object sender, EventArgs e)
        {

            string position = cbPosition.Text;
            string status = handleStatus(cbStatusEmployee.Text);

            loadDGV(employeeQuery(position, status));
        }

        private void btnFilterItem_Click(object sender, EventArgs e)
        {
            string status = handleStatus(cbStatusItem.Text);
            loadDGV(itemQuery(status));
        }

        private void btnFilterSales_Click(object sender, EventArgs e)
        {
            string startDate = dtpStartSales.Value.Date.ToString("yyyy-MM-dd");
            string endDate = dtpEndSales.Value.Date.ToString("yyyy-MM-dd");
            string employeeID = handleCB(checkEmployee, cbEmployeeSales);

            loadDGV(salesQuery(employeeID, startDate, endDate));
        }

        private void checkEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEmployee.Checked)
            {
                cbEmployeeSales.Enabled = false;
            }
            else
            {
                cbEmployeeSales.Enabled = true;
            }
        }

        private void btnFilterPO_Click(object sender, EventArgs e)
        {
            string dateStart = dtpStartPO.Value.Date.ToString("yyyy-MM-dd");
            string dateEnd = dtpEndPO.Value.Date.ToString("yyyy-MM-dd");
            string supplierID = handleCB(checkPO, cbSupplierPO);

            loadDGV(poQuery(supplierID, dateStart, dateEnd, handleStatus(cbStatusPO.Text)));
        }

        private void checkPO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPO.Checked)
            {
                cbSupplierPO.Enabled = false;
            }
            else
            {
                cbSupplierPO.Enabled = true;
            }
        }
    }

}






