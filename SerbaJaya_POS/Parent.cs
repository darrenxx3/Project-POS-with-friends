﻿using System;
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

        void loadForm(Form _form)
        {
            panel1.Controls.Clear();
            _form.TopLevel = false;
            _form.AutoScroll = true;
            panel1.Controls.Add(_form);
            _form.Show();
        }

        void loadMenu(string role, string name)
        {
            switch (role)
            {
                case "Cashier" :
                    stripKasir.Visible = true;
                    loadForm(new Kasir(employeeID));
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

        private void userProfile_Click(object sender, EventArgs e)
        {
            loadForm(new SettingProfil(employeeID));
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new ChangePassword(employeeID));
        }

        private void menuSupplier_Click(object sender, EventArgs e)
        {
            loadForm(new AdminSupplier());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new AdminItem());
        }

        private void inventoryList_Click(object sender, EventArgs e)
        {
            loadForm(new Inventory());
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
            loadForm(new Kasir(employeeID));
        }
    }
}
