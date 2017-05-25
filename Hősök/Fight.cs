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
                ChampionHitChance();
                EnemyHitChance();
                if (Champions.TotalHitChance > 50)
                {
                    ChampionCritChance();
                    LocalChampionDmg = Champions.TotalDamage - Enemies.EnemyTotalDefence;
                    Enemies.EnemyBaseHealth = Enemies.EnemyBaseHealth - LocalChampionDmg;
                    Console.WriteLine(LocalChampionDmg + "Champ Dmg");
                }
                else
                {
                    Console.WriteLine("The hero missed");
                }
                //Szörny megüti a hőst
                if (Enemies.EnemyTotalHitChance > 50)
                {
                    LocalMonsterDmg = Enemies.EnemyTotalDamage - Champions.TotalDefence;
                    Champions.TotalHealth = Champions.TotalHealth - LocalMonsterDmg;
                    Console.WriteLine(LocalMonsterDmg + "Monster Dmg");
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
            Console.ReadLine();
            
        }
        public static void ChampionHitChance()
        {
            Random RndHitChance = new Random();
            int LocalRndHitChance = RndHitChance.Next(0, 50);
            Champions.HitChanceModifier = LocalRndHitChance;
            SetChampionValues.ChampionValueSetter();
            
        }
        public static void EnemyHitChance()
        {
            Random RndHitChance = new Random();
            int LocalRndHitChance = RndHitChance.Next(0, 50);
            Enemies.EnemyHitChanceModifier = LocalRndHitChance;
            SetEnemyValues.EnemyValueSetter();
            
        }
        public static void ChampionCritChance()
        {   
            Random RndCritChance = new Random();
            int LocalRndCritChance = RndCritChance.Next(0, 100);
            if (Champions.TotalCritChance > LocalRndCritChance )
            {
                Champions.TotalDamage = Champions.TotalDamage * Champions.CritDamageModifier;
                Console.WriteLine("Champion Critical Hit");
            }
            
        }
        public static void EnemyCritChance()
        {
            Random RndCritChance = new Random();
            int LocalRndCritChance = RndCritChance.Next(0, 100);
            if (Enemies.EnemyCritChance > LocalRndCritChance)
            {
                Enemies.EnemyTotalDamage = Enemies.EnemyTotalDamage * Enemies.EnemyCritDamage;
                Console.WriteLine("Enemy Critical Hit");
            }

        }
    }
}
