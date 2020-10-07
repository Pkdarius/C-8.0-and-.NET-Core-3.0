#nullable enable

using System;
using static System.Console;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compile error!
            // int? thisCouldBeNull = null;
            // WriteLine(thisCouldBeNull);
            // WriteLine(thisCouldBeNull.GetValueOrDefault());
            // thisCouldBeNull = 7;
            // WriteLine(thisCouldBeNull);
            // WriteLine(thisCouldBeNull.GetValueOrDefault());

            // var address = new Address();
            // address.Building = null;
            // address.Street = null;
            // address.City = "London";
            // address.Region = null;

            // int numberOfApples = 12;
            // decimal pricePerApple = 0.35M;

            // WriteLine(
            //     format: "{0} apples costs {1:C}",
            //     arg0: numberOfApples,
            //     arg1: pricePerApple * numberOfApples
            // );

            // string formatted = string.Format(
            //     format: "{0} apples costs {1:C}",
            //     arg0: numberOfApples,
            //     arg1: pricePerApple * numberOfApples
            // );

            // WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            // string applesText = "Apples";
            // int applesCount = 1234;
            // string bananasText = "Bananas";
            // int bananasCount = 56789;

            // WriteLine(
            //     format: "{0, -8} {1,6:N0}",
            //     arg0: "Name",
            //     arg1: "Count"
            // );
            // WriteLine(
            //     format: "{0,-8} {1,6:N0}",
            //     arg0: applesText,
            //     arg1: applesCount
            // );

            // WriteLine(
            //  format: "{0,-8} {1,6:N0}",
            //  arg0: bananasText,
            //  arg1: bananasCount
            // );

            // Write("Type your first name and press ENTER: ");
            // string firstName = ReadLine();
            // Write("Type your age nad press ENTER: ");
            // string age = ReadLine();
            // WriteLine($"Hello {firstName}, you look good for {age}.");

            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifier: {key.Modifiers}");
        }
    }

    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
}
