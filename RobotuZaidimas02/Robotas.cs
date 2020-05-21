using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotoDalys;
using RobotuZaidimas02;

namespace Robotai
{
    abstract class Robotas
    {
        public string Vardas { get; set; }
        public abstract int Ataka();
        public abstract int Gyvybe();
        public abstract void Konstravimas();
        
    }
}
