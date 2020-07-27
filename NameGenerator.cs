using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesPractice
{
    public enum NameOf
    {
        First,
        Last,
        Title,
        Homeland,
        Equipment
    }

    class NameGenerator
    {
        private static readonly NameGenerator service = new NameGenerator();
        private readonly Random indexer;

        private List<string> firstNames;
        private List<string> lastNames;
        private List<string> titles;
        private List<string> countries;
        private List<string> equipment;

        private NameGenerator()
        {
            indexer = new Random();

            firstNames = new List<string>();
            lastNames = new List<string>();
            titles = new List<string>();
            countries = new List<string>();
            equipment = new List<string>();

            FillFirst();
            FillLast();
            FillTitles();
            FillCountries();
            FillEquipment();
        }

        private void FillTitles()
        {
            titles.Add("Lady");
            titles.Add("Lord");
            titles.Add("Baron");
            titles.Add("Baroness");
            titles.Add("Queen");
            titles.Add("King");
            titles.Add("Prince");
            titles.Add("Princess");
        }

        private void FillCountries()
        {
            countries.Add("Deutscheland");
            countries.Add("Wallachia");
            countries.Add("England");
            countries.Add("Spain");
            countries.Add("Ireland");
            countries.Add("Wales");
        }

        private void FillEquipment()
        {
            equipment.Add("Short Sword");
            equipment.Add("Long Sword");
            equipment.Add("Claymore");
            equipment.Add("Battle Axe");
            equipment.Add("Long Bow");
            equipment.Add("Crossbow");
            equipment.Add("Glaive");
            equipment.Add("Compound Bow");
        }

        private void FillFirst()
        {
            firstNames.Add("Tnarg");
            firstNames.Add("Ellie");
            firstNames.Add("Burt");
            firstNames.Add("Katerina");
            firstNames.Add("Nicklaus");
            firstNames.Add("Derick");
            firstNames.Add("Erick");
            firstNames.Add("Alessia");
            firstNames.Add("Kai");
            firstNames.Add("Cels");
            firstNames.Add("Kourt");
            firstNames.Add("Abel");
            firstNames.Add("Meeki-el");
            firstNames.Add("Persephone");
            firstNames.Add("Karen");
            firstNames.Add("Imoha");
        }

        private void FillLast()
        {
            lastNames.Add("Firecaller");
            lastNames.Add("Shieldbreaker");
            lastNames.Add("Oakenshield");
            lastNames.Add("Baggins");
            lastNames.Add("Coppertongue");
            lastNames.Add("Nightwalker");
        }

        public static NameGenerator GetNameGenerator()
        {
            return service;
        }

        public string Next(NameOf name)
        {
            switch (name)
            {
                case NameOf.First:
                    return NextFirst();
                case NameOf.Last:
                    return NextLast();
                case NameOf.Title:
                    return NextTitle();
                case NameOf.Homeland:
                    return NextHomeland();
                case NameOf.Equipment:
                    return NextEquipment();
                default:
                    return NextAnything();
            }
        }

        private string NextFirst()
        {
            return firstNames[indexer.Next(firstNames.Count)];
        }

        private string NextLast()
        {
            return lastNames[indexer.Next(lastNames.Count)];
        }

        private string NextTitle()
        {
            return titles[indexer.Next(titles.Count)];
        }

        private string NextHomeland()
        {
            return countries[indexer.Next(countries.Count)];
        }

        private string NextEquipment()
        {
            return equipment[indexer.Next(equipment.Count)];
        }

        private string NextAnything()
        {
            switch (indexer.Next(5))
            {
                case 0:
                    return firstNames[indexer.Next(firstNames.Count)];
                case 1:
                    return lastNames[indexer.Next(lastNames.Count)];
                case 2:
                    return titles[indexer.Next(titles.Count)];
                case 3:
                    return countries[indexer.Next(countries.Count)];
                case 4:
                    return equipment[indexer.Next(equipment.Count)];
            }
            return "";
        }
    }
}
