using ClassesPractice;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RPG
{
    class RPG
    {
        List<GameCharacter> gameCharacters;
        NameGenerator gen = NameGenerator.GetNameGenerator();

        public void Run()
        {
            Random numbers = new Random();

            gameCharacters = new List<GameCharacter>()
            {
                new Warrior($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(8, 21), numbers.Next(4, 16), gen.Next(NameOf.Equipment)),
                new Warrior($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(8, 21), numbers.Next(4, 16), gen.Next(NameOf.Equipment)),
                new Warrior($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(8, 21), numbers.Next(4, 16), gen.Next(NameOf.Equipment)),
                new Warrior($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(8, 21), numbers.Next(4, 16), gen.Next(NameOf.Equipment)),
                new Warrior($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(8, 21), numbers.Next(4, 16), gen.Next(NameOf.Equipment)),
                new Warrior($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(8, 21), numbers.Next(4, 16), gen.Next(NameOf.Equipment)),
                new Warrior($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(8, 21), numbers.Next(4, 16), gen.Next(NameOf.Equipment)),
                new Warrior($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(8, 21), numbers.Next(4, 16), gen.Next(NameOf.Equipment)),
                new Warrior($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(8, 21), numbers.Next(4, 16), gen.Next(NameOf.Equipment)),
                new Warrior($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(8, 21), numbers.Next(4, 16), gen.Next(NameOf.Equipment)),
                new Wizard($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(4, 16), numbers.Next(8, 21), numbers.Next(50, 151), numbers.Next(4, 11)),
                new Wizard($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(4, 16), numbers.Next(8, 21), numbers.Next(50, 151), numbers.Next(4, 11)),
                new Wizard($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(4, 16), numbers.Next(8, 21), numbers.Next(50, 151), numbers.Next(4, 11)),
                new Wizard($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(4, 16), numbers.Next(8, 21), numbers.Next(50, 151), numbers.Next(4, 11)),
                new Wizard($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(4, 16), numbers.Next(8, 21), numbers.Next(50, 151), numbers.Next(4, 11)),
                new Wizard($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(4, 16), numbers.Next(8, 21), numbers.Next(50, 151), numbers.Next(4, 11)),
                new Wizard($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(4, 16), numbers.Next(8, 21), numbers.Next(50, 151), numbers.Next(4, 11)),
                new Wizard($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(4, 16), numbers.Next(8, 21), numbers.Next(50, 151), numbers.Next(4, 11)),
                new Wizard($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(4, 16), numbers.Next(8, 21), numbers.Next(50, 151), numbers.Next(4, 11)),
                new Wizard($"{gen.Next(NameOf.First)} {gen.Next(NameOf.Last)}", numbers.Next(4, 16), numbers.Next(8, 21), numbers.Next(50, 151), numbers.Next(4, 11))
            };

            for (int index = 0; index < gameCharacters.Count; index++)
            {
                gameCharacters[index].Country = gen.Next(NameOf.Homeland);

                if(numbers.Next(0, 100) <= 49)
                {
                    gameCharacters[index].Title = gen.Next(NameOf.Title);
                }
            }

            foreach(GameCharacter character in gameCharacters)
            {
                character.Play();
                Console.WriteLine();
            }
        }
    }
}
