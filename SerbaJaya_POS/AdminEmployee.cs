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
    public partial class AdminEmployee : Form
    {

        Dictionary<string, string> position = new Dictionary<string, string>();

        string idIncrement()
        {
            var conn = new Connection.Connection_Query();
            string query =
                "SELECT TOP 1 * FROM Employee ORDER BY EmployeeID DESC";

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

            int digit = 4;
            int increment = temp + 1;

            var id = $"E{increment.ToString().PadLeft(digit, '0')}";

            return id;
        }

        void insertData()
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                conn.OpenConnection();
                string positionID = ((KeyValuePair<string, string>)cbPosition.SelectedItem).Key;

                string query = "INSERT INTO Employee " +
                "(EmployeeID, EmployeeName, PositionID, Address, PhoneNumber, Password, IsNotEmployee)" +
                $"VALUES('{tbID.Text}', '{tbName.Text}', '{positionID}' ,'{tbAddress.Text}', '{tbPhone.Text}', '123' , 'false')";


                conn.ExecuteQueires(query);

                MessageBox.Show("Data Successfully Inserted");
                refreshForm();

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

        void updateData()
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                string positionID = ((KeyValuePair<string, string>)cbPosition.SelectedItem).Key;

                string query = "UPDATE Employee " +
                    $"SET EmployeeName = '{tbName.Text}', " +
                    $"PositionID = '{positionID}', " +
                    $"Address = '{tbAddress.Text}', " +
                    $"PhoneNumber = '{tbPhone.Text}' " +
                    $"WHERE EmployeeID = '{tbID.Text}' ";

                conn.ExecuteQueires(query);
                MessageBox.Show("Data Berhasil di update!");
                refreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void handleStatus(string status, string ID)
        {

            var conn = new Connection.Connection_Query();

            conn.OpenConnection();
            try
            {
                string queryUpdtDisc = $"Update Employee SET IsNotEmployee = '{status}' WHERE EmployeeID = '{ID}' ";
                conn.ExecuteQueires(queryUpdtDisc);
                MessageBox.Show("status berhasil diperbarui!");

                refreshForm();
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

        void deleteData(String supplierID)
        {
            DialogResult result = MessageBox.Show("Hapus Supplier?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var conn = new Connection.Connection_Query();
                conn.OpenConnection();

                try
                {
                    string query = $"DELETE FROM Employee WHERE EmployeeID = '{supplierID}' ";

                    conn.ExecuteQueires(query);
                    MessageBox.Show("Employee berhasil dihapus!");
                    refreshForm();
                }
                catch (Exception ex)
                {
                    conn.CloseConnectoin();
                    DialogResult confirmDisc = MessageBox.Show("Data tidak dapat dihapus karena terikat dengan data lain,  Ingin non-aktifkan barang?",
                   "Confirmation", MessageBoxButtons.YesNo);
                    if (confirmDisc == DialogResult.Yes)
                    {
                        handleStatus("true", supplierID);
                    }
                }
            }
        }


        void loadPosition()
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                string query = "SELECT * FROM Position WHERE NOT PositionName LIKE 'Manager'  ";
                var dr = conn.DataReader(query);

                while (dr.Read())
                {
                    string id = dr.GetValue(0).ToString();
                    string name = dr.GetValue(1).ToString();

                    position.Add(id, name);
                }

                cbPosition.DataSource = new BindingSource(position, null);
                cbPosition.DisplayMember = "Value";
                cbPosition.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("error to load position: " + ex.ToString());
            }
            finally
            {
                conn.CloseConnectoin();
            }
        }

        string selectString = "EmployeeID, EmployeeName, P.PositionName, Address, PhoneNumber";
        void loadData(string filter = null)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                string query = $"SELECT {selectString} FROM Employee E " +
                    $"INNER JOIN Position P ON P.PositionID = E.PositionID " +
                    $" WHERE (( EmployeeID IS NULL OR EmployeeID LIKE '%{filter}%' ) OR " +
                    $"( EmployeeName IS NULL or EmployeeName LIKE '%{filter}%' ) OR " +
                    $"( P.PositionName IS NULL or P.PositionName LIKE '%{filter}%' ) OR " +
                    $"( PhoneNumber IS NULL or PhoneNumber LIKE '%{filter}%' ) OR " +
                    $"( Address IS NULL or Address LIKE '%{filter}%' )) AND " +
                    $"IsNotEmployee = 'false' ";

                dgvEmployee.DataSource = conn.ShowDataInGridView(query);
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

        void loadDataPast(string filter = null)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            try
            {
                string query = $"SELECT {selectString} FROM Employee E " +
                    $"INNER JOIN Position P ON P.PositionID = E.PositionID " +
                    $" WHERE (( EmployeeID IS NULL OR EmployeeID LIKE '%{filter}%' ) OR " +
                    $"( EmployeeName IS NULL or EmployeeName LIKE '%{filter}%' ) OR " +
                    $"( P.PositionName IS NULL or P.PositionName LIKE '%{filter}%' ) OR " +
                    $"( PhoneNumber IS NULL or PhoneNumber LIKE '%{filter}%' ) OR " +
                    $"( Address IS NULL or Address LIKE '%{filter}%' )) AND " +
                    $"IsNotEmployee = 'true' ";

                dgvEmployeePast.DataSource = conn.ShowDataInGridView(query);
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
            if (tbName.Text != "" && tbAddress.Text != "" && tbPhone.Text != "" &&
                cbPosition.Text != "")
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
            tbName.Clear();
            tbAddress.Clear();
            tbPhone.Clear();
        }

        //handle Button
        void handleButtonUpdate(bool status)
        {
            if (status == true)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnCancel.Enabled = true;
                btnReset.Enabled = true;

            }
            else
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnCancel.Enabled = false;
                btnReset.Enabled = false;

            }
        }

        //handle load form
        void refreshForm()
        {
            clearForm();
            tbID.Text = idIncrement();
            handleButtonUpdate(false);
            loadData();
            loadDataPast();
        }

        public AdminEmployee()
        {
            InitializeComponent();
        }

        private void AdminEmployee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            loadPosition();
            refreshForm();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            loadData(tbFilter.Text);
            loadDataPast(tbFilter.Text);
        }

        private void dgvEmployeePast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var currentColumn = senderGrid.Columns[e.ColumnIndex];

            if (currentColumn is DataGridViewButtonColumn &&
               e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployeePast.Rows[e.RowIndex];
                string id = row.Cells[1].Value.ToString();

                handleStatus("false", id);
                refreshForm();

            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var currentColumn = senderGrid.Columns[e.ColumnIndex];

            if (currentColumn is DataGridViewButtonColumn &&
               e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];

                string id = row.Cells[2].Value.ToString();
                string nama = row.Cells[3].Value.ToString();
                string position = row.Cells[4].Value.ToString();
                string alamat = row.Cells[5].Value.ToString();
                string phone = row.Cells[6].Value.ToString();

                if (currentColumn.HeaderText == "Delete")
                {
                    deleteData(id);
                }
                else if (currentColumn.HeaderText == "Edit")
                {

                    tbID.Text = id;
                    tbName.Text = nama;
                    cbPosition.SelectedIndex = cbPosition.FindStringExact(position);
                    tbAddress.Text = alamat;
                    tbPhone.Text = phone;
                    handleButtonUpdate(true);

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(checkFormEmpty() == false)
            {
                insertData();
            }
            else
            {
                MessageBox.Show("Harap isi semua data terlebih dahulu.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkFormEmpty() == false)
            {
                updateData();
            }
            else
            {
                MessageBox.Show("Harap isi semua data terlebih dahulu.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();

            string queryReset = $"UPDATE Employee SET Password = '123' " +
                $"WHERE EmployeeID = '{tbID.Text}' ";

            conn.OpenConnection();
            try
            {
                conn.ExecuteQueires(queryReset);
                MessageBox.Show("Password berhasil di reset");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan ketika reset password: "+ex.ToString());
            }
            finally
            {
                conn.CloseConnectoin();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            handleButtonUpdate(false);
        }
    }
}
