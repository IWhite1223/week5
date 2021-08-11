using System;
using System.Collections.Generic;

namespace Lab5._1_RPG
{
    class Program
    {
           
         
        static void Main(string[] args)
        {
            List<GameCharacter> characterDirectory = new List<GameCharacter>();
            
            
            Warrior W1 = new Warrior();
            W1.cName = "Drogo the Great";
            W1.cStrength = 10;
            W1.cIntelligence = 7;
            characterDirectory.Add(W1);
            

            Warrior W2 = new Warrior();
            W2.cName = "Cicely the Devourer";
            W2.cStrength = 8;
            W2.cIntelligence = 6;
            characterDirectory.Add(W2);

            Wizard M1 = new Wizard();
            M1.cName = "Maria";
            M1.cStrength = 4;
            M1.cIntelligence = 10;
            characterDirectory.Add(M1);

            Wizard M2 = new Wizard();
            M2.cName = "Lanya";
            M2.cStrength = 5;
            M2.cIntelligence = 8;
            M2.cMagicalEnergy = 9;
            M2.cSpellNumber = 10;
            characterDirectory.Add(M2);
            

            Wizard M3 = new Wizard();
            M3.cName = "Arth";
            M3.cStrength = 3;
            M3.cIntelligence = 7;
            M3.cMagicalEnergy = 5;
            M3.cSpellNumber = 6;
            characterDirectory.Add(M3);




            foreach (var character in characterDirectory)
            {
                character.Play();
            }



        }
    }
}
