using System;

namespace Packt.Shared
{
    public class Person: Object
    {
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public string Name;
        public DateTime DateOfBirth;
        public override string ToString() {
            return "OK";
        }
    }
}
