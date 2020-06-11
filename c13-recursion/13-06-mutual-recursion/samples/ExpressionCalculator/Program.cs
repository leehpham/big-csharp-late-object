using System;

namespace ExpressionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokenizer = new ExpressionTokenizer("123+45");
            Console.WriteLine(tokenizer.NextToken());
        }
    }
}
