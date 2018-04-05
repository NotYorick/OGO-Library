using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            Main main = new Main();
            tabUser.Click += new System.EventHandler(main.TabUserEvent);
            tabAdmin.Click += new System.EventHandler(main.TabAdminEvent);
            tabAccount.Click += new System.EventHandler(main.TabAccountantEvent);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
