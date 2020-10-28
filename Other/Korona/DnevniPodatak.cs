using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korona
{
    public class DnevniPodatak
    {
        

        public DnevniPodatak()
        {
            
        }

        public DateTime Datum { get; set; }
        public int BrojNovoZaraženih { get; set; }
        public int BrojOporavljenih { get; set; }
        public int BrojUmrlih { get; set; }
       
    }
}
