using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : Object
    {
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        public string Name;
        public DateTime DateOfBirth;
        public const string Species = "Homo Sapien";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public override string ToString()
        {
            return "OK";
        }
    }
}
