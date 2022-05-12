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
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            dataGridView1.DataSource = conn.ShowDataInGridView("SELECT * FROM DataItem ORDER BY ItemID");
            conn.CloseConnectoin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert data kedalam database, apabila berhasil tampilkan pesan Data Berhasil Diinput , jika tidak tampilkan Data Gagal Diinput.
            /*
            var conn = new Connection.Connection_Query();
            SqlCommand insert = new SqlCommand("INSERT INTO DataItem (ItemID, ItemName, Cost, SalesPrice, Stock, Descriptions) VALUES (@ItemID, @ItemName, @Cost, @SalesPrice, @Stock, @Descriptions)", conn);
            insert.Parameters.AddWithValue("@ItemID", textBoxItemID.Text);
            insert.Parameters.AddWithValue("@ItemName", textBoxItemName.Text);
            insert.Parameters.AddWithValue("@Cost", textBoxCost.Text);
            insert.Parameters.AddWithValue("@SalesPrice", textBoxSales.Text);
            insert.Parameters.AddWithValue("@Stock", textBoxStock.Text);
            insert.Parameters.AddWithValue("@Descriptions", richTextBox1.Text);
            try
            {
                conn.OpenConnection();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data inputted successfully");
            }
            catch
            {
                MessageBox.Show("Data gagal diinput");
            }
            finally
            {
                conn.CloseConnectoin();
            }
            */
        }
    }
}
