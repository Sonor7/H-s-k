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
        public static int BaseCritDamage { get; set; }
        //ValueModifiers
        public static int WeaponDamageModifier { get; set; }
        public static int WeaponAttackModifier { get; set; }
        public static int ArmorModifier { get; set; }
        //String Values
        public static string Name;


        public static void Champion()
        {
            
        }
    }
    class BarbarianCreator
    {
        public void Barbarian()
        {
            Champions.BaseAttack = 1;
            Champions.BaseDefence = 1;
            Champions.BaseDamage = 1;
            Champions.BaseHitChance = 1;
            Champions.BaseArmor = 1;
            Champions.BaseCritChance = 1;
            Champions.BaseCritDamage = 1;
            Champions.Name = "Béla";

        }
    }
}
