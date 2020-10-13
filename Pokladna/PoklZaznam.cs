using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna
{
    public class PoklZaznam
    {
        public PoklZaznam(int idPoklZaznam, int cisloDokladu, DateTime datum, string popisZaznamu, double castka, double zustatek, string poznamka)
        {
            IdPoklZaznam = idPoklZaznam;
            CisloDokladu = cisloDokladu;
            Datum = datum;
            PopisZaznamu = popisZaznamu;
            Castka = castka;
            Zustatek = zustatek;
            Poznamka = poznamka;
        }
        public PoklZaznam() 
        {
            
        }

        public int IdPoklZaznam { get; set; }
        public int CisloDokladu { get; set; }
        public DateTime Datum { get; set; }
        public string PopisZaznamu { get; set; }
        public double Castka { get; set; }
        public double Zustatek { get; set; }
        public string Poznamka { get; set; }    
    }
}
