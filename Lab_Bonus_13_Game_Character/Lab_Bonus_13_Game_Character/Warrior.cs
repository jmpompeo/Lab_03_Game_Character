using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Bonus_13_Game_Character
{
    public class Warrior : GameCharacter
    {
        public Warrior(string name, int strength, int intelligence, string weaponType) : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public string WeaponType { get; }
        public override void Play()
        {
            Console.WriteLine($"This character's name is {Name} + his/her strength is {Strength} + their intelligence is {Intelligence} + this warrior uses {WeaponType} as his/her preferred weapon. ");
        }
    }
}
