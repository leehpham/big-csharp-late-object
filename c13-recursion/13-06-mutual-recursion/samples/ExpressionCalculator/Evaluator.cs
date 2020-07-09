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
        }

        /// <summary>
        /// Evaluates the next term found in the expression.
        /// </summary>
        /// <returns>The value of the term.</returns>
        public int GetTermValue()
        {
            int value = GetFactorValue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetFactorValue()
        {
            int value;
            
        }
    }
}