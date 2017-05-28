using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök
{
    class Shop
    {   
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the shop\n Here is what you can buy\n (1)Sword(35) \n (2)Leather armor(50)");
            
        }
        public static void Buy()
        {
            Console.WriteLine("What do you want to buy?\nPlease enter the number before the item");
            string WantToBuy = Console.ReadLine();
            switch (WantToBuy)
            {
                case "1":
                    if (Champions.GoldAmount > 35)
                    {
                        Champions.GoldAmount -= 35;
                        Inventory.Items.Add("Sword");
                        Items.SwordCount++;
                        Console.WriteLine("You have bought a sword");
                    }
                    else { Console.WriteLine("Sorry, you don't have enough money"); }
                    break;
                case "2":
                    if (Champions.GoldAmount > 50)
                    {
                        Champions.GoldAmount -= 50;
                        Inventory.Items.Add("LeatherArmor");
                        Items.LeatherArmorCount++;
                        Console.WriteLine("You have bought a leather armor");
                    }
                    else { Console.WriteLine("Sorry, you don't have enough money"); }
                    break;
            }
        }
    }
}
