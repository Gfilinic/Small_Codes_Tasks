using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financije
{
    public class Racun
    {
        public string IBAN { get; set; }
        public double Stanje { get; set; }

        public double DozvoljeniMinus { get; set; }
        public bool Blokiran { get; set; }

        public Isplata Isplati(Racun racun, double iznos)
        {
            Isplata novaIsplata = new Isplata();
            novaIsplata.Primatelj = racun.IBAN;
            novaIsplata.Platitelj = this.IBAN;
            if (racun.Stanje + racun.DozvoljeniMinus < iznos)
                throw new TransactionFailedException("Insufficent funds");
            else
            {
                novaIsplata.Iznos = iznos;
                racun.Stanje += iznos;
                this.Stanje -= iznos;
                return novaIsplata;
            }
        }
    }
}

   

