﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
            
        }

        public void StuurBericht(String klantNr)
        {
            
        }

        public Artikel GetArtikel(int artNr)
        {
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
