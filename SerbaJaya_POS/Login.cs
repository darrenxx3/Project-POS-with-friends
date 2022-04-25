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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MessageBox.Show("NASI BAKAR!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NASI REBUS!");
        }
    }
}
