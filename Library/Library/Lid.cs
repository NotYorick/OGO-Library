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
        private double boetes;

        public Lid(String voornaam, String achternaam, int klantNr)
        {
            leenartikelen = new ArrayList();
        }

        public void BoeteBetalen()
        {
            
        }

        public void Reserveren(Artikel artikel)
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

        public void SetVoornaam()
        {
            
        }

        public void SetAchternaam()
        {
            
        }

        public double GetKosten()
        {
            return boetes + leengeld;
        }

        public double GetBoete()
        {
            foreach (Lening len in leenartikelen )
            {
                boetes += len.BerekenBoetes();
            }
            Debug.WriteLine("boete:" + boetes);
            return boetes;
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
