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
using System.

namespace SerbaJaya_POS
{
    public partial class SettingProfil : Form
    {
        string employeeId;
        public SettingProfil(string employeeID)
        {
            InitializeComponent();
            employeeId = employeeID;
        }

        private void SettingProfil_Load(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();

            string query = "SELECT * FROM Employee WHERE" +
                            $" EmployeeID = '{employeeId.Trim()}' ";

            MessageBox.Show(query);
            try { 
            var dr = conn.DataReader(query);

            if (dr.HasRows)
            {
                MessageBox.Show(dr.GetValue(0).ToString());
            }
            else
            {
                MessageBox.Show("no data");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
