using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Library
{
    public partial class GUI : Form
    {
        private Main main;
        public GUI()
        {
            InitializeComponent();
            main = new Main();
            UpdateDataset();


            #region EventHandlers
            tabUser.Click += new System.EventHandler(TabUserEvent);
            tabAdmin.Click += new System.EventHandler(TabAdminEvent);
            tabAccount.Click += new System.EventHandler(TabAccountantEvent);
            listBox4.SelectedIndexChanged += new System.EventHandler(listBox4_SelectedIndexChanged);
            listBox1.SelectedIndexChanged += new System.EventHandler(listBox1_SelectedIndexChanged);


            #endregion

        }

        public void UpdateDataset()
        {
            List<Artikel> data = main.GetAllArtikelen();
            listBox4.DisplayMember = "naam";
            listBox4.DataSource = data;

            List<Artikel> data_leen = main.GetLid(1).GetLeenArtikelen();
            listBox1.DisplayMember = "naam";
            listBox1.DataSource = data_leen;
            

        }

        #region Events
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var selectedItem = (Artikel)listBox4.SelectedItem;
            label24.Text = selectedItem.getName();
            label25.Text = selectedItem.GetArtikelNr().ToString();
            label27.Text = selectedItem.GetYear().ToString();
            



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedItem = (Artikel)listBox1.SelectedItem;
            label24.Text = selectedItem.getName();
            label25.Text = selectedItem.GetArtikelNr().ToString();
            label27.Text = selectedItem.GetYear().ToString();




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

        private void GUI_Load_1(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        public void TabUserEvent(object sender, EventArgs e)
        {

        }

        public void TabAdminEvent(object sender, EventArgs e)
        {

        }

        public void TabAccountantEvent(object sender, EventArgs e)
        {

        }


        #endregion

    }
}
