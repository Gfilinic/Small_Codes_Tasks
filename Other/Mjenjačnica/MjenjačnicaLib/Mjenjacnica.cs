using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjačnicaLib
{
    public class Mjenjacnica
    {
        private TecajnaLista tecajnaLista = new TecajnaLista();
        private Potvrda potvrda;
        private KonverterValuta konverterValuta = new KonverterValuta();
        private Tecaj odabranaValuta;

        private Potvrda PromjeniNovac(double iznosZaPromjenu, string odredisnaValuta)
        {
            odabranaValuta = tecajnaLista.DohvatiValutu(odredisnaValuta);
            double konvertiraniIznos = konverterValuta.Konvertiraj(iznosZaPromjenu, odabranaValuta);
            potvrda = new Potvrda(iznosZaPromjenu, odabranaValuta, konvertiraniIznos);

            return potvrda;
        }

        public void IspisPotvrde(double iznos, string valuta)
        {
            potvrda = PromjeniNovac(iznos, valuta);
            double iznosNaknade = potvrda.KonvertiranIznos * (potvrda.Naknada / 100);

            Console.WriteLine("MJENJAČNICA");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Datum: " + potvrda.DatumVrijeme);
            Console.WriteLine("Iznos za promjenu: " + potvrda.IznosZaPromjenu + " HRK");
            Console.WriteLine("Po tečaju: " + potvrda.Valuta.IznosTecaja);
            Console.WriteLine("Iznos: " + potvrda.KonvertiranIznos + " " + potvrda.Valuta.Valuta);
            Console.WriteLine("Naknada: " + potvrda.Naknada + "% (" + iznosNaknade + " " + potvrda.Valuta.Valuta + ")");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Za isplatiti: " + potvrda.IznosZaIsplatu + " " + potvrda.Valuta.Valuta);
        }

        public void DodajValutu(string naziv, double iznos)
        {
            tecajnaLista.DodajValutu(naziv, iznos);
        }

        public void IzbrisiValutu(string naziv)
        {
            tecajnaLista.IzbrisiValutu(naziv);
        }
    }
}
