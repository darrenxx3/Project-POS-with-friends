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
    public partial class notification : Form
    {
        public string PATH = "..\\..\\notification.txt";


        public notification()
        {
            InitializeComponent();
        }

        private void notification_Load(object sender, EventArgs e)
        {
            string txtString = File.ReadAllText(PATH);
            tbNotif.Text = txtString;
        }
    }
}
