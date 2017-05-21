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
        public static int EnemyBaseCritChance { get; set; }
        public static int EnemyBaseCritDamage { get; set; }
        //ValueModifiers
        public static int EnemyWeaponDamageModifier { get; set; }
        public static int EnemyWeaponAttackModifier { get; set; }
        public static int EnemyArmorModifier { get; set; }
    
    }
    class FallenCreator
    {
        public void Fallen()
        {
            Enemies.EnemyBaseAttack = 1;
            Enemies.EnemyBaseDefence = 1;
            Enemies.EnemyBaseDamage = 1;
            Enemies.EnemyBaseHitChance = 1;
            Enemies.EnemyBaseArmor = 1;
            Enemies.EnemyBaseCritChance = 1;
            Enemies.EnemyBaseCritDamage = 1;
        }
    }
}   
