using KonstravimasPrisijungimas;
using Robotai;
using Robotai.RobotoDalys;
//using randomKonstravimas;
using RobotoDalys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RobotuZaidimas02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            userRobot user = new userRobot();
            user.Konstravimas();

            BotRobot bot = new BotRobot();
            bot.Konstravimas();



            #region RANDOM
            //Account account1 = new Account("Killer");
            //randomKonstravimas random = new randomKonstravimas();
            //random.RankinisIsrinkimas();

            //int vgalia = 0;
            //int vkaina = 0;
            //int vsvoris = 0;
            //foreach (var item in random.botRobot.Values)
            //{
            //    vgalia += item.Item1;
            //    vkaina += item.Item2;
            //    vsvoris += item.Item3;
            //}
            //Console.WriteLine($"{vgalia} {vkaina} {vsvoris}");

            //string arr = "Lazeris                            ";
            //foreach (var item in random.botRobot.Keys)
            //{
            //    if (item == arr)
            //    {
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.WriteLine(item);
            //        Console.ResetColor();
            //    }
            //    else
            //        Console.WriteLine(item);

            //}

            //random.robotoParametrai();
            #endregion
            Console.ReadKey();

            #region AutomatinisValdymas
            //Konstravimas konstravimas = new Konstravimas();
            //konstravimas.visiDaliuVariantai();



            //randomKonstravimas konstravimas = new randomKonstravimas();
            //konstravimas.randomDaliuVariantai();

            //konstravimas.createList();
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(konstravimas.listas1[i]);
            //}



            //Console.ReadKey();
            #endregion

            #region RankinisValdymas
            //Console.WriteLine("Susikurkite robota ivesdami varda ir pasirinkdami norima zaidimo lygi");
            //Console.WriteLine("------------------------------------------------------------------");
            //Console.WriteLine("Zaidimo lygiai:\nlengvas -\t1\nvidutinis -\t2\nsunkus -\t3\nneimanomas -\t4");
            //string vardas = Console.ReadLine();
            //int lygis = Int32.Parse(Console.ReadLine());

            //Account account = new Account(vardas, lygis);



            //while (visoKaina < account.Suma)
            //{

            //    Console.WriteLine("Pasirinkite dali");
            //    string d = Console.ReadLine();
            //    Uzklausa uzklausa = new Uzklausa(d);
            //    Console.WriteLine($"Pasirinkite {d} rusi");
            //    string h = Console.ReadLine();
            //    string c = uzklausa.UzklausaString(h);

            //    DbPrisijungimas dbPrisijungimas = new DbPrisijungimas(c);

            //    dbPrisijungimas.Gyvbe();
            //    visaGyvybe += dbPrisijungimas.Gyvybe;
            //    visoKaina += dbPrisijungimas.Kaina;
            //    visoSvoris += dbPrisijungimas.Svoris;

            //    Console.WriteLine("------------------------------------------------------------------");
            //}



            //Console.WriteLine("------------------------------------------------------------------");
            //Console.WriteLine($"Jusu roboto komplektacija is viso tures {visaGyvybe} gyvybes tasku");
            //Console.WriteLine($"Komplektacijos kaina {visoKaina}");
            //Console.WriteLine($"Roboto svoris {((double)visoSvoris / 1000)} tonos");
            //Console.WriteLine("------------------------------------------------------------------");
            //Console.ReadLine();
            #endregion
        }
    }
}
