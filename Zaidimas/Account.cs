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
        public int Lygis { get; set; }
        public int Suma { get; set; } = 100;
        public Account(string vardas, int lygis)
        {
            Vardas = vardas;
            Lygis = lygis;
        }

    }
}