using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoronaAPI;

namespace Korona
{
    public class DržavnaStatistika
    {
        public int UkupanBrojZaraženih { get; set; }
        public int UkupanBrojOporavljenih { get; set; }
        public int UkupanBrojAktivnih { get; set; }
        public int UkupanBrojUmrlih { get; set; }
        public List<DnevniPodatak> lista = new List<DnevniPodatak>();
        
        public DržavnaStatistika(List<string> siroviPodaci)
        {

            foreach (string s in siroviPodaci)
            {
                string[] array = s.Split(';');
                

                lista.Add(new DnevniPodatak()
                {
                    Datum = DateTime.Parse(array[0]),
                    BrojNovoZaraženih = int.Parse(array[1]),
                    BrojOporavljenih = int.Parse(array[2]),
                    BrojUmrlih = int.Parse(array[3])

                });  }
            }

        }
    }
    

