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
        public static int BaseAttack { get; set; }
        public static int BaseDefence { get; set; }
        public static int BaseDamage { get; set; }
        public static int BaseHitChance { get; set; }
        public static int BaseArmor { get; set; }
        public static int BaseCritChance { get; set; }
        public static int BaseHealth;
        //ValueModifiers
        public static int WeaponDamageModifier { get; set; }
        public static int WeaponAttackModifier { get; set; }
        public static int ArmorModifier { get; set; }
        public static int HealthModifiers;
        public static int HitChanceModifier;
        public static int CritChanceModifier;
        public static int CritDamageModifier { get; set; }//amivel megszorzom a dmg-t h megkapjam a crit dmg-t
        //String Values
        public static string Name;
        //TotalValues
        public static int TotalDamage = BaseDamage + WeaponDamageModifier;
        public static int TotalDefence = BaseDefence + ArmorModifier;
        public static int TotalHealth = BaseHealth + HealthModifiers;
        public static int TotalHitChance = BaseHitChance + HitChanceModifier;
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
            Champions.BaseAttack = 10;
            Champions.BaseDefence = 1;
            Champions.BaseDamage = 15;
            Champions.BaseHitChance = 10;
            Champions.BaseArmor = 1;
            Champions.BaseCritChance = 1;
            Champions.CritDamageModifier = 1;
            Champions.Name = "Béla";

        }
    }
}
