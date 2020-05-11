using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstravimasPrisijungimas
{
    class rankinisKonstravimas
    {
        public string Dalis { get; set; }
        public rankinisKonstravimas(string a)
        {
            Dalis = a;
        }
        public string UzklausaString(string b)
        {

            return $"SELECT Gyvybe, Kaina, Svoris from {Dalis} "
            + $"WHERE {Dalis}='{b}' ";

        }

    }

}