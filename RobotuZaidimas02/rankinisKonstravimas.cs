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
    
        
    class rankinisKonstravimas : abstractKonstravimas
    {
        
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
            }

            Console.WriteLine("Iveskite norimos dalies Id");
            int pasirinkimasPagalId = Int32.Parse(Console.ReadLine());
            inicializavimasKlasese(segmentoPavadinimoNr, vardas[pasirinkimasPagalId-1]);
        }
        public void inicializavimasKlasese(int segmentoPavadinimoNr, string daliesPavadinimas)
        {
            IDalis dalis;

            switch (segmentoPavadinimoNr)
            {
                case 1:
                    IDalis vaziuokle = new Vaziuokle();
                    vaziuokle.setPavadinimas(daliesPavadinimas);
                    break;
                case 2:
                    IDalis sarvai = new Sarvai();
                    sarvai.setPavadinimas(daliesPavadinimas);
                    break;
                case 3:
                    IDalis variklis = new Variklis();
                    variklis.setPavadinimas(daliesPavadinimas);
                    break;
                case 4:
                    IDalis ismaniejiGinklai = new IsmaniejiGinklai();
                    ismaniejiGinklai.setPavadinimas(daliesPavadinimas);
                    break;
                case 5:
                    IDalis ginklai = new Ginklai();
                    ginklai.setPavadinimas(daliesPavadinimas);
                    break;
                case 6:
                    IDalis valdymas = new Valdymas();
                    valdymas.setPavadinimas(daliesPavadinimas);
                    break;
                default:
                    break;
            }
        }

        public override IDalis pridetiVaziuokle(string a)
        {
            return new Vaziuokle(a);
        }

        public override IDalis pridetiSarvai(string a)
        {
            return new Sarvai(a);
        }

        public override IDalis pridetiVariklis()
        {
            throw new NotImplementedException();
        }

        public override IDalis pridetiIsmaniejiGinklai()
        {
            throw new NotImplementedException();
        }

        public override IDalis pridetiGinklai()
        {
            throw new NotImplementedException();
        }

        public override IDalis pridetiValdymas()
        {
            throw new NotImplementedException();
        }
    }

}