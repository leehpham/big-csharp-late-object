﻿using System;
using System.Collections.Generic;

namespace P13_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = GenerateSubstrings("hello");
            foreach(var str in result)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("*****");
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
