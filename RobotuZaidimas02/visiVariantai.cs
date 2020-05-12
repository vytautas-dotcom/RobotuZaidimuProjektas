using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstravimasPrisijungimas
{
    enum Segmentai
    {
        Vaziuokle,
        Sarvai,
        Variklis,
        ismaniejiGinklai,
        Ginklai,
        Valdymas

    }

    class visiVariantai
    {
        public void visiDaliuVariantai()
        {

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        for (int l = 1; l <= 3; l++)
                        {
                            for (int m = 1; m <= 3; m++)
                            {
                                for (int n = 1; n <= 3; n++)
                                {



                                    vidineUzklausa(i, j, k, l, m, n);





                                }
                            }
                        }
                    }
                }
            }

        }
        static void vidineUzklausa(int a, int b, int c, int d, int e, int f)
        {
            int[] dalys = { a, b, c, d, e, f };
            int visaGyvybe = 0;
            int visoKaina = 0;
            int visoSvoris = 0;

            for (int g = 0; g < 6; g++)
            {
                string lentele = Enum.GetName(typeof(Segmentai), g);
                int dalis = dalys[g];

                var query = $"SELECT Gyvybe, Kaina, Svoris from {lentele} WHERE Id={dalis}";

                DbPrisijungimas dbPrisijungimas = new DbPrisijungimas(query);
                dbPrisijungimas.Gyvbe();

                visaGyvybe += dbPrisijungimas.Gyvybe;
                visoKaina += dbPrisijungimas.Kaina;
                visoSvoris += dbPrisijungimas.Svoris;


            }
            Console.WriteLine($"Gyvybe-{visaGyvybe}, Kaina-{visoKaina}, Svoris-{visoSvoris}");
        }
    }
}

