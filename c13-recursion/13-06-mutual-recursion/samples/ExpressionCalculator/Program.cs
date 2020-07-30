using System;

namespace ExpressionCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an expression: ");
            string input = Console.ReadLine();
            Evaluator e = new Evaluator(input);
            int value = e.GetExpressionValue();
            Console.WriteLine($"{input}={value}");
        }
    }
}
