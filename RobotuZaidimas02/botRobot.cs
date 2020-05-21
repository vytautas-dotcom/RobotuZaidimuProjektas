using KonstravimasPrisijungimas;
using RobotoDalys;
using RobotuZaidimas02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotai
{
    class BotRobot : Robotas
    {
        public List<IDalis> botRobotoDalys = new List<IDalis>();

        void objektaiRobotui()
        {
            botRobotoDalys.Add(new Vaziuokle());
            botRobotoDalys.Add(new Variklis());
            botRobotoDalys.Add(new Sarvai());
            botRobotoDalys.Add(new IsmaniejiGinklai());
            botRobotoDalys.Add(new Ginklai());
            botRobotoDalys.Add(new Valdymas());
        }
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

            objektaiRobotui();
            int i = 0;
            foreach (var item in random.botRobot)
            {
                botRobotoDalys[i].Pavadinimas = item.Key;
                botRobotoDalys[i].Galia = item.Value.Item1;
                botRobotoDalys[i].Kaina = item.Value.Item2;
                botRobotoDalys[i].Svoris = item.Value.Item3;
                i++;
            }
        }
    }
}
