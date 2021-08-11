using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1_RPG
{
    class Warrior : GameCharacter
    {
        public string cWeaponType;

        public Warrior(string weaponType)
        {
            cWeaponType = weaponType;
        }

        public Warrior()
        {
            cName = "";
            cStrength = 0;
            cIntelligence = 0;
            cWeaponType = "";
        }

        public override void Play()
        {

            string player = $"Name: {cName}\n";
            player += $"Stength: {cStrength}\n";
            player += $"Intelligence: {cIntelligence}\n";
            player += $"Weapon Type: {cWeaponType}\n";
            Console.WriteLine(player);
            

        }
    }
}
