using System;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("aba aba"));
        }

        public static bool IsPalindrome(string text)
        {
            return IsPalindrome(text, 0, text.Length - 1);
        }

        /// <summary>
        /// Tests whether a substring is a palindrome.
        /// </summary>
        /// <param name="text">A string that is being checked.</param>
        /// <param name="start">the index of the first character of the substring.</param>
        /// <param name="end">the index of the last character of the substring.</param>
        /// <returns>True if the substring is a palindrome.</returns>
        public static bool IsPalindrome(string text, int start, int end)
        {
            // Separate case for substrings of length 0 and 1.
            if (start >= end) { return true; }
            else
            {
                // Get first and last characters, converted to lowercase. 
                char first = char.ToLower(text[start]);
                char last = char.ToLower(text[end]);

                if (char.IsLetter(first) && char.IsLetter(last))
                {
                    if (first == last)
                    {
                        // Test substring that doesn't contain the last character.
                        return IsPalindrome(text, start + 1, end - 1);
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (!char.IsLetter(last))
                {
                    // Test substring that doesn't contain the last character.
                    return IsPalindrome(text, start, end - 1);
                }
            }
            return false;
        }
    }
}
