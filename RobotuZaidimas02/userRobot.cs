using KonstravimasPrisijungimas;
using RobotoDalys;
using RobotuZaidimas02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotai.RobotoDalys
{
    class userRobot : Robotas
    {
        public List<IDalis> userRobotoDalys = new List<IDalis>();

        void objektaiRobotui()
        {
            userRobotoDalys.Add(new Vaziuokle());
            userRobotoDalys.Add(new Variklis());
            userRobotoDalys.Add(new Sarvai());
            userRobotoDalys.Add(new IsmaniejiGinklai());
            userRobotoDalys.Add(new Ginklai());
            userRobotoDalys.Add(new Valdymas());
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
            
            rankinisKonstravimas rankinis = new rankinisKonstravimas();
            rankinis.RankinisIsrinkimas();
            rankinis.robotoParametrai();

            objektaiRobotui();
            int i = 0;
            foreach (var item in rankinis.userRobot)
            {
                userRobotoDalys[i].Pavadinimas = item.Key;
                userRobotoDalys[i].Galia = item.Value.Item1;
                userRobotoDalys[i].Kaina = item.Value.Item2;
                userRobotoDalys[i].Svoris = item.Value.Item3;
                i++;
            }  
        }
        public void showList()
        {
            foreach (var item in userRobotoDalys)
            {
                Console.WriteLine(item.Galia);
            }
        }
    }
}
