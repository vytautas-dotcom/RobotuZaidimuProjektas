using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas
{
     public delegate void Kurimas();
    class Account
    {
        Kurimas kurimoDelegatas = kv
        public event Kurimas vardasIvestas;

        public string Vardas { get; set; }
        public int Lygis { get; set; }
        public int Suma { get; set; } = 100;
        public Account(string vardas, int lygis)
        {
            if (string.IsNullOrWhiteSpace(vardas))
            {
                throw new Exception("Vardo laukas negali buti tuscias");
            }
           // if (Lygis == null || Lygis < 1 || Lygis > 3)
           // {
           //     throw new Exception("Neivestas arba neteisingai ivestas zaidimo lygis");
           // }
            Vardas = vardas;
            Lygis = lygis;

            MetodasVardasIvestas();
        }
        public virtual void MetodasVardasIvestas()
        {

            vardasIvestas?.Invoke();
        }
        
        
        public void Kvietimas()
        {
            Veiksmas veiksmas = new Veiksmas(5);
            veiksmas.Skaiciavimas(5);
        }

    }
}