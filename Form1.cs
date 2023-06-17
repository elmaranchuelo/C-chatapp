using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppUbt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server ServerForm = new Server();
            ServerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client ClientForm = new Client();
            ClientForm.Show();
        }
    }
}
