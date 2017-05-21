using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök //Ezek lesznek a helyek, ahova a karakter eljuthat. Csak olyan helyen vehet majd dolgokat, ahol van shop pl, és csak ott pihenhet, ahol az megengedett/lehetséges.
{
    class Settings
    {
        public static bool CanShop = false;
        public static bool CanRest = false;
        public static bool CanFight = false; // később ez alapján dől el, h lehet-e egy helyen harcolni. Viszont nem kötelező, pl kocsmai verekedés
        public static bool MustFight = false;//Kényszeríti a harcot, azonnal
        public static bool CanExit = true; //Ki tud-e menni, és menteni vagy ilyesmi? muszáj újra harcolnia?

        //public static int Set;


        public static void DisplaySetting()
        {
            int Set = RandomizeSetting(); //Randomizálja, h milyen set legyen
            if (Set == 0)
            {
                SettingForest();
            }
            else if (Set == 1)
            {
                SettingTavern();
            }
            else if (Set == 2)
            {
                SettingDeepForest();
            }
        }

        public static void SettingForest()//0
        {
            CanRest = true;
            CanShop = false;
            CanFight = false;
            CanExit = true;
            Console.WriteLine("You have reached a forest");
            //An enemy to fight
            
        }
        public static void SettingTavern()//1
        {
            CanRest = true;
            CanShop = true;
            CanFight = false;
            CanExit = true;
            Console.WriteLine("You have found a tavern, where you can drink, rest, and might even be able to shop");
        }
        public static void SettingDeepForest()//2
        {
            CanRest = false;
            CanShop = false;
            CanFight = true;
            MustFight = true;
            CanExit = false;

            Console.WriteLine("Prepare for trouble");
            //itt következik a harc
            Fight.Battle();
        }
        public static int RandomizeSetting()
        {
            int Set;
            Random SetRnd = new Random();
            SetRnd.Next(0, 2);
            Set = Convert.ToInt32(SetRnd);
            return Set;
        }
    }
}
