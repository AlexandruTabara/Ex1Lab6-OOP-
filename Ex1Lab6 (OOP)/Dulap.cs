using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Lab6__OOP_
{
    public class Dulap
    {
        private int lungime;
        private int latime;
        private int inaltime;


        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }

        public int CalculeazaVolum()
        {
            return lungime * latime * inaltime;
        }
    }
}


