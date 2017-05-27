using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök
{
    class Level
    {
        public static void LevelUpper()
        {
            if (Champions.XP > 100 && Champions.ChampionLevel == 0)
            {
                Champions.ChampionLevel++;
            }
            if (Champions.XP > 200 && Champions.ChampionLevel == 1)
            {
                Champions.ChampionLevel++;
            }
            if (Champions.XP > 300 && Champions.ChampionLevel == 2)
            {
                Champions.ChampionLevel++;
            }
            if (Champions.XP > 300 && Champions.ChampionLevel == 3)
            {
                Champions.ChampionLevel++;
            }
            if (Champions.XP > 400 && Champions.ChampionLevel == 4)
            {
                Champions.ChampionLevel++;
            }
            if (Champions.XP > 500 && Champions.ChampionLevel == 5)
            {
                Champions.ChampionLevel++;
            }
            if (Champions.XP > 600 && Champions.ChampionLevel == 6)
            {
                Champions.ChampionLevel++;
            }
            if (Champions.XP > 700 && Champions.ChampionLevel == 7)
            {
                Champions.ChampionLevel++;
            }
        }
    }
}
