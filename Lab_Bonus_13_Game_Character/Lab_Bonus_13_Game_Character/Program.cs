using System;


namespace Lab_Bonus_13_Game_Character
{
    class Program

        
    {
        static void Main(string[] args)
        {
            var warrior1 = new Warrior("Jeff", 50, 75, "Crossbow");
            var warrior2 = new Warrior("Jeremy", 100, 80, "Glock");
            var wizard1 = new Wizard("Heimdall", 250, 500, 300, 7);
            var wizard2 = new Wizard("Thor", 500, 175, 450, 8);
            var wizard3 = new Wizard("Loki", 300, 500, 300, 3);

            var gameCharacters = new GameCharacter[5] { warrior1, warrior2, wizard1, wizard2, wizard3 };

            var characterCount = 1;

            foreach (var character in gameCharacters)
            {
                Console.WriteLine($"{characterCount}");
                character.Play();
                characterCount++;
            }
            

        }

        

        
        
    }
}
