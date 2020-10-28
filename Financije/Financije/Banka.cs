using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Financije
{
    public class Banka
    {
        private List<Racun> Racuni { get; set; }

        public Banka()
        {
            Racuni = new List<Racun>();

            Racuni.Add(new Racun { IBAN = "HR11", Stanje = 100000, Blokiran = false });
            Racuni.Add(new Racun { IBAN = "HR22", Stanje = 50000, Blokiran = false });
            Racuni.Add(new Racun { IBAN = "HR33", Stanje = 12000, Blokiran = false });
            Racuni.Add(new Racun { IBAN = "HR44", Stanje = 36000, Blokiran = true });
            Racuni.Add(new Racun { IBAN = "HR55", Stanje = 8000, Blokiran = false });
            Racuni.Add(new Racun { IBAN = "HR66", Stanje = 2000, Blokiran = false , DozvoljeniMinus = 3000});
        }

        public Racun DohvatiRacun (string iban)
        {
            Racun trazeniRacun = null; ;
            foreach (Racun racun in Racuni)
            {
                if (racun.IBAN == iban)
                {
                    if (racun.Blokiran) throw new BankException("Račun je blokiran!");
                    trazeniRacun = racun;
                }
            }
            if (trazeniRacun == null) throw new TransactionFailedException("Unknown racun");
            return trazeniRacun;
        }
    }

    [Serializable]
    internal class BankException : ApplicationException
    {
        public BankException()
        {
        }

        public BankException(string message) : base(message)
        {
            DodatnaPoruka = message;
        }
        public string DodatnaPoruka { get; set; }

        public BankException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BankException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class TransactionFailedException : ApplicationException
    {
        public TransactionFailedException()
        {
        }

        public TransactionFailedException(string message) : base(message)
        {
            DodatnaPoruka = message;
        }
        public string DodatnaPoruka { get; set; }

        public TransactionFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TransactionFailedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}
    

