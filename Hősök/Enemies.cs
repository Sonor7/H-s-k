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
        public static int EnemyXpToGive;
        public static int EnemyGoldToGive;
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
        //Misc
        public static int RndEnemyNumber;


    }
    class FallenCreator
    {
        public void Fallen()
        {
            Enemies.EnemyBaseHealth = 50;
            Enemies.EnemyBaseAttack = 10;
            Enemies.EnemyBaseDefence = 1;
            Enemies.EnemyBaseDamage = 1;
            Enemies.EnemyBaseHitChance = 20;
            Enemies.EnemyBaseArmor = 1;
            Enemies.EnemyBaseCritChance = 1;
            Enemies.EnemyBaseCritDamage = 1;
            Enemies.EnemyXpToGive = 10;
            Enemies.EnemyGoldToGive = 5;
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
            Enemies.EnemyBaseHitChance = 20;
            Enemies.EnemyBaseArmor = 1;
            Enemies.EnemyBaseCritChance = 1;
            Enemies.EnemyBaseCritDamage = 1;
            Enemies.EnemyXpToGive = 10;
            Enemies.EnemyGoldToGive = 10;

        }
    }
    class NewEnemy
    {
        public static void Randomizer()
        {
            //Random RndEnemy = new Random();
            //int EnemyNumber = RndEnemy.Next(0, 1);
            RndEnemy.RndNumber();
            if (Enemies.RndEnemyNumber == 0)
            {
                FallenCreator Fallen = new FallenCreator();
                Fallen.Fallen();
                Console.WriteLine("Fallen");
                //return EnemyNumber;
            }
            else if (Enemies.RndEnemyNumber == 1)
            {
                TaintedCreator Tainted = new TaintedCreator();
                Tainted.Tainted();
                Console.WriteLine("Tainted");
                //return EnemyNumber;
            }
            //else { return EnemyNumber; }
        }
    }
    class SetEnemyValues
    {
        public static void EnemyValueSetter()
        {
            Enemies.EnemyTotalDamage = Enemies.EnemyBaseDamage + Enemies.EnemyWeaponDamageModifier;
            Enemies.EnemyTotalDefence = Enemies.EnemyBaseDefence + Enemies.EnemyArmorModifier;
            Enemies.EnemyTotalHitChance = (Enemies.EnemyBaseHitChance + Enemies.EnemyHitChanceModifier);
        }
    }
    class RndEnemy
    {
        public static void RndNumber()
        {
            Random RndEnemyNumber = new Random();
            Enemies.RndEnemyNumber = RndEnemyNumber.Next(0, 1);
            
        }
    }
}   
