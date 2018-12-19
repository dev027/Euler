using System;

namespace Euler.Problems
{
    public class Problem001 : ProblemBase, IProblem
    {
        public Problem001()
            : base(
                title: "Multiples of 3 and 5",
                description: string.Join(Environment.NewLine + Environment.NewLine,
                    "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.",
                    "Find the sum of all the multiples of 3 or 5 below 1000."),
                answer: 233168)
        {
        }

        public override long Solve()
        {
            const long limit = 1000;

            long term = 1;

            long answer = 0;
            while (term < limit)
            {
                if (term % 3 == 0 || term % 5 == 0)
                {
                    answer += term;
                }

                term++;
            }
            return answer;
        }
    }
}