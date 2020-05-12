using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotuZaidimas02
{
    class IDalis
    {
        string Pavadinimas { get; set; }
        int Gyvybe { get; set; }
        int Kaina { get; set; }
        int Svoris { get; set; }

        void didejaGyvybe();

        void mazejaGyvybe();
    }
}
