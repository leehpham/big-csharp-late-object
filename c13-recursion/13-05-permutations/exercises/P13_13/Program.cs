using System;
using System.Collections.Generic;

namespace P13_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = GenerateSubsets("temp");
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine($"Count: {result.Count}");
            Console.WriteLine("*****");
        }

        public static List<string> GenerateSubsets(string input)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var subStrs = GenerateSubstrings(input.Substring(i + 1));
                foreach (var str in subStrs)
                {
                    result.Add(input[i] + str);
                }
            }
            result.Add("");
            return result;
        }

        public static List<string> GenerateSubstrings(string input)
        {
            List<string> result = new List<string>();

            if (input.Length == 0)
            {
                result.Add(input);
                return result;
            }
            else
            {
                for (int i = 1; i <= input.Length; i++)
                {
                    result.Add(input.Substring(0, i));
                }
                result.AddRange(GenerateSubstrings(input.Substring(1)));
                return result;
            }
        }
    }
}
