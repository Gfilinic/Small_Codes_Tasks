using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    public class Knjiga : IPretraga
    {
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public List<IPretraga> Autori { get; set; }

        private string _rezultat = "";

        public Knjiga(string naziv, int godina)
        {
            this.Naziv = naziv;
            this.Godina = godina;
            this.Autori = new List<IPretraga>();
        }

        public void DodajAutora(Autor autor)
        {
            this.Autori.Add(autor);
        }

        public void UkloniAutora(Autor autor)
        {
        }

        public bool Usporedi(string kljucnaRijec)
        {
            if(Naziv.ToLower() == kljucnaRijec)
                return true;
            else
            {
                foreach (var autor in this.Autori)
                {
                    if (autor.Usporedi(kljucnaRijec))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string Ispis()
        {
            _rezultat = ToString() + Environment.NewLine + "Autori: ";     //moguci nacin, bez dodatnih atributa: return (this.ToString() + Environment.NewLine  + "Autori: " + this.Autori.ForEach(x => x.Ispis()));
            foreach (var autor in Autori)
            {
                _rezultat += Environment.NewLine + autor.Ispis() + ", ";
            }
            return _rezultat;
        }

        public override string ToString()
        {
            return String.Format("Naziv: {0} Godina: {1}", Naziv, Godina);
        }
    }
}
