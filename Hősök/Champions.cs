using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök //Attack,defence,hit chance,armor, weapons and modifiers, skills and spells, crit chance, crit dmg, base dmg
{               //A newly created hero should modify the public values, so 1 value can be used for any champ
    class Champions
    {
        //BaseValues
        //public static int BaseAttack;
        public static int BaseDefence;
        public static int BaseDamage;
        public static int BaseHitChance;
        public static int BaseArmor;
        public static int BaseCritChance;
        public static int BaseHealth;
        public static int XP;
        public static int ChampionLevel;
        public static int GoldAmount;
        //ValueModifiers
        public static int WeaponDamageModifier;
       // public static int WeaponAttackModifier;
        public static int ArmorModifier;
        public static int HealthModifiers;
        public static int WeaponHitChanceModifier;
        public static int CritChanceModifier;
        public static int CritDamageModifier;//amivel megszorzom a dmg-t h megkapjam a crit dmg-t
        //String Values
        public static string Name;
        //TotalValues
        public static int TotalDamage = BaseDamage + WeaponDamageModifier;
        public static int TotalDefence = BaseDefence + ArmorModifier;
        public static int TotalHealth = BaseHealth + HealthModifiers;
        public static int TotalHitChance = BaseHitChance + WeaponHitChanceModifier;
        public static int TotalCritChance = BaseCritChance + CritChanceModifier;

        public static void Champion()
        {
            
        }
    }
    class BarbarianCreator
    {
        public void Barbarian()
        {
            Champions.BaseHealth = 100;
            //Champions.BaseAttack = 10;
            Champions.BaseDefence = 1;
            Champions.BaseDamage = 10;
            Champions.BaseHitChance = 20;
            Champions.BaseArmor = 1;
            Champions.BaseCritChance = 10;
            Champions.CritDamageModifier = 2;
            Champions.Name = "Béla";

        }
    }
    class SetChampionValues
    {
        public static void ChampionValueSetter()
        {
            Champions.TotalDamage = Champions.BaseDamage + Champions.WeaponDamageModifier;
            Champions.TotalDefence = Champions.BaseDefence + Champions.ArmorModifier;
            Champions.TotalHealth = Champions.BaseHealth + Champions.HealthModifiers;
            Champions.TotalHitChance = Champions.BaseHitChance + Champions.WeaponHitChanceModifier;
            Champions.TotalCritChance = Champions.BaseCritChance + Champions.CritChanceModifier;
        }
    }
}
