using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotoDalys
{
    public interface IDalis
    {
        string Pavadinimas { get; set; }
        int Gyvybe { get; set; }
        int Kaina { get; set; }
        int Svoris { get; set; }

        void didejaGyvybe();

        void mazejaGyvybe();
    }
}
