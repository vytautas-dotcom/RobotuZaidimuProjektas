using RobotoDalys;
using RobotuZaidimas02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstravimasPrisijungimas
{
    enum Segmentai
    {
        Vaziuokle = 1,
        Sarvai,
        Variklis,
        ismaniejiGinklai,
        Ginklai,
        Valdymas
    }
    
        
    class rankinisKonstravimas
    {
        public Dictionary<string, (int, int, int)> userRobot = new Dictionary<string, (int, int, int)>();
        Random rnd = new Random();
        public string UzklausaString(string b, int c)
        {

            return $"SELECT Id, {b}, Galia, Kaina, Svoris from {b} Where Id={c} ";

        }
        
        public void RankinisIsrinkimas()
        {
            
            for (int j = 1; j <= 6; j++)
            {
                
                #region virsutineEilute
                Console.WriteLine("**********************************************");
                Console.ForegroundColor = ConsoleColor.Red;
                #endregion
                Console.WriteLine($"                   {Enum.GetName(typeof(Segmentai), j)}");
                #region virsutineEilute
                Console.ResetColor();
                Console.WriteLine("**********************************************");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Id   Rusis                               Kaina");
                Console.ResetColor();
                #endregion

                daliuIstraukimas(j);

                #region apatineEilute
                Console.WriteLine("**********************************************");
                Console.WriteLine($"Iveskite norimos rusies Id ir spauskite \"ENTER\"");
                #endregion

                #region ApatineEilute
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                #endregion
            }
            Console.WriteLine("Vyksta roboto konstravimas..");
            
        }
        public void daliuIstraukimas(int segmentoPavadinimoNr)
        {
            string[] vardas = new string[3];
            int[] galia = new int[3];
            int[] kaina = new int[3];
            int[] svoris = new int[3];

            for (int i = 0; i < 3; i++)
            {


                Console.WriteLine("----------------------------------------------");
                DbPrisijungimas dbPrisijungimas = new DbPrisijungimas(UzklausaString(Enum.GetName(typeof(Segmentai), segmentoPavadinimoNr), i+1));
                dbPrisijungimas.Gyvbe();
                
                #region lentelesIsvedimas
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(dbPrisijungimas.Id + "    " + dbPrisijungimas.Dalis + " " + dbPrisijungimas.Kaina);
                Console.ResetColor();
                #endregion
                vardas[i] = dbPrisijungimas.Dalis;
                galia[i] = dbPrisijungimas.Galia;
                kaina[i] = dbPrisijungimas.Kaina;
                svoris[i] = dbPrisijungimas.Svoris;

            }

            Console.WriteLine("Iveskite norimos dalies Id");
            //int pasirinkimasPagalId = rnd.Next(1, 4);
            int pasirinkimasPagalId = Int32.Parse(Console.ReadLine());
            inicializavimasKlasese(vardas[pasirinkimasPagalId-1],
                galia[pasirinkimasPagalId-1],
                kaina[pasirinkimasPagalId-1],
                svoris[pasirinkimasPagalId-1]);
        }
        public void inicializavimasKlasese(string a, int b, int c, int d)
        {
            userRobot.Add(a, (b, c, d));

        }
        
        public void robotoParametrai()
        {
            int i = 1;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Sukonstravote super");
            Console.WriteLine("techmologini \"Killer\"");
            Console.WriteLine("klases robota");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Jusu pasirinktos dalys:");
            foreach (var item in userRobot)
            {
                Console.WriteLine(Enum.GetName(typeof(Segmentai), i) + "\t\t\t\t" + item.Key);
                i++;
            }
            Console.WriteLine("------------------------------------------------------");
        }
        
    }

}