using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök
{
    class Fight // a critet nem implementáltam még 
    {
        public static void Battle()
        {
            while (Enemies.EnemyBaseHealth > 0)
            {
                //Hős megüti a szörnyet
                ChampionHitChance();
                if (Champions.TotalHitChance > 50)
                {
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
    }
}
