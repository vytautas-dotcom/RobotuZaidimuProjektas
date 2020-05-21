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
        public List<IDalis> botRobotoDalys { get; set; }

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

            
        }
    }
}
