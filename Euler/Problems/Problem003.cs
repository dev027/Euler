using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler.Problems
{
    public class Problem003 : ProblemBase
    {
        public Problem003()
            : base(
                title: "Largest prime factor",
                description: string.Join(Environment.NewLine + Environment.NewLine,
                    "The prime factors of 13195 are 5, 7, 13 and 29.",
                    "1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...",
                    "What is the largest prime factor of the number 600851475143?"),
                answer: 6857)
        {
        }

        public override long Solve()
        {
            long number = 600851475143;

            IList<long> primeNumbers = new List<long>();

            // First prime factor to try
            long primeFactor = 2;

            // Lop until we've reduced the number to 1
            while (number > 1)
            {
                // Reduce this number by this prime factor
                number = number.ReduceByFactor(primeFactor);

                // If number is 1 then this prime factor is its largest prime factor
                if (number == 1)
                {
                    continue;
                }

                // Add the prime factor to the list of known prime numbers
                primeNumbers.Add(primeFactor);

                // Get the next prime number and try again
                primeFactor = primeFactor.GetNextPrime(primeNumbers);
            }

            return primeFactor;
        }
    }

    internal static class Problem003ExtensionMethods
    {
        /// <summary>
        /// Repeatedly reduce this number by the factor
        /// </summary>
        /// <param name="number">Number to reduce</param>
        /// <param name="factor">Factor to reduce it by</param>
        /// <returns></returns>
        public static long ReduceByFactor(this long number, long factor)
        {
            // Whilst divisible, then divide by the factor
            while (number % factor == 0)
            {
                number = number / factor;
            }

            return number;
        }

        /// <summary>
        /// Find the next prime number after this one
        /// </summary>
        /// <param name="primeNumber">Current prime number</param>
        /// <param name="primeNumbers">List of known prime numbers up to and including this number</param>
        /// <returns>Next prime number</returns>
        public static long GetNextPrime(this long primeNumber, IList<long> primeNumbers)
        {
            bool isPrime;
            do
            {
                // Increment the number
                primeNumber++;

                // No need to check any prime number above the square root of this number
                long primeLimit = (long) Math.Floor(Math.Sqrt(primeNumber));

                // Check to see if there is a prime number below its square root that is a factor
                isPrime = primeNumbers
                    .TakeWhile(prime => prime < primeLimit)
                    .All(prime => primeNumber % prime != 0);
            } while (!isPrime);

            return primeNumber;
        }
    }
}