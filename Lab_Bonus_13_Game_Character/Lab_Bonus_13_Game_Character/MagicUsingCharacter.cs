using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Bonus_13_Game_Character
{
    public class MagicUsingCharacter : GameCharacter
    {
        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public int MagicalEnergy { get; }
        public override void Play()
        {
            Console.WriteLine($"This character's name is {Name} + his/her strength is {Strength} + their intelligence is {Intelligence} + this character's magical energy is {MagicalEnergy}");
        }
    }
}
