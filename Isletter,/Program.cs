using System;
using System.Text.RegularExpressions;

namespace Isletter_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Anar bas dasw m edrwq";
            bool a = HasLetter(text, "m");
            Console.WriteLine(a);
        }
        static bool HasLetter(string text, string word)
        {
            bool isLetter = false;
            if (Regex.IsMatch(text, @"\b" + word + @"\b"))
            {
                isLetter = true;
            }
            return isLetter;
        }
    }
}
