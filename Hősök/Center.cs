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
        public static int MenuChoice;
        

        static void Main(string[] args)
        {
            Introduction();
            while(ExitCode == false)//Amíg a játék tart
            {
                int LocalCharacterChosen;
               
                Console.ForegroundColor = ConsoleColor.Green;
                if (HasCharacter == false)//Nincs kari, muszáj csinálni egyet
                {
                    Console.WriteLine("Choose and option!\n Champion Creation(1)\n");

                    LocalCharacterChosen = SetNumber();//Beolvas egy számot int-be.
                    if (LocalCharacterChosen == 1 && HasCharacter == false)//Nincs kari, de akar egy barbárt
                    {
                        BarbarianCreator Barb = new BarbarianCreator();
                        Barb.Barbarian();
                        HasCharacter = true;
                        Console.WriteLine("You have Chosen the mighty barbarian.\n Your journey begins");
                    }
                }
                DisplayMenu();//Ez itt a játék közepe
                Console.ResetColor();
                Console.ReadLine();
            }
        }
        public static void DisplayStats()
        {
            Console.WriteLine("Your are" + Champions.Name + " a level " + Champions.ChampionLevel + 1 + " champion. Your damage is " + Champions.TotalDamage + " Your defence is " + Champions.TotalDefence);
        }
        public static void Introduction()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome To the Champions");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
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
        public static void DisplayMenu()
        {
            Console.WriteLine("Choose a Menu Option\nEquip Items(1)\nSave(2)\nLoad(3)\nSemmi(4)\nDiscovery and Fight(5)\nQuit(6)");
            MenuChoice = SetNumber();
            switch (MenuChoice)
            {
                case 1:
                    Console.WriteLine("Here You Can Equip Items\n Enter the name of the item you want to equip");
                    Inventory.ItemList();
                    Items.Equip(Console.ReadLine());
                    break;
                case 2://Inventory + equip items
                    break;
                case 3://Some kind of shop, is Settings.CanShop = true
                    Console.WriteLine("Itt még nicns a bolt");
                    break;
                case 4:
                    Console.WriteLine("Itt még nicns semmi");//Save?
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
                        //WhatHappensNext();
                    }
                    break;
                case 6:
                    Console.WriteLine("Thank you for playing");
                    ExitCode = true;
                    break;
            }
        }
    }
   
}
