using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök//A newly created enemy should modify the public values, so 1 value can be used for any champ
{
    class Enemies
    {
        
        public static int EnemyBaseAttack { get; set; }
        public static int EnemyBaseDefence { get; set; }
        public static int EnemyBaseDamage { get; set; }
        public static int EnemyBaseHitChance { get; set; }
        public static int EnemyBaseArmor { get; set; }
        public static int EnemyCritChance { get; set; }
        public static int EnemyBaseHealth;
        public static int EnemyBaseCritChance;
        public static int EnemyBaseCritDamage;
        //ValueModifiers
        public static int EnemyWeaponDamageModifier { get; set; }
        public static int EnemyWeaponAttackModifier { get; set; }
        public static int EnemyArmorModifier { get; set; }
        public static int EnemyHitChanceModifier;
        public static int EnemyCritDamage { get; set; }
        //TotalValues
        public static int EnemyTotalDamage = EnemyBaseDamage + EnemyWeaponDamageModifier;
        public static int EnemyTotalDefence = EnemyBaseDefence + EnemyArmorModifier;
        public static int EnemyTotalHitChance = EnemyBaseHitChance + EnemyHitChanceModifier;


    }
    class FallenCreator
    {
        public  void Fallen()
        {
            Enemies.EnemyBaseHealth = 50;
            Enemies.EnemyBaseAttack = 10;
            Enemies.EnemyBaseDefence = 1;
            Enemies.EnemyBaseDamage = 1;
            Enemies.EnemyBaseHitChance = 5;
            Enemies.EnemyBaseArmor = 1;
            Enemies.EnemyBaseCritChance = 1;
            Enemies.EnemyBaseCritDamage = 1;
        }
    }
    class TaintedCreator
    {
        public void Tainted()
        {
            Enemies.EnemyBaseHealth = 50;
            Enemies.EnemyBaseAttack = 10;
            Enemies.EnemyBaseDefence = 1;
            Enemies.EnemyBaseDamage = 1;
            Enemies.EnemyBaseHitChance = 5;
            Enemies.EnemyBaseArmor = 1;
            Enemies.EnemyBaseCritChance = 1;
            Enemies.EnemyBaseCritDamage = 1;
        }
    }
    class NewEnemy
    {
        public static void Randomizer()
        {
            Random RndEnemy = new Random();
            if (RndEnemy.Next(0,1) == 0)
            {
                FallenCreator Fallen = new FallenCreator();
            }
            else if (RndEnemy.Next(0,1) == 1)
            {
                TaintedCreator Tainted = new TaintedCreator();
            }
        }
    }
}   
