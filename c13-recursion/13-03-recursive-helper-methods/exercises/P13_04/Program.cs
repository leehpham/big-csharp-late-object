using System;

namespace P13_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("a quick brown fox", 4, 9));
            Console.WriteLine(Reverse("a quick brown fox", 0, 6));
            Console.WriteLine(Reverse("a quick brown fox", 8, 6));
        }

        public static string Reverse(string text, int start, int end)
        {
            if (start >= end) return text[start].ToString();
            else
            {
                return Reverse(text, start + 1, end) + text[start];
            }
        }
    }
}
