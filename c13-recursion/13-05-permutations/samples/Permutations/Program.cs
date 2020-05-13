using System;
using System.Collections.Generic;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach (string s in Permutations("e"))
            // {
            //     Console.WriteLine(s);
            // }
            string str = "e";
            Console.WriteLine(str.Substring(1));
        }

        /// <summary>
        /// Gets all permutations of a given word.
        /// </summary>
        /// <param name="word">the string to permute.</param>
        /// <returns>a list of all permutations.</returns>
        public static List<string> Permutations(string word)
        {
            List<string> result = new List<string>();

            // The empty string has a single permutation: itself
            if (word.Length == 0)
            {
                result.Add(word);
                return result;
            }
            else
            {
                // Loop through all character positions
                for (int i = 0; i < word.Length; i++)
                {
                    // Form a shorter word by removing the ith character
                    string shorter = word.Substring(0, i) + word.Substring(i + 1);

                    // Generate all permutations of the simpler word
                    List<string> shorterPermutations = Permutations(shorter);

                    // Add the removed character to the front of
                    // each permutation of the simpler word.
                    foreach (string s in shorterPermutations)
                    {
                        result.Add(word[i] + s);
                    }
                }
            }
            return result;
        }
    }
}
