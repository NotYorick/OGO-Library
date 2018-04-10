using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Library
{
    class Lid
    {

        private String voornaam;
        private String achternaam;
        private int klantnr;
        private ArrayList leenartikelen;
        private double leengeld;
        private double betaaldeBoetes;

        public Lid(String voornaam, String achternaam, int klantNr)
        {
            leenartikelen = new ArrayList();
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.klantnr = klantNr;
        }

        public void BoeteBetalen()
        {
            
        }

     
        public bool ArtikelLenen(Artikel artikel)
        {
            Lening lening = new Lening(artikel);
            leenartikelen.Add(lening);
            return true;
        }

        public bool Inleveren(Lening lening)
        {
            leenartikelen.Remove(lening);
            return true;
        }

        public void SetVoornaam(String voor)
        {
            voornaam = voor;
        }

        public void SetAchternaam(String achter)
        {
            achternaam = achter;
        }

        public double GetKosten()
        {
            return betaaldeBoetes + leengeld;
        }

        public double GetBoete()
        {
            double totaalboetes = 0;
            foreach (Lening len in leenartikelen )
            {
                totaalboetes += len.BerekenBoetes();
            }
            Debug.WriteLine("boete:" + totaalboetes);
            totaalboetes += betaaldeBoetes;
            return totaalboetes;
        }
        
        public double GetLeen()
        {
            foreach (Lening len in leenartikelen)
            {
                leengeld += len.BerekenLeengeld();
            }
            Debug.WriteLine("leen:" + leengeld);
            return leengeld;
        }

        public String GetName()
        {
            return voornaam + achternaam;
        }

        public String GetVoornaam()
        {
            return voornaam;
        }

        public String GetAchternaam()
        {
            return achternaam;
        }

        public List<Lening> GetLeenArtikelen()
        {
            
            List<Lening> lijst = leenartikelen.Cast<Lening>().ToList();
           
            return lijst;
                      
        }
        public int GetKlantNr()
        {
            return klantnr;
        }

    }
}
