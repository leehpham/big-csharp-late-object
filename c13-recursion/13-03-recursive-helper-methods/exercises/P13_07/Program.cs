using System;

namespace P13_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IndexOf("Mississippi", "Hoang"));
        }

        public static int IndexOf(string text, string str)
        {
            return IndexOf(text, 0, str);
        }

        public static int IndexOf(string text, int start, string str)
        {
            if (start + str.Length > text.Length) return -1;
            else
            {
                if (text.Substring(start, str.Length) == str) return start;
                else
                {
                    return IndexOf(text, start + 1, str);
                }
            }
        }
    }
}
