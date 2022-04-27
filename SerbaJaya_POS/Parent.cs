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
        void loadMenu(String role, string name)
        {
            switch (role)
            {
                case "Cashier" :
                    stripKasir.Visible = true;
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

        public Parent(String role, string name)
        {
            InitializeComponent();
            loadMenu(role, name);
        }

        private void Parent_Load(object sender, EventArgs e)
        {

        }
    }
}
