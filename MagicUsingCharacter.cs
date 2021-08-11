using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1_RPG
{
    class MagicUsingCharacter : GameCharacter
    {
        public int cMagicalEnergy;

        public MagicUsingCharacter (int magicalEnergy)
        {
            cMagicalEnergy = magicalEnergy;

        }
        public MagicUsingCharacter()
        {
            cName = "";
            cStrength = 0;
            cIntelligence = 0;
            cMagicalEnergy = 0;
        }

        public override void Play()
        {

            Console.WriteLine($"Magical Energy: {cMagicalEnergy}\n"); 
        }
         

    }
}
