﻿using System;
using System.IO;
using static System.Console;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("There are no arguments.");
            }
            else
            {
                WriteLine("There is at least one argument.");
            }

            object o = "3";
            int j = 4;
            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }

        A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break;
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or Four");
                    goto case 1;
                case 5:
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            }
            // string path = "D:/Users/pkdar/Desktop/Cs/Chapter03/SelectionStatements"
            string path = @"D:\Users\pkdar\Desktop\Cs\Chapter03\SelectionStatements";
            Stream s = File.Open(Path.Combine(path, "SelectionStatements.csproj"), FileMode.OpenOrCreate);
            string message = string.Empty;

            switch (s)
            {
                case FileStream writableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only file.";
                    break;
                case MemoryStream memoryStream:
                    message = "The stream is a memory address.";
                    break;
                default:
                    message = "The stream is some other type";
                    break;
                case null:
                    message = "The stream is null";
                    break;
            }

            WriteLine(message);
        }

    }
}
