using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotoDalys
{
    public class Sarvai : IDalis
    {
        public string Pavadinimas { get; set; }
        public int Gyvybe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Kaina { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Svoris { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void setSarvai(string a)
        {
            Pavadinimas = a;
        }
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
