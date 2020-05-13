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
        public IDalis Dalis { get; set; }
        //public rankinisKonstravimas(string a)
        //{
        //    Dalis = a;
        //}
        public string UzklausaString(string b, int c)
        {

            return $"SELECT Id, {b}, Kaina from {b} Where Id={c} ";

        }
        public void RankinisIsrinkimas()
        {
            for (int j = 1; j <= 6; j++)
            {
                Console.WriteLine("**********************************************");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"                   {Enum.GetName(typeof(Dalys), j)}");
                Console.ResetColor();
                Console.WriteLine("**********************************************");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Id   Rusis                               Kaina");
                Console.ResetColor();

                string b = daliuIstraukimas(j);
                

                Console.WriteLine("**********************************************");
                Console.WriteLine($"Iveskite norimos rusies Id ir spauskite \"ENTER\"");
                
                int ivedamasId = Int32.Parse(Console.ReadLine());
                inicializavimasKlasese(ivedamasId, b);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Vyksta roboto konstravimas..");
            
        }
        public string daliuIstraukimas(int a)
        {
            string b = null;
            
            for (int i = 1; i <= 3; i++)
            {


                Console.WriteLine("----------------------------------------------");
                DbPrisijungimas dbPrisijungimas = new DbPrisijungimas(UzklausaString(Enum.GetName(typeof(Dalys), a), i));
                dbPrisijungimas.Gyvbe();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(dbPrisijungimas.Id + "    " + dbPrisijungimas.Dalis + " " + dbPrisijungimas.Kaina);
                Console.ResetColor();
                b = dbPrisijungimas.Dalis;
            }
            return b;
        }
        public void inicializavimasKlasese(int a, string b)
        {
            switch (a)
            {
                case 1:
                    new Vaziuokle().setVaziuokle(b);
                    break;
                case 2:
                    new Sarvai().Pavadinimas = b;
                    break;
                case 3:
                    new Variklis().Pavadinimas = b;
                    break;
                case 4:
                    new IsmaniejiGinklai().Pavadinimas = b;
                    break;
                case 5:
                    new Ginklai().Pavadinimas = b;
                    break;
                case 6:
                    new Valdymas().Pavadinimas = b;
                    break;
                default:
                    break;
            }
        }
        

    }

}