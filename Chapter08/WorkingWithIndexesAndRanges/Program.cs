using System;
using static System.Console;

namespace WorkingWithIndexesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            var i1 = new Index(value: 3);
            var i2 = 3;
            var i3 = new Index(value: 5, fromEnd: true);
            var i4 = ^5;

            Range r1 = new Range(start: new Index(3), end: new Index(7));
            Range r2 = new Range(start: 3, end: 7);
            Range r3 = 3..7;
            Range r4 = Range.StartAt(3);
            Range r5 = 3..;
            Range r6 = Range.EndAt(3);
            Range r7 = ..3;

            string name = "Samantha Jones";
            int indexOfSpace = name.IndexOf(' ');
            string firstName = name.Substring(startIndex: 0, length: indexOfSpace);
            string lastName = name.Substring(startIndex: name.Length - (name.Length - indexOfSpace - 1), length: name.Length - indexOfSpace - 1);

            WriteLine($"First name: {firstName}, Last name: {lastName}");

            ReadOnlySpan<char> nameAsSpan = name.AsSpan();
            var firstNameSpan = nameAsSpan[0..firstName.Length];
            var lastNameSpan = nameAsSpan[^lastName.Length..^0];
            WriteLine("First name: {0}, Last name: {1}",
                arg0: firstNameSpan.ToString(),
                arg1: lastNameSpan.ToString());
        }
    }
}
