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
using System.Configuration;// untuk mendapatkan koneksi alternatif

namespace SerbaJaya_POS
{
    public partial class ReportMenu : Form
    {
        //gw gak pake connection.cs ga ngerti
        string constring = "Data Source=LAPTOP-ADU8799N\\SQLEXPRESS;Initial Catalog=visprogw10;Integrated Security= True";
        DataSet DS = new DataSet();
        string vquery = "";

        public ReportMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ReportMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASVisprogDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.uASVisprogDataSet.Employee);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext DB = new DataClasses1DataContext();
            var query = (from x in DB.Positions select x).ToList();
            dataGridView1.DataSource = query;
      
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext DB = new DataClasses1DataContext();
            var query = (from x in DB.Employees select x).ToList();
            dataGridView1.DataSource = query;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext DB = new DataClasses1DataContext();
            var query = (from x in DB.DataItems select x).ToList();
            dataGridView1.DataSource = query;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            DataClasses1DataContext DB = new DataClasses1DataContext();
            var query = (from x in DB.Suppliers select x).ToList();
            dataGridView1.DataSource = query;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            DataClasses1DataContext DB = new DataClasses1DataContext();
            var query = (from x in DB.Sales select x).ToList();
            dataGridView1.DataSource = query;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            DataClasses1DataContext DB = new DataClasses1DataContext();
            var query = (from x in DB.PurchaseOrders select x).ToList();
            dataGridView1.DataSource = query;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from Position where PositionName like '%" + textBox1.Text + "%'";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);
            DA.Fill(DS, "posis");
            dataGridView1.DataSource = DS.Tables["posis"];

           
        }
    }


}
        




