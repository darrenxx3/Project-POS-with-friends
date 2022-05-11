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
    public partial class ChangePassword : Form
    {
        string EmployeeID;
        public ChangePassword(string ID)
        {
            InitializeComponent();
            EmployeeID = ID;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(tbCurrent.Text != "" && tbPass.Text != "" && tbCurrent.Text != "")
            {

                var conn = new Connection.Connection_Query();
                conn.OpenConnection();

                try
                {
                    string queryCheck = "Select Password FROM Employee WHERE " +
                        $"EmployeeID = '{EmployeeID}' AND Password = '{tbCurrent.Text}' ";

                    conn.ExecuteQueires(queryCheck);

                    //Cek apakah password sama
                    if(tbPass.Text == tbCurrent.Text)
                    {
                        string queryChange = "UPDATE Employee SET " +
                            $"Password = '{tbCurrent.Text}' " +
                            $"WHERE EmployeeID = '{EmployeeID}' ";

                        conn.ExecuteQueires(queryChange);
                        MessageBox.Show("Ganti Password Berhasil!");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Pastikan password baru yang anda masukan sama.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Password yang ada masukan salah, harap coba lagi.");
                }
            }
            else
            {
                MessageBox.Show("Harap isi semua data terlebih dahulu.");
            }
        }
    }
}
