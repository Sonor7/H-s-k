using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök
{
    class Items// Ide jön minden, ami minden tárgyhoz kapcsolódik. Az egyes tárgyak külön classokban lesznek.
    {
        //Minden tárgyról külön nyilvántartjuk, hogy hány van belőle
        public static int SwordCount = 1;
        public static int LeatherArmorCount = 1;

       public static void EquipSword()
        {
            if (Items.SwordCount > 0)
            {
                Champions.WeaponDamageModifier = Sword.SwordDamage;
                Champions.WeaponHitChanceModifier = Sword.SwordHitChance;
                Champions.CritChanceModifier = Sword.SwordCritChance;
                Champions.CritDamageModifier = Sword.SwordCritDmgModifier;

                Console.WriteLine("You have equipped a sword");
            }else { Console.WriteLine("You don't have a sword"); }
        }
       public static void EquipLeatherArmor()
        {
            if (Items.LeatherArmorCount > 0)
            {
                Champions.ArmorModifier = LeatherArmor.LeatherArmorMod;
                Console.WriteLine("You have equipped a leather armor");
            }else { Console.WriteLine("You don't have a Leather Armor"); }
        }
        public static void Equip(string ToEquip)
        {
            if (ToEquip == "Sword")
            {
                EquipSword();
            }
            else if(ToEquip == "LeatherArmor")
            {
                EquipLeatherArmor();
            }
        }

    }
    class Sword
    {
        public static int SwordDamage = 5;
        public static int SwordHitChance = 5;
        public static int SwordCritChance = 5;
        public static int SwordCritDmgModifier = 5;
        
    }
    class LeatherArmor
    {
        public static int LeatherArmorMod = 5;
    }
}
