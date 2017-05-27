using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök
{
    class Level //Egy szintlépés esetén az alapértékek módosulnak csak. Több hit chance, több crit chance, több alap hp. A pontos értékeket elég akkor megcsinálni, amikor már mással kész vagyunk, egyelőre
                //csak valami beírok, hogy legyen ott valami
    {
        public static void LevelUpper()
        {
            if (Champions.XP > 100 && Champions.ChampionLevel == 0)
            {
                Champions.ChampionLevel++;
                Champions.BaseHealth += 50;
                Champions.BaseHitChance += 3;
                Champions.BaseCritChance += 1;
                Console.WriteLine("You are level 2"); // ezt jó lenne majd valami szép szinnel kiemelni, és egy külön method csinálhatná, mert ez így súlyos kódismétlés.
            }
            if (Champions.XP > 200 && Champions.ChampionLevel == 1)
            {
                Champions.ChampionLevel++;
                Champions.BaseHealth += 50;
                Champions.BaseHitChance += 3;
                Champions.BaseCritChance += 1;
                Console.WriteLine("You are level 3");
            }
            if (Champions.XP > 300 && Champions.ChampionLevel == 2)
            {
                Champions.ChampionLevel++;
                Champions.BaseHealth += 50;
                Champions.BaseHitChance += 3;
                Champions.BaseCritChance += 1;
                Console.WriteLine("You are level 4");
            }
            if (Champions.XP > 300 && Champions.ChampionLevel == 3)
            {
                Champions.ChampionLevel++;
                Champions.BaseHealth += 50;
                Champions.BaseHitChance += 3;
                Champions.BaseCritChance += 1;
                Console.WriteLine("You are level 5");
            }
            if (Champions.XP > 400 && Champions.ChampionLevel == 4)
            {
                Champions.ChampionLevel++;
                Champions.BaseHealth += 50;
                Champions.BaseHitChance += 3;
                Champions.BaseCritChance += 1;
                Console.WriteLine("You are level 6");
            }
            if (Champions.XP > 500 && Champions.ChampionLevel == 5)
            {
                Champions.ChampionLevel++;
                Champions.BaseHealth += 50;
                Champions.BaseHitChance += 3;
                Champions.BaseCritChance += 1;
                Console.WriteLine("You are level 7");
            }
            if (Champions.XP > 600 && Champions.ChampionLevel == 6)
            {
                Champions.ChampionLevel++;
                Champions.BaseHealth += 50;
                Champions.BaseHitChance += 3;
                Champions.BaseCritChance += 1;
                Console.WriteLine("You are level 8");
            }
            if (Champions.XP > 700 && Champions.ChampionLevel == 7)
            {
                Champions.ChampionLevel++;
                Champions.BaseHealth += 50;
                Champions.BaseHitChance += 3;
                Champions.BaseCritChance += 1;
                Console.WriteLine("You are level 9");
            }
        }
    }
}
