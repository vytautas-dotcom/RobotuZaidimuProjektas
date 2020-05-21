using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotuZaidimas02
{
    class Kova
    {

        public void RobotuKova(int userRobotoGalia, int botRobotoGalia)
        {
			(int pirmumas, float gyvybe, float ataka) user;
			(int pirmumas, float gyvybe, float ataka) bot;
			Random rand = new Random();

			Console.Write("--------user--------");
			user.pirmumas = rand.Next(20, 31);
			user.gyvybe = userRobotoGalia;
			//user.ataka = rand.Next(20, 31);

			Console.Write("--------bot--------");
			bot.pirmumas = rand.Next(20, 31);
			bot.gyvybe = botRobotoGalia;
			//bot.ataka = rand.Next(20, 31);

			if (bot.pirmumas > user.pirmumas)
			{
				Console.WriteLine("bot atakuoja pirmas!");
				while (user.gyvybe > 0 || bot.gyvybe > 0)
				{
					user.ataka = rand.Next(30, 41);
					bot.ataka = rand.Next(30, 41);

					user.gyvybe -= bot.ataka;
					Console.WriteLine("bot atakuoja su {0} zala, user lieka {1} gyvybes", bot.ataka, user.gyvybe);
					if (user.gyvybe < 0)
					{
						Console.WriteLine("bot lamejo");
						break;
					}
					bot.gyvybe -= user.ataka;
					Console.WriteLine("user atakuoja su {0} zala, bot lieka {1} gyvybes", user.ataka, bot.gyvybe);
					if (bot.gyvybe < 0)
					{
						Console.WriteLine("user laimejo");
						break;
					}
				}
			}
			else
			{
				Console.WriteLine("user atakuoja pirmas!");
				while (user.gyvybe > 0 || bot.gyvybe > 0)
				{
					user.ataka = rand.Next(30, 41);
					bot.ataka = rand.Next(30, 41);

					bot.gyvybe -= user.ataka;
					Console.WriteLine("user atakuoja su {0} zala, bot lieka {1} gyvybes", user.ataka, bot.gyvybe);
					if (bot.gyvybe < 0)
					{
						Console.WriteLine("user laimejo");
						break;
					}
					user.gyvybe -= bot.ataka;
					Console.WriteLine("bot atakuoja su {0} zala, user lieka {1} gyvybes", bot.ataka, user.gyvybe);
					if (user.gyvybe < 0)
					{
						Console.WriteLine("bot laimejo");
						break;
					}
				}
			}
		}
    }
}
