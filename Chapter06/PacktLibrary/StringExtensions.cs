using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace PacktLibrary
{
    public static class StringExtensions
    {
        public static bool IsValidEmail(this string input)
        {
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.\A-_]+@[a-zA-Z0-9\.\A-_]+");
        }
    }
}