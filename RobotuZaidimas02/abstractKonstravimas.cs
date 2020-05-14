using RobotoDalys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotuZaidimas02
{
    abstract class abstractKonstravimas
    {
        public abstract IDalis pridetiVaziuokle();
        public abstract IDalis pridetiSarvai();
        public abstract IDalis pridetiVariklis();
        public abstract IDalis pridetiIsmaniejiGinklai();
        public abstract IDalis pridetiGinklai();
        public abstract IDalis pridetiValdymas();
    }
}
