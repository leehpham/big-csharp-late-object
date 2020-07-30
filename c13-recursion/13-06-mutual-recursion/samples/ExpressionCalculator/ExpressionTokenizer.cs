using System;

namespace ExpressionCalculator
{
    /// <summary>
    /// This class breaks up a string describing an expression into tokens: numbers, parentheses, and operators.
    /// </summary>
    public class ExpressionTokenizer
    {
        private string input;
        private int start; // The start of the current token.
        private int end; // The position after the end of the current token.
        
        /// <summary>
        /// Constructs a tokenizer.
        /// </summary>
        /// <param name="anInput">the string to tokenize.</param>
        public ExpressionTokenizer(string anInput)
        {
            input = anInput;
            start = 0;
            end = 0;
            NextToken(); // Find the first token
        }

        /// <summary>
        /// Peeks at the next token without consuming it.
        /// </summary>
        /// <returns>The next token or null if there are no more tokens.</returns>
        public string PeekToken()
        {
            if (start >= input.Length) { return null; } 
            else { return input.Substring(start, end - start); }
        }

        /// <summary>
        /// Gets the next token and moves the tokenizer to the following token.
        /// </summary>
        /// <returns>the next token or null if there are no more tokens.</returns>
        public string NextToken()
        {
            string r = PeekToken();
            start = end;
            if (start >= input.Length) { return r; }
            if (char.IsDigit(input[start]))
            {
                end = start + 1;
                while (end < input.Length && char.IsDigit(input[end]))
                {
                    end++;
                }
            }
            else
            {
                end = start + 1;
            }
            return r;
        }
    }
}