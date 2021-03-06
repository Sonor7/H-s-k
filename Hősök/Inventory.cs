﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök
{
    class Inventory
    {
        public static List<string> Items = new List<string>();
        public static void ItemList()
        {
            Items.ForEach(Console.WriteLine);
        }
    }
    class Loot
    {
        public static void RndItem()//Az h mi hullik, függ az ellenféltől és a RndItemChance számtól. Utána hozzáadja az ItemList-hez, és utána ++ az adott item mennyiségéhez
        {
            Random RndItemChance = new Random();
            Random RndGoldAmount = new Random();
            //Chance = NewEnemy.Randomizer();
            if (Enemies.RndEnemyNumber == 0)//Fallen
            {
                
                if (RndItemChance.Next(0, 100) > 50)
                {
                    Items.SwordCount++;
                    Inventory.Items.Add("Sword");
                    Console.WriteLine("You have found a sword");
                }
            }
            else if (Enemies.RndEnemyNumber == 1)//Tainted
            {
                if (RndItemChance.Next(0, 100) > 50)
                {
                    Items.LeatherArmorCount++;
                    Inventory.Items.Add("Leather Armor");
                    Console.WriteLine("You have found a leather armor");

                }
            }
            int GoldFound = RndGoldAmount.Next(0, 30) + Enemies.EnemyGoldToGive;
            Champions.GoldAmount += GoldFound;
            Console.WriteLine("You have found " + GoldFound + " pieces of gold");
        }
    }
}
