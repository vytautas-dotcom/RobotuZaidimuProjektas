using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotoDalys
{
    public class Vaziuokle : IDalis
    {
        public string Pavadinimas { get; set; }
        public int Gyvybe { get; set; }
        public int Kaina { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Svoris { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void setPavadinimas(string a)
        {
            Pavadinimas = a;
        }
        public void getVaziuokle()
        {
            Console.WriteLine(Pavadinimas);
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
