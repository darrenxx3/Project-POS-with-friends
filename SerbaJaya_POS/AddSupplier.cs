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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            var conn = new Connection.Connection_Query();
            conn.OpenConnection();
            dataGridView1.DataSource = conn.ShowDataInGridVIew("SELECT * FROM Supplier ORDER BY SupplierID");
            conn.CloseConnectoin();
        }
    }
}
