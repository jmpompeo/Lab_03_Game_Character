using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Bonus_13_Game_Character
{
    public class Wizard : MagicUsingCharacter
    {
        

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber) : base(name, strength, intelligence, magicalEnergy)
        {
            SpellNumber = spellNumber;
        }
        public override void Play()
        {
            Console.WriteLine($"This character's name is {Name} + his/her strength is {Strength} + their intelligence is {Intelligence} + this character's magical energy is {MagicalEnergy} + he/she will use spell {SpellNumber}");
        }
    }
}
