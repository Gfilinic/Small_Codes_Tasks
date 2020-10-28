using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjačnicaLib
{
    public class Tecaj
    {
        public string Valuta { get; private set; }
        public double IznosTecaja { get; private set; }

        public Tecaj(string naziv, double iznos)
        {
            this.Valuta = naziv;
            this.IznosTecaja = iznos;
        }


    }
}
