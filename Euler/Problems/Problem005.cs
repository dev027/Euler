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
            long limit = 20;
            IDictionary<long, int> primes = new Dictionary<long, int>();

            for (long factor = 2; factor <= limit; factor++)
            {
                var primeFactors = factor.PrimeFactors();

                foreach (var primeFactor in primeFactors)
                {
                    if (primes.ContainsKey(primeFactor.Key))
                    {
                        if (primes[primeFactor.Key] < primeFactor.Value)
                        {
                            primes[primeFactor.Key] = primeFactor.Value;
                        }
                    }
                    else
                    {
                        primes.Add(primeFactor);
                    }
                }
            }

            long answer = 1;

            foreach (var prime in primes)
            {
                for (int i = 1; i <= prime.Value; i++)
                {
                    answer *= prime.Key;
                }
            }

            return answer;
        }
    }

    internal static class Problem005ExtensionMethods
    {
        public static IDictionary<long, int> PrimeFactors(this long number)
        {
            var limit = (long) Math.Floor(Math.Sqrt(number));
            IList<long> primes = new List<long>();
            IDictionary<long, int> primeFactors = new Dictionary<long, int>();

            for (var factor = 2; factor <= limit; factor++)
            {
                bool isPrime = true;
                foreach (var prime in primes)
                {
                    if (factor % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (!isPrime)
                {
                    continue;
                }

                primes.Add(factor);

                var counter = 0;
                while (number % factor == 0)
                {
                    counter++;
                    number = number / factor;
                }
                primeFactors.Add(factor, counter);

                if (number == 1)
                {
                    break;
                }
            }

            if (number != 1)
            {
                primeFactors.Add(number, 1);
            }

            return primeFactors;
        }
    }
}