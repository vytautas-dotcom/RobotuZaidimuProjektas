using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotoDalys;

namespace Robotai
{
    abstract class Robotas
    {
        public string Vardas { get; set; }
        public IDalis Vaziuokle { get; set; }
        public IDalis Sarvai { get; set; }
        public IDalis Ginklai { get; set; }
        public IDalis ismaniejiGinklai { get; set; }
        public IDalis Variklis { get; set; }
        public IDalis Valdymas { get; set; }
        public abstract int Ataka();
        public abstract int Gyvybe();
        public abstract void Konstravimas();
    }
}
