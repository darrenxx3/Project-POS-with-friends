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
                $"{message}" +
                Environment.NewLine;

            return msg;
        }
        
        public AdminNotification()
        {
            InitializeComponent();
        }

        static string Baca()
        {
            FileStream fs = new FileStream("..\\..\\notification.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            return (sr.ReadToEnd());
            sr.Close();
            fs.Close();
        }

        static void Tulis(string kata)
        {
            FileStream fs = new FileStream("..\\..\\notification.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(kata);
            sw.Close();
            fs.Close();
        }

        private void AdminNotification_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Baca();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            File.WriteAllText(PATH, "");
            tbMessage.Text = Baca();
            richTextBox1.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            string message = notificationFormat(tbMessage.Text);
            Tulis(message);
            richTextBox1.Text = Baca();
            MessageBox.Show("Notification successfully Updated!");
            tbMessage.Text = "";
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
