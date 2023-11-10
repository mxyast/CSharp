using System.Numerics;

namespace PerfectNumberWithPrime
{
    internal class Program
    {
        public static bool IsMersennePrime(int p)
        {
            if (!IsPrime(p))
            {
                Console.WriteLine("n is not prime.");
                return false;
            }

            double mersenneNumber = Math.Pow(2, p) - 1;
            long lucasLehmerValue = 4;
            long modulus = (long)Math.Pow(2, p) - 1;

            for (int i = 0; i < p - 2; i++)
            {
                lucasLehmerValue = (lucasLehmerValue * lucasLehmerValue - 2) % modulus;
            }

            return lucasLehmerValue == 0;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public static void Main()
        {
            int[] p =new int[] { 2, 3, 5, 7, 13, 17, 19,23,29, 31, 61, 89, 107, 127, 521, 607, 1279, 2203, 2281, 3217, 4253, 4423, 9689, 9941 }; // Mersenne sayısının üssü (örneğin, 2^p - 1)
           for(int i=0; i < p.Length; i++)
            {
                if (IsMersennePrime(p[i]))
                {
                    Console.WriteLine($"2^{p[i]} - 1 is prime.");
                }
                else
                {
                    Console.WriteLine($"2^{p[i]} - 1 is not prime.");
                }
            }
            
        }
    }
}