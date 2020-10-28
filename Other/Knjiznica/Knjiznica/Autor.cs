using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    public class Autor : IPretraga
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Autor(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public bool Usporedi(string kljucnaRijec)
        {
            if (kljucnaRijec == Ime || kljucnaRijec == Prezime)
                return true;
            else
                return false;
        }

        public string Ispis()
        {
            return ToString();
        }

        public override string ToString()
        {
            return String.Format("Ime: {0}  Prezime: {1}", Ime, Prezime);
        }
    }
}
