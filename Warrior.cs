using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RPG
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; private set; }
        public Warrior(string name, int strength, int intelligence, string weapon) : base(name, strength, intelligence)
        {
            WeaponType = weapon;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n{WeaponType}";
        }

        public override void Play()
        {
            Console.WriteLine(this);
        }
    }
}
