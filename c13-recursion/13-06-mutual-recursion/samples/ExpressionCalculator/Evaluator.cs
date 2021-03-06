using System;

namespace ExpressionCalculator
{
    /// <summary>
    /// A class that can computes the value of an arithmetic expression.
    /// </summary>
    public class Evaluator
    {
        private ExpressionTokenizer tokenizer;

        /// <summary>
        /// Constructs an evaluator.
        /// </summary>
        /// <param name="anExpression">a string containing the expression to be evaluated.</param>
        public Evaluator(string anExpression)
        {
            tokenizer = new ExpressionTokenizer(anExpression);
        }

        /// <summary>
        /// Evaluates the expression.
        /// </summary>
        /// <returns>The value of the expression.</returns>
        public int GetExpressionValue()
        {
            int value = GetTermValue();
            bool done = false;
            while (!done)
            {
                string next = tokenizer.PeekToken();
                if ("+".Equals(next) || "-".Equals(next))
                {
                    tokenizer.NextToken(); // Discard "+" or "-"
                    int value2 = GetTermValue();
                    if ("+".Equals(next)) { value = value + value2; }
                    else { value = value - value2; }
                }
                else
                {
                    done = true;
                }
            }
            return value;
        }

        /// <summary>
        /// Evaluates the next term found in the expression.
        /// </summary>
        /// <returns>The value of the term.</returns>
        public int GetTermValue()
        {
            int value = GetFactorValue();
            bool done = false;
            while (!done)
            {
                string next = tokenizer.PeekToken();
                if ("*".Equals(next) || "/".Equals(next))
                {
                    tokenizer.NextToken();
                    int value2 = GetFactorValue();
                    if ("*".Equals(next)) { value = value * value2; }
                    else { value = value / value2; }
                }
                else
                {
                    done = true;
                }
            }
            return value;
        }

        /// <summary>
        /// Evaluates the next factor found in the expression.
        /// </summary>
        /// <returns></returns>
        public int GetFactorValue()
        {
            int value;
            string next = tokenizer.PeekToken();
            if ("(".Equals(next))
            {
                tokenizer.NextToken(); // Discard "("
                value = GetExpressionValue();
                tokenizer.NextToken(); // Discard ")"
            }
            else
            {
                value = Int32.Parse(tokenizer.NextToken());
            }
            return value;
        }
    }
}