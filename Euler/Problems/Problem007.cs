using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler.Problems
{
    public class Problem007 : ProblemBase, IProblem
    {
        public Problem007()
            : base(
                title: "10001st prime",
                description: string.Join(Environment.NewLine + Environment.NewLine,
                    "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.",
                    "What is the 10 001st prime number?"),
                answer: 104743)
        {
        }

        public override long Solve()
        {
            const int limit = 10001;
            IList<long> primes = new List<long>();

            long number = 1;
            while (primes.Count < limit)
            {
                number++;
                long primeLimit = (long) Math.Floor(Math.Sqrt(number));

                bool isPrime = primes
                    .TakeWhile(prime => prime <= primeLimit)
                    .All(prime => number % prime != 0);

                if (isPrime)
                {
                    primes.Add(number);
                }
            }

            return number;
        }
    }
}