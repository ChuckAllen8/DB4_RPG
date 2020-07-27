using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RPG
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; private set; }

        public Wizard(string name, int strength, int intelligence, int energy, int spells) : base(name, strength, intelligence, energy)
        {
            SpellNumber = spells;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n{SpellNumber} spell{(SpellNumber == 1 ? "" : "s")}.";
        }

        public override void Play()
        {
            Console.WriteLine(this);
        }
    }
}
