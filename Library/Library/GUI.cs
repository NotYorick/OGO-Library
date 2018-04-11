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
            listBox2.SelectedIndexChanged += new System.EventHandler(listBox2_SelectedIndexChanged);
            listBox3.SelectedIndexChanged += new System.EventHandler(listBox3_SelectedIndexChanged);



            #endregion

        }

        public void UpdateDataset()
        {
            //Full list
            List<Artikel> data = main.GetAllArtikelen();
            listBox4.DisplayMember = "naam";
            listBox4.DataSource = data;
            listBox3.DataSource = data;

            //Lening per lid
            Lid lid = main.GetLid(0);       
            List<Lening> test = lid.GetLeenArtikelen();

            //leden
            List<Lid> leden = main.GetLeden();
            listBox2.DataSource = leden;

            List<Lening> data_leen = main.GetLid(0).GetLeenArtikelen();
            listBox1.DataSource = data_leen;

            List<Artikel> data_inge = main.GetAllIngeleverdeArtikelen();
            listBox5.DataSource = data_inge;

        }

        #region Events
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var selectedItem = (dynamic)listBox4.SelectedItem;
            label24.Text = selectedItem.getName();
            label25.Text = selectedItem.GetArtikelNr().ToString();
            label27.Text = selectedItem.GetYear().ToString();

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox5.SelectedItem;
            label6.Text = "Naam: " + selectedItem.getName();
            label28.Text = "ID: " + selectedItem.GetArtikelNr().ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedItem = (dynamic)listBox2.SelectedItem;
            label6.Text = "Naam: " + selectedItem.GetName();
            label28.Text = "ID: " + selectedItem.GetKlantNr().ToString();


        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedItem = (dynamic)listBox3.SelectedItem;
            label6.Text = "Naam: " + selectedItem.getName();
            label28.Text = "ID: " + selectedItem.GetArtikelNr().ToString();

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
            if (selectedItem != null)
            {
                if (selectedItem.GetStatus() == "Aanwezig" && main.GetLid(0).GetLeenArtikelen().Count < 6)
                {
                    main.GetLid(0).ArtikelLenen(selectedItem);
                    selectedItem.ChangeStatus();


                    UpdateDataset();
                }
            }
        }
        //inlever button
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox1.SelectedItem;
            if (selectedItem != null)
            {
                if (main.GetLid(0).GetBoete() > 0)
                {
                    //activeer panel boete!!
                    main.GetLid(0).GetBoete();
                    foreach (Lening leen in main.GetLid(0).GetLeenArtikelen())
                    {

                        if (leen.GetArtikel() == selectedItem.GetArtikel())
                        {

                            label20.Text = leen.BerekenBoetes().ToString();
                        }
                    }

                    panel1.Visible = true;
                }
                else
                {
                    main.GetLid(0).Inleveren(selectedItem);
                    foreach (Artikel art in main.GetAllArtikelen())
                    {
                        if (art.GetArtikelNr() == selectedItem.GetArtikel().GetArtikelNr())
                        {
                            main.ArtikelInleveren(art);

                        }

                    }
                }
                UpdateDataset();
            }
            
        }
        //Volgende dag button
        private void button15_Click(object sender, EventArgs e)
        {
            main.NextDay();
            double inkomen = 0;
            double inkomen_leen = 0;
            double inkomen_boete = 0;
            foreach (Lid li in main.GetLeden())
            {


                inkomen += li.GetKosten();
                inkomen_boete += li.GetBetaaldeBoetes();
                inkomen_leen += li.GetLeen();
            }

            label17.Text = inkomen.ToString();
            label16.Text = inkomen_boete.ToString();
            label18.Text = inkomen_leen.ToString();
        
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

        //Voeg Lid toe
        private void button10_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }
        //Voeg Artikel toe
        private void button16_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }
        //LID Wijzigen
        private void button5_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox2.SelectedItem;
            if (selectedItem != null)
            {
                panel3.Visible = true;
                textBox5.Text = selectedItem.GetVoornaam();
                textBox4.Text = selectedItem.GetAchternaam();
            }
        }
        //Artikel Wijzigen
        private void button17_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox3.SelectedItem;
            if (selectedItem != null)
            {
                panel6.Visible = true;
                textBox8.Text = selectedItem.getName();
                textBox2.Text = selectedItem.GetYear().ToString();
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic) listBox4.SelectedItem;
            Artikel curArt = main.GetArtikel(selectedItem.GetArtikelNr());

            Lid lid = main.GetLid(0);
            curArt.AddReserveringen(lid);
        }

        //Wijzig lid uitvoering
        private void button7_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox2.SelectedItem;
            selectedItem.SetVoornaam(textBox5.Text);
            selectedItem.SetAchternaam(textBox4.Text);
            panel3.Visible = false;
        }

        //Wijzig artikel uitvoering
        private void button12_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox3.SelectedItem;
            selectedItem.setName(textBox8.Text);
            selectedItem.SetYear(Int32.Parse(textBox2.Text));
            panel6.Visible = false;
        }

        //Toevoegen lid uitvoering 
        private void button4_Click(object sender, EventArgs e)
        {
            main.LidToevoegen(textBox3.Text, textBox6.Text);
            UpdateDataset();
            panel4.Visible = false;

        }

        //Toevoegen artikelen uitvoering
        private void button11_Click(object sender, EventArgs e)
        {
            main.ArtikelToevoegen(textBox9.Text, Int32.Parse(textBox1.Text) ,textBox7.Text);
            UpdateDataset();
            panel5.Visible = false;
        }

        //Verwijder lid
        private void button6_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox2.SelectedItem;
            main.LidVerwijderen(selectedItem);
            UpdateDataset();
        }

        //Verwijder artikel
        private void button8_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox3.SelectedItem;
            main.ArtikelVerwijderen(selectedItem);
            UpdateDataset();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Betaal Button
        private void button3_Click_1(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox1.SelectedItem;
            main.GetLid(0).BoeteBetalen(selectedItem.GetArtikel());
            main.GetLid(0).Inleveren(selectedItem);
            foreach (Artikel art in main.GetAllArtikelen())
            {
                if (art.GetArtikelNr() == selectedItem.GetArtikel().GetArtikelNr())
                {
                    main.ArtikelInleveren(art);

                }

            }
            panel1.Visible = false;
            UpdateDataset();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)listBox5.SelectedItem;
            if (selectedItem != null)
            {
                main.ArtikelVerwerken(selectedItem);
                UpdateDataset();
            }
            
        }
    }
}
