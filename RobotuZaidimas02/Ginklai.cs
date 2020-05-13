using RobotoDalys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotuZaidimas02
{
    class Ginklai : IDalis
    {
        public string Pavadinimas { get; set; }
        public int Gyvybe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Kaina { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Svoris { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void didejaGyvybe()
        {
            throw new NotImplementedException();
        }

        public void mazejaGyvybe()
        {
            throw new NotImplementedException();
        }
    }
}
