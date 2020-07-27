using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RPG
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; protected set; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int energy) : base(name, strength, intelligence)
        {
            MagicalEnergy = energy;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Magic: {MagicalEnergy}";
        }

        public override void Play()
        {
            Console.WriteLine(this);
        }
    }
}
