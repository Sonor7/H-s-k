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


        public static void DisplaySetting(int SetNum)
        {
            int Set = SetNum; //RandomizeSetting(); //Randomizálja, h milyen set legyen
            if (Set == 0)
            { 
                SettingForest();
                EnterMenu();
                DisplayAvailableOptions();//A bool-ok alapján kiírja a játékosnak, hogy a helyszínen mi lehetséges.
            }
            else if (Set < 3)
            {
                SettingTavern();
                EnterMenu();
                DisplayAvailableOptions();
            }
            else if (Set < 5)
            {
                SettingDeepForest();
                EnterMenu();
                DisplayAvailableOptions();
            }
        }

        public static bool SettingForest()//0
        {
            CanRest = true;
            CanShop = false;
            CanFight = false;
            CanExit = true;
            Console.WriteLine("You have reached a forest");
            Console.ReadLine();
            return true;
            
            
            //An enemy to fight
            
        }
        public static bool SettingTavern()//1
        {
            CanRest = true;
            CanShop = true;
            CanFight = false;
            CanExit = true;
            Console.WriteLine("You have found a tavern, where you can drink, rest, and might even be able to shop");
            Console.ReadLine();
            return true;
        }
        public static bool SettingDeepForest()//2
        {
            CanRest = false;
            CanShop = false;
            CanFight = true;
            MustFight = true;
            CanExit = false;

            Console.WriteLine("You ventured deep into the forest.\n Something followed you!\n Prepare for trouble");
            //itt következik a harc
            NewEnemy.Randomizer();
            Fight.Battle();
            Console.ReadLine();
            return true;
        }
        public static int RandomizeSetting()
        {
            Random SetRnd = new Random();
            //int Set = SetRnd.Next(0, 2);
            return SetRnd.Next(0,5);
        }
        public static void EnterMenu()
        {
            if (CanExit == true)
            {
                Console.WriteLine("Do you want to enter the menu?Y/N");
                string LocalYesNo = Console.ReadLine();
                if (LocalYesNo == "Y")
                {
                    Center.LocalWannaExit = true;
                    Center.DisplayMenu();
                }
                else { Console.Clear(); }
            }
        }
        public static void DisplayAvailableOptions()
        {
            if (CanRest == true)
            {
                Console.WriteLine("You can rest here");
            }
            if (CanShop == true)
            {
                Console.WriteLine("There is a shop here");
            }
            if(CanFight == true)
            {
                Console.WriteLine("You might be able to start a brawl here");
            }
        }
    }
}
