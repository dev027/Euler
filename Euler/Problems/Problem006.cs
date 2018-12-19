using System;

namespace Euler.Problems
{
    public class Problem006 : ProblemBase, IProblem
    {
        public Problem006()
            : base(
                title: "Sum square difference",
                description: string.Join(Environment.NewLine + Environment.NewLine,
                    "The sum of the squares of the first ten natural numbers is,",
                    "1^2 + 2^2 + ... + 10^2 = 385",
                    "The square of the sum of the first ten natural numbers is,",
                    "(1 + 2 + ... + 10)^2 = 55^2 = 3025",
                    "Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.",
                    "Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum."),
                answer: 25164150)
        {
        }

        public override long Solve()
        {
            const long number = 100;
            return number.SquareSum() - number.SumSquares();
        }
    }

    internal static class Problem006ExtensionMethods
    {
        public static long SumSquares(this long number)
        {
            long answer = 0;
            for (long x = 1; x <= number; x++)
            {
                answer += x * x;
            }

            return answer;
        }

        public static long SquareSum(this long number)
        {
            long answer = 0;
            for (long x = 1; x <= number; x++)
            {
                answer += x;
            }

            return answer * answer;
        }
    }
}