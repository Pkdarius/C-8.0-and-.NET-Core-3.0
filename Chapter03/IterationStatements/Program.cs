using System;
using System.Collections;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Adam", "Barry", "Charlie"};

            foreach(string name in names) {
                WriteLine($"{name} has {name.Length} characters.");
            }

            IEnumerator e = names.GetEnumerator();
            while (e.MoveNext()) {
                string name = (string) e.Current;
                WriteLine($"{name} has {name.Length} characters");
            }
        }
    }
}
