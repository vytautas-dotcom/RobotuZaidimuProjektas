using KonstravimasPrisijungimas;
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
        public List<string> DaliuListas { get; set; }
        public int Suma { get; set; } = 5000;
        public Account(string vardas, rankinisKonstravimas Dalys)
        {
            Vardas = vardas;
            DaliuIstraukimas(Dalys);
            
        }
        public void DaliuIstraukimas(rankinisKonstravimas Dalys)
        {
            foreach (var item in Dalys.userRobot.Keys)
            {
                DaliuListas.Add(item);
            }
        }
        
    }
}
