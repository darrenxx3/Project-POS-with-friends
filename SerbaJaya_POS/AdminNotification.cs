using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace SerbaJaya_POS
{
    public partial class AdminNotification : Form
    {
        public string PATH = "..\\..\\notification.txt";

        string notificationFormat(string message)
        {
            string msg =
                $"{DateTime.Now.ToString("dd/MM/yyyy H:mm")} " +
                Environment.NewLine +
                "-------------------" +
                Environment.NewLine +
                $"{message}";

            return msg;
        }

        public AdminNotification()
        {
            InitializeComponent();
        }

        void refreshPage()
        {
            string txtString = File.ReadAllText(PATH);
            tbMessage.Text = txtString;
        }

        private void AdminNotification_Load(object sender, EventArgs e)
        {
            refreshPage();   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            File.WriteAllText(PATH, "");
            refreshPage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string template = "";
            if (tbMessage.Text != "")
            {
                template = notificationFormat(tbMessage.Text);
            }

            File.WriteAllText(PATH, template);
            MessageBox.Show("Notification successfully Updated!");
            refreshPage();
        }
    }
}
