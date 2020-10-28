using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjačnicaLib
{
    class TecajnaLista
    {
        List<Tecaj> _tecajnaLista;

        public TecajnaLista()
        {
            InicijalizirajListu();
        }

        public void InicijalizirajListu()
        {
            _tecajnaLista = new List<Tecaj>();
            _tecajnaLista.Add(new Tecaj("EUR", 7.5));
            _tecajnaLista.Add(new Tecaj("USD", 6.7));
            _tecajnaLista.Add(new Tecaj("GBP", 8.5));
            _tecajnaLista.Add(new Tecaj("PLN", 1.7));
        }

        public Tecaj DohvatiValutu(string naziv)
        {
            if (!_tecajnaLista.Exists(x => x.Valuta == naziv))
            {
                Console.WriteLine("Valuta ne postoji");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            
            return _tecajnaLista.First(v => v.Valuta == naziv);
        }

        public void DodajValutu(string naziv, double iznos)
        {
            _tecajnaLista.Add(new Tecaj(naziv, iznos));
        }

        public void IzbrisiValutu(string naziv)
        {
            if (!_tecajnaLista.Exists(x => x.Valuta == naziv))
            {
                Console.WriteLine("Valuta ne postoji");
                Console.ReadKey();
                return;
            }

            Tecaj valutaZaBrisanje = _tecajnaLista.First(t => t.Valuta == naziv);
            _tecajnaLista.Remove(valutaZaBrisanje);
        }
    }
}
