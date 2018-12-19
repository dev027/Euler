using System;
using System.Collections.Generic;

namespace Euler.Problems
{
    public class Problem005 : ProblemBase, IProblem
    {
        public Problem005()
            : base(
                title: "Smallest multiple",
                description: string.Join(Environment.NewLine + Environment.NewLine,
                    "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.",
                    "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?"),
                answer: 232792560)
        {
        }

        public override long Solve()
        {
            var limit = 20;
            Dictionary<int, int> primes = new Dictionary<int, int>();

            for (int factor = 1; factor <= limit; factor++)
            {

            }

            return 0;
        }
    }
}