using KonstravimasPrisijungimas;
using Robotai;
using Robotai.RobotoDalys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotuZaidimas02
{
    class Account
    {
        public string Vardas { get; set; }
        public int Suma { get; set; } = 5000;
        public Account(string vardas, string a)
        {
            Vardas = vardas;
            if (a == "user")
            {
                userRobot user = new userRobot();
                user.Konstravimas();
            }
            else if(a == "bot")
            {
                BotRobot bot = new BotRobot();
                bot.Konstravimas();
            }
            else
                Console.WriteLine("Have a nice day :)");
        }
        
    }
}
