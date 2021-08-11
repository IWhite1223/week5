using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1_RPG
{
    class Wizard : MagicUsingCharacter 
    {
        public int cSpellNumber;

        public Wizard()
        {
            cName = "";
            cStrength = 0;
            cIntelligence = 0;
            cMagicalEnergy = 0;
            cSpellNumber = 0;

        }
        public Wizard(int spellNumber)
        {
            cSpellNumber = spellNumber;
        }
        public override void Play()
        {
            string player = $"Name: {cName}\n";
            player += $"Stength: {cStrength}\n";
            player += $"Intelligence: {cIntelligence}\n";
            player += $"MagicalEnergy: {cMagicalEnergy}\n";
            player += $"Number of Spells: {cSpellNumber}\n";
            Console.WriteLine(player);
        }
    }
}
