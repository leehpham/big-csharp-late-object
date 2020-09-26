using System;

namespace P13_16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Evaluator e = new Evaluator("1+5*2^(3+4)-10%4");
            int value = e.GetExpressionValue();
            if (value == 639) Console.WriteLine("Passed!");

            // TODO: Add more test cases if could think of!
        }
    }
}
