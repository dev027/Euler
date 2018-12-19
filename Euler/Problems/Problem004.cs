using System;
using System.Linq;

namespace Euler.Problems
{
    public class Problem004 : ProblemBase
    {
        public Problem004()
            : base(
                title: "Largest palindrome product",
                description: string.Join(Environment.NewLine + Environment.NewLine,
                    "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.",
                    "Find the largest palindrome made from the product of two 3-digit numbers."),
                answer: 906609)
        {
        }

        public override long Solve()
        {
            const long startNumber = 100;
            const long endNumber = 999;
            long largestPalindrome = 0;

            for (long number1 = startNumber; number1 <= endNumber; number1++)
            {
                for (long number2 = startNumber; number2 <= endNumber; number2++)
                {
                    var product = number1 * number2;
                    if (product <= largestPalindrome)
                    {
                        continue;
                    }
                    if (product.IsPalindromic())
                    {
                        largestPalindrome = product;
                    }
                }

            }
            return largestPalindrome;
        }
    }
    internal static class Problem004ExtensionMethods
    {
        public static bool IsPalindromic(this long number)
        {
            string string1 = number.ToString();
            string string2 = new string(string1.Reverse().ToArray());
            return string1 == string2;
        }
    }
}