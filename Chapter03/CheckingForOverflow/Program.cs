using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int x = int.MaxValue - 1;
                WriteLine($"Initial value: {x}");
                x++;
                WriteLine($"After incrementing: {x}");
                x++;
                WriteLine($"After incrementing: {x}");
                x++;
                WriteLine($"After incrementing: {x}");
            }
        }
    }
}
