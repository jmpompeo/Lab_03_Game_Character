using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Bonus_13_Game_Character
{
    public class GameCharacter
    {
        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }
        public string Name { get;}
        public int Strength { get;}
        public int Intelligence { get; }

        public virtual void Play()
        {
            Console.WriteLine($"This character's name is {Name} + his/her strength is {Strength} + their intelligence is {Intelligence} ");
        }
    }
}
