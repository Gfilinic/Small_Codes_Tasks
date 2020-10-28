using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjačnicaLib
{
    class KonverterValuta
    {
        public double Konvertiraj(double iznosZaPromjenu, Tecaj tecaj)
        {
            double promjenjenIznos = iznosZaPromjenu / tecaj.IznosTecaja;

            return promjenjenIznos;
        }
    }
}
