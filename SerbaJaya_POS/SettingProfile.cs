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
    public partial class SettingProfil : Form
    {
        string employeeId;

        void loadProfile()
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            string query = "SELECT EmployeeName, Address, PhoneNumber FROM Employee WHERE" +
                            $" EmployeeID = '{employeeId}' ";

            MessageBox.Show(query);
            try
            {
                var dr = conn.DataReader(query);

                if (dr.Read())
                {
                    tbID.Text = employeeId;
                    tbNama.Text = dr.GetValue(0).ToString();
                    tbTelp.Text = dr.GetValue(2).ToString();
                    tbAlamat.Text = dr.GetValue(1).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public SettingProfil(string employeeID)
        {
            InitializeComponent();
            employeeId = employeeID;
        }

        private void SettingProfil_Load(object sender, EventArgs e)
        {
            loadProfile();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "" && tbAlamat.Text != "" && tbTelp.Text != "")
            {
                var conn = new Connection.Connection_Query();
                conn.OpenConnection();

                string query = "Update Employee " +
                    $"SET EmployeeName = '{tbNama.Text}', " +
                    $"Address = '{tbAlamat.Text}', " +
                    $"PhoneNumber = '{tbTelp.Text}' " +
                    $"WHERE EmployeeID = '{employeeId}' ";

                try
                {
                    conn.ExecuteQueires(query);
                    MessageBox.Show("Data Successfully updated!");
                    loadProfile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update data fail! Please try again later." + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("harap isi semua data terlebih dahulu!");
            }
        }

    }
}
