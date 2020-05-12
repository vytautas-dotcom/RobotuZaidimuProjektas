using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstravimasPrisijungimas
{
    enum Segmentai1
    {
        Vaziuokle,
        Sarvai,
        Variklis,
        ismaniejiGinklai,
        Ginklai,
        Valdymas

    }
    class randomKonstravimas
    {
        List<string> listas = new List<string>();
        public string[] listas1 = new string[6];
        int p = 0;
        public void randomDaliuVariantai()
        {
            var rand = new Random();
            //rand.NextDouble() - 0-1
            int a = rand.Next(1, 4);
            int b = rand.Next(1, 4);
            int c = rand.Next(1, 4);
            int d = rand.Next(1, 4);
            int e = rand.Next(1, 4);
            int f = rand.Next(1, 4);

            vidineUzklausa(a, b, c, d, e, f);
        }
        public void vidineUzklausa(int a, int b, int c, int d, int e, int f)
        {
            int[] dalys = { a, b, c, d, e, f };
            int visaGyvybe = 0;
            int visoKaina = 0;
            int visoSvoris = 0;


            for (int g = 0; g < 6; g++)
            {
                string lentele = Enum.GetName(typeof(Segmentai1), g);
                int dalis = dalys[g];

                var query = $"SELECT Gyvybe, Kaina, Svoris, {lentele} from {lentele} WHERE Id={dalis}";

                DbPrisijungimas dbPrisijungimas = new DbPrisijungimas(query);
                dbPrisijungimas.Gyvbe();

                visaGyvybe += dbPrisijungimas.Gyvybe;
                visoKaina += dbPrisijungimas.Kaina;
                visoSvoris += dbPrisijungimas.Svoris;
                listas.Add(dbPrisijungimas.Dalis);


            }
            Console.WriteLine($"Gyvybe-{visaGyvybe}, Kaina-{visoKaina}, Svoris-{visoSvoris}");
        }
        public void showList()
        {
            foreach (var item in listas)
            {
                Console.WriteLine(item);
            }
        }
        public void createList()
        {
            foreach (var item in listas)
            {
                listas1[p] = item;
                p++;
            }

        }
    }
}
