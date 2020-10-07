using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 3;
            // int b = a++;
            // WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c;
            WriteLine($"c is {c}, d is {d}");

            int e = 11;
            int f = 3;
            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g / f}");

            int p = 6;
            p += 3;
            p -= 3;
            p *= 3;
            p /= 3;

            bool a = true;
            bool b = false;
            WriteLine($"AND | a     | b ");
            WriteLine($"a   | {a & a,-5} | {a & b,-5} ");
            WriteLine($"b   | {b & a,-5} | {b & b,-5} ");
            WriteLine();
            WriteLine($"OR | a     | b ");
            WriteLine($"a   | {a | a,-5} | {a | b,-5} ");
            WriteLine($"b   | {b | a,-5} | {b | b,-5} ");
            WriteLine();
            WriteLine($"XOR | a     | b ");
            WriteLine($"a   | {a ^ a,-5} | {a ^ b,-5} ");
            WriteLine($"b   | {b ^ a,-5} | {b ^ b,-5} ");
            WriteLine();

            WriteLine($"a & DoStuff() = {a & DoStuff()}");
            WriteLine($"b & DoStuff() = {b & DoStuff()}");

            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");
        }

        private static bool DoStuff()
        {
            WriteLine("I am doing some stuff.");
            return true;
        }
    }
}
