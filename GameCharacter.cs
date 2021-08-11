using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1_RPG
{
    class GameCharacter
    {
       public string cName;
       public int cStrength;
       public int cIntelligence;

        public GameCharacter(string name, int strength, int intelligence)
        {
            cName = name;
            cStrength = strength;
            cIntelligence = intelligence;
        }

        public GameCharacter()
        {
            cName = "";
            cStrength = 0;
            cIntelligence = 0;
            
        }

        public virtual void Play()
        {
            string player = $"Name: {cName}\n";
            player += $"Stength: {cStrength}\n";
            player += $"Intelligence: {cIntelligence}\n";
            Console.WriteLine(player);

        }
        


    }

}
