using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hősök
{
    class Items// Ide jön minden, ami minden tárgyhoz kapcsolódik. Az egyes tárgyak külön classokban lesznek. Mielőtt felvesz egy fegyvert, "leteszi" a másikat alapból. Ez jelenleg kiír valamit, 
               //de ez főleg debug célból van. Armor ugyanez. 
    {
        //Minden tárgyról külön nyilvántartjuk, hogy hány van belőle
        public static int SwordCount = 1;
        public static int LeatherArmorCount = 1;

        public static void EquipSword()
        {
            if (Items.SwordCount > 0)
            {
                UnEquipWeapon();
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
                UnEquipArmor();
                Champions.ArmorModifier = LeatherArmor.LeatherArmorMod;
                Console.WriteLine("You have equipped a leather armor");
            }else { Console.WriteLine("You don't have a Leather Armor"); }
        }
        public static void UnEquipWeapon()
        {

            Champions.WeaponDamageModifier = 0;
            Champions.WeaponHitChanceModifier = 0;
            Champions.CritChanceModifier = 0;
            Champions.CritDamageModifier = 0;

            Console.WriteLine("You have unequipped your weapon");

        }
        public static void UnEquipArmor()
        {
            Champions.ArmorModifier = 0;
            Console.WriteLine("You have unequiped your armor");
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
