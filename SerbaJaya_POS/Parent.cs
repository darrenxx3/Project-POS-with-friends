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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
        }

        private void Parent_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }
    }
}
