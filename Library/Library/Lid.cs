using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

        public Lid()
        {

        }

        public Lid(String voornaam, String achternaam, int klantNr)
        {
            
        }

        public void BoeteBetalen()
        {
            
        }

        public void Reserveren(Artikel artikel)
        {
            
        }

        public bool ArtikelLenen(String artikelnummer)
        {
            return false;
        }

        public bool Inleveren(Lening lening)
        {
            return false;
        }

        public void SetVoornaam()
        {
            
        }

        public void SetAchternaam()
        {
            
        }

        public String GetName()
        {
            return voornaam + achternaam;
        }
    }
}
