using KonstravimasPrisijungimas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotai
{
    class BotRobot : Robotas
    {
        public override int Ataka()
        {
            throw new NotImplementedException();
        }

        public override int Gyvybe()
        {
            throw new NotImplementedException();
        }

        public override void Konstravimas()
        {
            randomKonstravimas random = new randomKonstravimas();
            random.RankinisIsrinkimas();
            random.robotoParametrai();
        }
    }
}
