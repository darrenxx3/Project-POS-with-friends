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
        Dictionary<string, string> position = new Dictionary<string, string>();

        void handleQuery(string targetQuery, string add)
        {
            if(targetQuery != "")
            {
                targetQuery += $"AND {add}";
            }
            else
            {
                targetQuery += add;
            }
        }

        void openReport(string formula, string namaReport)
        {
            LoadReport report = new LoadReport(formula, namaReport);
            report.Show();
        }

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
                $"(E.PositionID IS NULL OR E.PositionID LIKE '%{role}%')";

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

        string[] handleAllDate(CheckBox inputCb, string dateStart, string dateEnd)
        {
            if (inputCb.Checked) return null;

            string[] date = { dateStart, dateEnd };

            return date;
        }

        string handleDate(string[] dateArr, string columnName)
        {
            if (dateArr != null)
            {
                return $"AND (cast({columnName} AS DATE) >= '{dateArr[0]}' AND " +
                    $"cast({columnName} AS DATE) <= '{dateArr[1]}') ";
            }

            return null;
        }

        string salesQuery(
            string employeeID = null,
            string[] date = null
        )
        {
            string query = "SELECT * FROM Sales WHERE " +
                $"(EmployeeID IS NULL OR EmployeeID LIKE '%{employeeID}%' ) ";

            query += handleDate(date, "TransactionDate");

            return query;
            //
        }

        string poQuery(
            string supplierID = null,
             string[] date = null,
            string status = null
        )
        {
            string query = "SELECT PurchaseOrderID, S.SupplierName, OrderDate, E.EmployeeName FROM purchaseOrder P " +
                   $"INNER JOIN Supplier S ON S.SupplierID = P.SupplierID " +
                   $"INNER JOIN Employee E ON E.EmployeeID = P.EmployeeID " +
                   $"WHERE (P.SupplierID IS NULL OR P.SupplierID LIKE '%{supplierID}%' ) AND " +
                   $"(IsDone IS NULL OR IsDone LIKE '%{status}%' )";

            query += handleDate(date, "OrderDate");

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

            string queryPosition = "SELECT * FROM Position WHERE NOT PositionName LIKE 'Manager'  ";
            loadCB(queryPosition, cbPosition, position);
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

            string position = handleCB(checkPosition, cbPosition);
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

            string[] date = handleAllDate(checkDateSales, startDate, endDate);
            string employeeID = handleCB(checkEmployee, cbEmployeeSales);

            loadDGV(salesQuery(employeeID, date));
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

            string[] date = handleAllDate(checkPODate, dateStart, dateEnd);

            loadDGV(poQuery(supplierID, date , handleStatus(cbStatusPO.Text)));
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

        private void btnReportEmployee_Click(object sender, EventArgs e)
        {
            string position = handleCB(checkPosition, cbPosition);
            string status = handleStatus(cbStatusEmployee.Text);

            string query = ""; 
            if (position != null) handleQuery(query, " {Employee.PositionID} = '" + position + "'");
            if (status != null) handleQuery(query, " AND {Employee.IsNotEmployee}  = '" + status + "' ");

            openReport(query, "employee");
        }

        private void btnReportItem_Click(object sender, EventArgs e)
        {
            string status = handleStatus(cbStatusItem.Text);

            string query = "";

            if (status != null) query += " {DataItem.IsDiscontinued}= '" + status + "' ";
            openReport(query, "item");
        }

        private void btnReportSales_Click(object sender, EventArgs e)
        {
            string startDate = dtpStartSales.Value.Date.ToString();
            string endDate = dtpEndSales.Value.Date.ToString();
            string employeeID = handleCB(checkEmployee, cbEmployeeSales);

            string[] date = handleAllDate(checkDateSales, startDate, endDate);

            string query = "";

            if (date != null) handleQuery(query, "{ Sales.TransactionDate} >= CDate('" + date[0] + "') AND " +
                "{Sales.TransactionDate} <= CDate('" + date[1] + "') ");
            if (employeeID != null) handleQuery(query ,"{Sales.EmployeeID} = '" + employeeID + "' ");

            openReport(query, "sales");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPosition.Checked)
            {
                cbPosition.Enabled = false;
            }
            else
            {
                cbPosition.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPODate.Checked)
            {
                dtpEndPO.Enabled = false;
                dtpStartPO.Enabled = false;
            }
            else
            {
                dtpEndPO.Enabled = true;
                dtpStartPO.Enabled = true;
            }
        }

        private void btnReportPO_Click(object sender, EventArgs e)
        {
            string startDate = dtpStartPO.Value.Date.ToString();
            string endDate = dtpEndPO.Value.Date.ToString();
            string supplierID = handleCB(checkPO, cbSupplierPO);
            string status = handleStatus(cbStatusPO.Text);

            string[] date = handleAllDate(checkPODate, startDate, endDate);

            string query = "";

            if (date != null) handleQuery(query ,"{ PurchaseOrder.OrderDate} >= CDate('" + date[0] + "') AND " +
                "{PurchaseOrder.OrderDate} <= CDate('" + date[1] + "') ");
            if (supplierID != null) handleQuery(query ,"{PurchaseOrder.SupplierID} = '" + supplierID + "'");
            if (status != null) handleQuery(query ,"{ PurchaseOrder.IsDone } = '" + status + "' ");

            openReport(query, "purchaseOrder");
        }

        private void cbDateSales_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDateSales.Checked)
            {
                dtpEndSales.Enabled = false;
                dtpStartSales.Enabled = false;
            }
            else
            {
                dtpEndSales.Enabled = true;
                dtpStartSales.Enabled = true;
            }
        }
    }

}






