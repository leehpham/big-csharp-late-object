using System;

namespace P13_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Find("", "me"));
            Console.WriteLine(Find("me", ""));
            Console.WriteLine(Find("b", "h"));
            Console.WriteLine(Find("b", "b"));
            Console.WriteLine(Find("Hoang Pham", "g P"));
            Console.WriteLine(Find("Hoang Pham", "z"));
        }

        public static bool Find(string text, string str)
        {
            if (text.Length < str.Length)
            {
                return false;
            }
            else if (str.Length == 0 || text.Length == 0)
            {   
                return false;
            }
            else if (text.Length == 1 && str.Length == 1 && text[0] != str[0]) 
            {
                return false;
            }
            else 
            {
                var textStartStr = text.Substring(0, str.Length);
                if (textStartStr == str)
                {
                    return true;
                }
                else
                {
                    return Find(text.Substring(1), str);
                }
            }
        }
    }
}
