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
            if (Champions.XP > 100 && Champions.HosLevel == 0)
            {
                Champions.HosLevel++;
            }
            if (Champions.XP > 200 && Champions.HosLevel == 1)
            {
                Champions.HosLevel++;
            }
            if (Champions.XP > 300 && Champions.HosLevel == 2)
            {
                Champions.HosLevel++;
            }
            if (Champions.XP > 300 && Champions.HosLevel == 3)
            {
                Champions.HosLevel++;
            }
            if (Champions.XP > 400 && Champions.HosLevel == 4)
            {
                Champions.HosLevel++;
            }
            if (Champions.XP > 500 && Champions.HosLevel == 5)
            {
                Champions.HosLevel++;
            }
            if (Champions.XP > 600 && Champions.HosLevel == 6)
            {
                Champions.HosLevel++;
            }
            if (Champions.XP > 700 && Champions.HosLevel == 7)
            {
                Champions.HosLevel++;
            }
        }
    }
}
