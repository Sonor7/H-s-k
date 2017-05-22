using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök
{
    class Center
    {   //Menu Related Values
        public static bool ExitCode;
        public static bool LocalWannaExit = false; //Set this to true when shopping or something.
        public static bool HasCharacter;
        static void Main(string[] args)
        {
            Introduction();
            while(ExitCode == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose and option!\n Champion Creation(1)\n");
                int LocalCharacterChosen = Convert.ToInt32(Console.ReadLine());
                if (LocalCharacterChosen == 1) { new BarbarianCreator(); Console.WriteLine("You have Chosen the mighty barbarian"); }
                Console.WriteLine("Chose a Menu Option");
                int MenuChoice = Convert.ToInt32(Console.ReadLine());
                switch (MenuChoice)
                {
                    case 1:
                        Console.WriteLine("Itt még nicns semmi");
                        break;
                    case 2://Inventory + equip items
                        Console.WriteLine("Itt még nicns semmi");
                        break;
                    case 3://Some kind of shop, is Settings.CanShop = true
                        Console.WriteLine("Itt még nicns semmi");
                        break;
                    case 4:
                        Console.WriteLine("Itt még nicns semmi");
                        break;
                    case 5://fighting + discovery(fights should take place at a randomized setting, and begin with your stats displaying)
                        
                        while (Center.LocalWannaExit == false)
                        {
                            DisplayStats();
                            Settings.DisplaySetting();//Ez randomizál is!
                            WhatHappensNext();
                        }
                            break;
                    case 6:
                        Console.WriteLine("Thank you for playing");
                        ExitCode = true;
                        break;
                }
                Console.ResetColor();
                Console.ReadLine();
            }
        }
        public static void DisplayStats()
        {
            Console.WriteLine("Your are" + Champions.Name + "Your base attack is " +Champions.BaseAttack + " Your base defence is " +Champions.BaseDefence);
        }
        public static void Introduction()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome To the Champions");
            Console.Clear();
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void WhatHappensNext()//If-else a settings alapján
        {
            if (Settings.CanFight == true && Settings.MustFight == true)
            { // Harc
                Fight.Battle();
            }
            else if (Settings.CanFight == true)
            {
                // Szét akarsz verni valakit csak úgy?
            }
            else if (Settings.CanRest == true)
            {
                //Akarsz Pihenni?
            }
            else if (Settings.CanShop == true)
            {
                // Akarsz vásárolni?
            }
            else if (Settings.CanExit == true)
            {
                Console.WriteLine("Ki akarsz lépni?Y/N");
                string Exit = Console.ReadLine();
                if (Exit == "Y") { Center.LocalWannaExit = true; }
            }
        }
    }
}
