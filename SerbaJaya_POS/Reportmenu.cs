using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Sql.Client;
using System.Windows.Forms;

namespace SerbaJaya_POS
{
    public partial class Reportmenu : Form
    {
        public Reportmenu()
        {
            InitializeComponent();
           
        }

        private void Reportmenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaget kannn");
        }
    }
}
