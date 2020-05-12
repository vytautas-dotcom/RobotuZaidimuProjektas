using RobotuZaidimas02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstravimasPrisijungimas
{
    enum Dalys
    {
        Vaziuokle = 1,
        Sarvai,
        Variklis,
        ismaniejiGinklai,
        Ginklai,
        Valdymas
    }
    class rankinisKonstravimas
    {
        public string Dalis { get; set; }
        public rankinisKonstravimas(string a)
        {
            Dalis = a;
        }
        public string UzklausaString(string b)
        {

            return $"SELECT Id, {Dalis}, Kaina from {Dalis} "
            + $"WHERE {Dalis}='{b}' ";

        }
        public void RankinisIsrinkimas()
        {
            for (int i = 1; i <= 6; i++)
            {
                
                Console.WriteLine();
            }
        }
    }

}