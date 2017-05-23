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
        public static bool DisplayWannaexit = false;
        public static bool HasCharacter;
        

        static void Main(string[] args)
        {
            Introduction();
            while(ExitCode == false)
            {
                int LocalCharacterChosen;
               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose and option!\n Champion Creation(1)\n");
                LocalCharacterChosen = SetNumber();//Beolvas egy számot int-be.
                if (LocalCharacterChosen == 1) {
                    BarbarianCreator Barb = new BarbarianCreator();
                    Barb.Barbarian();
                    Console.WriteLine("You have Chosen the mighty barbarian"); }
                Console.WriteLine("Chose a Menu Option(5)");
                int MenuChoice = SetNumber();
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
                            SetChampionValues.ChampionValueSetter();
                            DisplayStats();
                            while (DisplayWannaexit == false)
                            {
                                Settings.DisplaySetting(Settings.RandomizeSetting());//Ez randomizál is!
                            }
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
            Console.WriteLine("Your are" + Champions.Name + "Your damage is " + Champions.TotalDamage + " Your defence is " + Champions.TotalDefence);
        }
        public static void Introduction()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome To the Champions");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
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
        public static int SetNumber()
        {
            int ReadNumeric=0;
            //int n;
            bool NumberOrNot = false;
            while (NumberOrNot == false)
            {
                try
                {
                   // ReadNumeric = Console.ReadLine();

                    //NumberOrNot = int.TryParse(ReadNumeric, out n);
                    ReadNumeric = Convert.ToInt32(Console.ReadLine());
                    NumberOrNot = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    NumberOrNot = false;

                }

            }
            return ReadNumeric;
        }
    }
   
}
