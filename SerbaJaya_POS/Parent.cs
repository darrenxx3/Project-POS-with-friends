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
        public string employeeID, employeeRole, employeeName;

        void loadKasir()
        {
            panel1.Controls.Clear();
            Kasir kasir = new Kasir(employeeID);
            //kasir.MdiParent = this;
            kasir.TopLevel = false;
            kasir.AutoScroll = true;
            panel1.Controls.Add(kasir);
            kasir.Show();
        }

        void loadMenu(string role, string name)
        {
            switch (role)
            {
                case "Cashier" :
                    stripKasir.Visible = true;
                    loadKasir();
                    break;
                case "Warehouse":
                    stripGudang.Visible = true;
                    break;
                case "Manager":
                    stripManager.Visible = true;
                    break;
            }

            stripUser.Text = name;
        }

        public Parent(String role, string name, string id)
        {
            InitializeComponent();
            employeeID = id;
            employeeRole = role;
            employeeName = name;
        }

        private void Parent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            loadMenu(employeeRole, employeeName);
        }

        private void userLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Log Out?", "Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }

        private void KasirMenu_Click(object sender, EventArgs e)
        {
            loadKasir();
        }
    }
}
