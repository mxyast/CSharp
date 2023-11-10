using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PerfectNumber
{
    internal class Program
    {
        static void usingBul(long num)
        {
            num%as
        }
        static void Main(string[] args)
        {


            int p = 2;
            double formula;
            int[] primeNums = new int[17] { 2, 3, 5, 7, 13, 17, 19, 31, 61, 89, 107, 127, 521, 607, 1279, 2203, 2281 };
            foreach (int i in primeNums)
            {
                p = i;
                //long formula = (2 ^ (p - 1)) * ((2 ^ p) - 1);
                formula = (Math.Pow(2, p - 1) * (Math.Pow(2, p) - 1));
                if (IsPerfectNumber(formula))
                {
                    Console.WriteLine(formula+"  " + p);
                }
            }


            //int counter = 0;
            //long number = 2;

            //while (counter < 10)
            //{
            //    if (IsPerfectNumber(number))
            //    {
            //        Console.WriteLine($" Mükemmel Sayı:  {counter + 1} : {number}");
            //        counter++;
            //    }
            //    number++;
            //}

            //int counter = 0;
            //long number = 2;
            //while (counter < 15)
            //{
            //    if (IsPerfectNumber(number))
            //    {
            //        Console.WriteLine($" Mükemmel Sayı:  {counter + 1} : {number}");
            //        counter++;
            //    }
            //    number++;
            //    Console.WriteLine(number);

            //}
            //Console.WriteLine("bitti");


        }


        static bool IsPerfectNumber(double num)
        {

            double sum = 0;
            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                //Console.Write(num);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
