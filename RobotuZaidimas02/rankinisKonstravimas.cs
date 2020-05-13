using RobotoDalys;
using RobotuZaidimas02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstravimasPrisijungimas
{
    enum Dalys
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
        
        public string UzklausaString(string b, int c)
        {

            return $"SELECT Id, {b}, Galia, Kaina, Svoris from {b} Where Id={c} ";

        }
        
        public void RankinisIsrinkimas()
        {
            
            for (int j = 1; j <= 6; j++)
            {
                string[] vardas = { };
                #region virsutineEilute
                Console.WriteLine("**********************************************");
                Console.ForegroundColor = ConsoleColor.Red;
                #endregion
                Console.WriteLine($"                   {Enum.GetName(typeof(Dalys), j)}");
                #region virsutineEilute
                Console.ResetColor();
                Console.WriteLine("**********************************************");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Id   Rusis                               Kaina");
                Console.ResetColor();
                #endregion

                daliuIstraukimas(j, vardas);

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
        public void daliuIstraukimas(int a, string[] vardas)
        {
            
            for (int i = 1; i <= 3; i++)
            {


                Console.WriteLine("----------------------------------------------");
                DbPrisijungimas dbPrisijungimas = new DbPrisijungimas(UzklausaString(Enum.GetName(typeof(Dalys), a), i));
                dbPrisijungimas.Gyvbe();
                
                #region lentelesIsvedimas
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(dbPrisijungimas.Id + "    " + dbPrisijungimas.Dalis + " " + dbPrisijungimas.Kaina);
                Console.ResetColor();
                #endregion
                vardas[i] = dbPrisijungimas.Dalis;
            }

            int ivedamasId = Int32.Parse(Console.ReadLine());
            inicializavimasKlasese(a, vardas[ivedamasId]);
        }
        public void inicializavimasKlasese(int a, string b)
        {
            //UzklausaString(ba, b);
            //DbPrisijungimas dbPrisijungimas = new DbPrisijungimas(UzklausaString2(Enum.GetName(typeof(Dalys), a), j));
            //dbPrisijungimas.Gyvbe();

            switch (a)
            {
                case 1:
                    Vaziuokle vaziuokle = new Vaziuokle();
                    vaziuokle.setVaziuokle(b);
                    break;
                case 2:
                    new Sarvai().setSarvai(b);
                    break;
                case 3:
                    new Variklis().setVariklis(b);
                    break;
                case 4:
                    new IsmaniejiGinklai().setIsmaniejiGinklai(b);
                    break;
                case 5:
                    new Ginklai().setGinklai(b);
                    break;
                case 6:
                    new Valdymas().setValdymas(b);
                    break;
                default:
                    break;
            }
        }
        

    }

}