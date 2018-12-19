using System;

namespace Euler.Problems
{
    public class Problem000 : ProblemBase, IProblem
    {
        public Problem000()
            : base(
                title: "Title",
                description: string.Join(Environment.NewLine + Environment.NewLine,
                    "Description"),
                answer: -1)
        {
        }

        public override long Solve()
        {
            return 0;
        }
    }
}