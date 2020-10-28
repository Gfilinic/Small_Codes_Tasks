using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjačnicaLib
{
    public class Potvrda
    {
        public DateTime DatumVrijeme { get; set; }
        public double IznosZaPromjenu { get; set; }
        public Tecaj Valuta { get; set; }
        public double KonvertiranIznos { get; set; }

        public double Naknada = 5;

        public double IznosZaIsplatu { get; set; }

        public Potvrda(double iznos, Tecaj tecaj, double konvertiranIznos)
        {
            this.DatumVrijeme = DateTime.Now;
            this.IznosZaPromjenu = iznos;
            this.Valuta = tecaj;
            this.KonvertiranIznos = konvertiranIznos;
            this.IznosZaIsplatu = KonvertiranIznos * ((100 - Naknada) / 100);
        }

    }
}
