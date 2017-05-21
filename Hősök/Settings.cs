using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök //Ezek lesznek a helyek, ahova a karakter eljuthat. Csak olyan helyen vehet majd dolgokat, ahol van shop pl, és csak ott pihenhet, ahol az megengedett/lehetséges.
{
    class Settings
    {
        public static bool CanShop;
        public static bool CanRest;

        public static void SettingForest()
        {
            CanRest = true;
            CanShop = false;
            Console.WriteLine("You have reached a forest");
            //An enemy to fight
            
        }
        public static void SettingTavern()
        {
            CanRest = true;
            CanShop = true;
            Console.WriteLine("You have found a tavern, where you can drink, rest, and might even be able to shop");
        }
    }
}
