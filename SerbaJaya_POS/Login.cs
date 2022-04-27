using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using static Connection.Connection_Query;

namespace SerbaJaya_POS
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();

        }


        private void Login_Load(object sender, EventArgs e)
        {


            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            var conn = new Connection.Connection_Query();

            try
            {
                conn.OpenConnection();

                string query =
                    "SELECT p.PositionName , e.EmployeeName FROM Employee e " +
                    "INNER JOIN Position p ON p.PositionID = e.PositionID " +
                    "WHERE e.EmployeeID ='" + tbUsername.Text + "' AND " +
                    "e.Password ='" + tbPassword.Text + "'";

                SqlDataReader dr = conn.DataReader(query);

                if (dr.Read())
                {
                    this.Hide();
                    Parent parent = new Parent(dr.GetString(0), dr.GetString(1));
                    parent.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username/password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Database Error! Please kindly report to officer: " + ex);
            }

        }
    }
}
