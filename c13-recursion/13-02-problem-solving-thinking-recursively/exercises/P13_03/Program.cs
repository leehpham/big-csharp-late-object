using System;

namespace P13_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(""));
            Console.WriteLine(Reverse("H"));
            Console.WriteLine(Reverse("I'm handsome!"));
        }

        public static string Reverse(string text)
        {
            if (text.Length <= 1)
            {
                return text;
            }
            else
            {
                var firstChar = text[0];
                var smallerText = text.Substring(1);
                var output = Reverse(smallerText) + firstChar;
                return output;
            }
        }
    }
}
