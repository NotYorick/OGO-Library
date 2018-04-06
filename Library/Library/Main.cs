using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Library
{
    class Main
    {

        private ArrayList leden;
        private ArrayList artikelen;
        private ArrayList ingeleverdeArtikelen;

        public Main()
        {
            leden = new ArrayList();
            artikelen = new ArrayList();
            ingeleverdeArtikelen = new ArrayList();

            leden.Add(new Lid("HENK", "Sts", 0));
            leden.Add(new Lid("Daan", "Smits", 1));
            leden.Add(new Lid("Daan", "Ss", 2));

            artikelen.Add(new Roman("Harry potter",1,2003));
            artikelen.Add(new Roman("Cool", 2, 2012));
            artikelen.Add(new Roman("Daan3", 3, 2000));
            artikelen.Add(new Roman("Daan5", 4, 2001));
            artikelen.Add(new Studieboek("Daan5", 5, 1993));
            artikelen.Add(new Populair("Daan5", 5, 1998));
            artikelen.Add(new Klasiek("Daan5", 6, 1999));


        }

        public void ArtikelVerwerken(int artNr)
        {
            
        }

        public void ArtikelVerwijderen(Artikel artikel)
        {
            
        }

        public void ArtikelToevoegen(Artikel artikel)
        {
            
        }

        public void LidToevoegen(Lid lid)
        {
            
        }

        public void LidVerwijderen(Lid lid)
        {
            
        }

        public double GetBoetes()
        {
            return 0;
        }

        public double GetLeengeld()
        {
            return 0;

        }

        public double GetTotaleInkomsten()
        {
            return 0;
        }

        public void NextDay()
        {
            foreach (Lid lid in leden)
            {
                List<Lening> temp =  lid.GetLeenArtikelen();
                foreach (Lening len in temp)
                {
                    len.IncrementDagen();
                }
                lid.GetBoete();
            }
        }

        public void StuurBericht(String klantNr)
        {
            
        }

        public Artikel GetArtikel(int artNr)
        {
            return null;
        }

        public Lid GetLid(int lidNr)
        {
            foreach (Lid lid in leden)
                    {
                        if (lid.GetKlantNr() == lidNr)
                        {
                            
                            return lid;
                        }
                    }
            return null;
        } 

        public List<Artikel> GetAllArtikelen()
        {
           
            List<Artikel> lijst = artikelen.Cast<Artikel>().ToList();
         
            return lijst;
        }

        public void ArtikelInleveren()
        {
            
        }

        

    }
}
