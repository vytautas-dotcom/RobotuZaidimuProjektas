using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas
{
    class Account
    {
        public string Vardas { get; set; }
        public int? Lygis { get; set; }
        public int Suma { get; set; } = 5000;
        public Account(string vardas, int lygis)
        {
            if (string.IsNullOrWhiteSpace(vardas))
	{
                 throw new Exception("Vardo laukas negali buti tuscias");
	}
           if (Lygis == null || Lygis < 1 || Lygis > 3)
	{
                throw new Exception("Neivestas arba neteisingai ivestas zaidimo lygis");
	}
            Vardas = vardas;
            Lygis = lygis;
        }
        
    }
}