using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }
            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(ReadLine(), out byte number);
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }
        /// <summary>
        /// Pass a integer number and recurse
        /// </summary>
        /// <param name="number">A number you need to factorial</param>
        /// <returns>Factorial of the number</returns>
        static int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
        /// <summary>
        /// Read a number from keyboard and pass to Factorial function
        /// </summary>
        static void RunFactorial()
        {
            bool isNumber;
            do
            {
                Write("Enter a number: ");

                isNumber = int.TryParse(ReadLine(), out int number);

                if (isNumber)
                {
                    WriteLine($"{number:N0}! = {Factorial(number):N0}");
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while(isNumber);
        }

        static void Main(string[] args)
        {
            RunTimesTable();
        }
    }
}
