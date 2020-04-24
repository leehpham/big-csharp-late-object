using System;

namespace P13_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Hello World!"));
        }

        public static string Reverse(string text)
        {
            var reversedText = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            return reversedText;
        }
    }
}
