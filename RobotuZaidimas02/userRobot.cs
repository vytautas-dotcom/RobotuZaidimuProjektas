using KonstravimasPrisijungimas;
using RobotoDalys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotai.RobotoDalys
{
    class userRobot : Robotas
    {
        public List<IDalis> userRobotoDalys { get; set; }
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
            rankinisKonstravimas rankinis = new rankinisKonstravimas();
            rankinis.RankinisIsrinkimas();
            rankinis.robotoParametrai();
        }
    }
}
