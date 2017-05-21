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
                //Hős megüti a szörnyet
                ChampionHitChance();
                if (Champions.TotalHitChance > 50)
                {
                    ChampionCritChance();
                    Enemies.EnemyBaseHealth = Enemies.EnemyBaseHealth - (Champions.TotalDamage - Enemies.EnemyTotalDefence);
                    //kiírni h mitörtént
                }
                else
                {
                    //Mellé ütött
                }
                //Szörny megüti a hőst
                if (Enemies.EnemyTotalHitChance > 50)
                {
                    EnemyCritChance();
                    Champions.TotalHealth = Champions.TotalHealth - (Enemies.EnemyTotalDamage - Champions.TotalDefence);
                    //kiírni h mitörtént
                    if (Champions.TotalHealth < 0)
                    {
                        //Meghalt a hős
                        Center.ExitCode = true;
                        Console.WriteLine("YOU HAVE DIED");
                    }
                }
                else
                {
                    //mellé ütött a szörny
                }
            }
            //loot
            Console.WriteLine("A szörny meghalt");
        }
        public static int ChampionHitChance()
        {
            Random RndHitChance = new Random();
            RndHitChance.Next(0, 100);
            int HitChance = Convert.ToInt32(RndHitChance) + Champions.BaseHitChance;
            return HitChance;
        }
        public static int EnemyHitChance()
        {
            Random RndHitChance = new Random();
            RndHitChance.Next(0, 100);
            int EnemyHitChance = Convert.ToInt32(RndHitChance) + Enemies.EnemyBaseHitChance;
            return EnemyHitChance;
        }
        public static void ChampionCritChance()
        {   int CritChance;
            Random RndCritChance = new Random();
            RndCritChance.Next(0, 100);
            CritChance = Convert.ToInt32(RndCritChance);
            if (CritChance < Champions.TotalCritChance)
            {
                Champions.TotalDamage = Champions.TotalDamage * Champions.CritDamageModifier;
                Console.WriteLine("Champion Critical Hit");
            }
            
        }
        public static void EnemyCritChance()
        {
            int CritChance;
            Random RndCritChance = new Random();
            RndCritChance.Next(0, 100);
            CritChance = Convert.ToInt32(RndCritChance);
            if (CritChance < Enemies.EnemyCritChance)
            {
                Enemies.EnemyTotalDamage = Enemies.EnemyTotalDamage * Enemies.EnemyCritDamage;
                Console.WriteLine("Enemy Critical Hit");
            }

        }
    }
}
