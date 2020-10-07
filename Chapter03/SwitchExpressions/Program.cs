using System;
using static System.Console;
namespace SwitchExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = (new Random()).Next(1, 7);
            var message = s switch
            {
                1 => "One",
                2 => "Two",
                _ => "Default"
            };
            WriteLine(s);
            WriteLine(message);
        }
    }
}
