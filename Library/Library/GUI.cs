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
            //Full list
            List<Artikel> data = main.GetAllArtikelen();
            listBox4.DisplayMember = "naam";
            listBox4.DataSource = data;

            //Lening
            Lid lid = main.GetLid(0);       
            List<Lening> test = lid.GetLeenArtikelen();
            int counter = test.Count;
            
            List<Lening> data_leen = main.GetLid(0).GetLeenArtikelen();
            listBox1.DataSource = data_leen;
            
            
            

        }

        #region Events
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var selectedItem = (dynamic)listBox4.SelectedItem;
            label24.Text = selectedItem.getName();
            label25.Text = selectedItem.GetArtikelNr().ToString();
            label27.Text = selectedItem.GetYear().ToString();
            



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedItem = (dynamic)listBox1.SelectedItem;
            label24.Text = selectedItem.GetArtikel().getName();
            label25.Text = selectedItem.GetArtikel().GetArtikelNr().ToString();
            label27.Text = selectedItem.GetArtikel().GetYear().ToString();
        }

        //Leen Button
        private void button13_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox4.SelectedItem;
            if (selectedItem.GetStatus() == "Aanwezig")
            {
                main.GetLid(0).ArtikelLenen(selectedItem);
                selectedItem.ChangeStatus();
                

                UpdateDataset();
            }
            
        }
        //inlever button
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox1.SelectedItem;
            if (main.GetLid(0).GetBoete() > 0)
            {
                //activeer panel boete!!
                label20.Text = main.GetLid(0).GetBoete().ToString();
                panel1.Visible = true;
            }
            else
            {
                main.GetLid(0).Inleveren(selectedItem);
            }
            UpdateDataset();
        }
        //Volgende dag button
        private void button15_Click(object sender, EventArgs e)
        {
            main.NextDay();
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

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
