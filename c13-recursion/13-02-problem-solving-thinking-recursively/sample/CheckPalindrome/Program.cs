using System;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Madam, I'm Adam"));
            Console.WriteLine(IsPalindrome("Hoang Pham"));
            Console.WriteLine(IsPalindrome(""));
            Console.WriteLine(IsPalindrome("H"));
            Console.WriteLine(IsPalindrome("olo @"));
            Console.WriteLine(IsPalindrome("@ olo"));
            Console.WriteLine(IsPalindrome("@ olo !"));
        }

        public static bool IsPalindrome(string text)
        {
            int length = text.Length;

            // Separate case for shortest strings.
            if (length <= 1) { return true; }
            else
            {
                // Get first and last characters, converted to lowercase.
                char first = char.ToLower(text[0]);
                char last = char.ToLower(text[length - 1]);

                if (char.IsLetter(first) && char.IsLetter(last))
                {
                    // Both are letters.
                    if (first == last)
                    {
                        // Remove both first and last character.
                        string shorter = text.Substring(1, length - 2);
                        return IsPalindrome(shorter);
                    }
                    else 
                    {
                        return false;
                    }
                }
                else if (!char.IsLetter(last))
                {
                    // Remove last character.
                    string shorter = text.Substring(0, length - 1);
                    return IsPalindrome(shorter);
                }
                else
                {
                    // Remove first character.
                    string shorter = text.Substring(1);
                    return IsPalindrome(shorter);
                }
            }
        }
    }
}
