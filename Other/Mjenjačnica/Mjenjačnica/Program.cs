using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MjenjačnicaLib;

namespace Mjenjačnica
{
    class Program
    {
       static Mjenjacnica mjenjacnica = new Mjenjacnica();

        static void Main(string[] args)
        {
            int izbor;
            do
            {
                Console.WriteLine("MJENJAČNICA");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("[1] Promjeni novac");
                Console.WriteLine("[2] Dodaj novu valutu");
                Console.WriteLine("[3] Izbriši postojeću valutu");
                Console.WriteLine("[0] Izlaz");
                Console.WriteLine("-----------------------------------");
                
                izbor = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (izbor)
                {
                    case 1:
                        PromjeniNovac();
                        break;
                    case 2:
                        DodajValutu();
                        break;
                    case 3:
                        IzbrisiValutu();
                        break;
                }
            } while (izbor != 0);

            Console.ReadKey();
        }

        static public void PromjeniNovac()
        {
            Console.WriteLine("Unesite iznos u HRK koji želite promjeniti:");
            double iznos = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite u koju valutu želite promjeniti novac:");
            string naziv = Console.ReadLine();

            Console.Clear();

            mjenjacnica.IspisPotvrde(iznos, naziv);

            Console.ReadKey();
            Console.Clear();
        }

        static public void DodajValutu()
        {
            Console.WriteLine("Unesite naziv valute:");
            string naziv = Console.ReadLine();
            Console.WriteLine("Unesite tečaj valute:");
            double tecaj = double.Parse(Console.ReadLine());

            mjenjacnica.DodajValutu(naziv, tecaj);

            Console.Clear();
        }

        static public void IzbrisiValutu()
        {
            Console.WriteLine("Unesite naziv valute koju želite izbrisati:");
            string naziv = Console.ReadLine();

            mjenjacnica.IzbrisiValutu(naziv);

            Console.Clear();
        }
    }
}
