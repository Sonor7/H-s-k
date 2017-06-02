using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök// Egy kör = Hős talál-e?Hős crittel-e?Ha Igen, mennyit sebez? Sebzés levonása. U.e Szörnnyel
{
    class Fight  
    {
        public static void Battle()
        {
            while (Enemies.EnemyBaseHealth > 0)
            {
                int LocalChampionDmg;
                int LocalMonsterDmg;
                //Hős megüti a szörnyet
                System.Threading.Thread.Sleep(2000);
                ChampionHitChance();
                if (Champions.TotalHitChance > 50)
                {
                    ChampionCritChance();
                    LocalChampionDmg = Champions.TotalDamage - Enemies.EnemyTotalDefence;
                    Enemies.EnemyBaseHealth = Enemies.EnemyBaseHealth - LocalChampionDmg;
                    Console.WriteLine(LocalChampionDmg + " Champ Dmg");
                }
                else
                {
                    Console.WriteLine("The hero missed");
                }
                //Szörny megüti a hőst
                System.Threading.Thread.Sleep(2000);
                EnemyHitChance();
                if (Enemies.EnemyTotalHitChance > 50)
                {
                    EnemyCritChance();
                    LocalMonsterDmg = Enemies.EnemyTotalDamage - Champions.TotalDefence;
                    Champions.TotalHealth = Champions.TotalHealth - LocalMonsterDmg;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(LocalMonsterDmg + " Monster Dmg");
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (Champions.TotalHealth < 0)
                    {
                        //Meghalt a hős
                        Center.ExitCode = true;
                        Console.WriteLine("YOU HAVE DIED");
                    }
                }
                else
                {
                    Console.WriteLine("The monster has missed");
                }
            }
            //loot
            Console.WriteLine("The monster has died");
            Loot.RndItem();
            Champions.XP = Champions.XP + Enemies.EnemyXpToGive; //hozzáadja az xp-t
            Level.LevelUpper();//ellenőrzi, hogy teljesül-e a szintlépéshez szükséges kritérium, és szintet léptet
            Console.ReadLine();
            
        }
        public static void ChampionHitChance()
        {
            Random RndHitChance = new Random();
            int LocalRndHitChance = 0;
            LocalRndHitChance = RndHitChance.Next(0, 50);
            Champions.WeaponHitChanceModifier = LocalRndHitChance;
            SetChampionValues.ChampionValueSetter();
            
        }
        public static void EnemyHitChance()
        {
            Random RndEnemyHitChance = new Random();
            int LocalRndEnemyHitChance = 0;
            LocalRndEnemyHitChance = RndEnemyHitChance.Next(0, 50);
            Enemies.EnemyHitChanceModifier = LocalRndEnemyHitChance;
            SetEnemyValues.EnemyValueSetter();
            
        }
        public static void ChampionCritChance()
        {   
            Random RndCritChance = new Random();
            int LocalRndCritChance = 0;
            LocalRndCritChance = RndCritChance.Next(0, 100);
            if (Champions.TotalCritChance > LocalRndCritChance )
            {
                Champions.TotalDamage = Champions.TotalDamage * Champions.CritDamageModifier;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Champion Critical Hit");
                Console.ResetColor();
            }
            //else { Console.WriteLine("What is going on Champ"); }

        }
        public static void EnemyCritChance()
        {
            Random RndCritChance = new Random();
            int LocalRndEnemyCritChance = 0;
            LocalRndEnemyCritChance = RndCritChance.Next(0, 100);
            if (Enemies.EnemyCritChance > LocalRndEnemyCritChance)
            {
                
                Enemies.EnemyTotalDamage = Enemies.EnemyTotalDamage * Enemies.EnemyCritDamage;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Enemy Critical Hit");
                Console.ResetColor();
            }
            //else { Console.WriteLine("What is going on Enemy"); }

        }
    }
}
