using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RPG
{
    class GameCharacter
    {
        private string homeCountry;
        public string Name { get; protected set; }
        public string Title { get; set; }
        public string Country
        { 
            get { return homeCountry; }
            set
            { //can only be set once
                if((homeCountry == null || homeCountry == ""))
                {
                    homeCountry = value;
                }
            }
        }
        public int Strength { get; protected set; }
        public int Intelligence { get; protected set; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public override string ToString()
        {
            return $"{(Title == null ? "" : $"{Title} ")}{Name} {( Country != null ? (Country == "Deutscheland" ? "von " : "of ") + Country : "")}\n" +
                $"Str: {Strength} | Int: {Intelligence}";
        }

        public virtual void Play()
        {
            Console.WriteLine(this);
        }
    }
}
