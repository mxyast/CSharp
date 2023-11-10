using System;
using System.Diagnostics.Metrics;
using System.Drawing;

class ArmstrongNumberChecker
{
    static void Main()
    {
        //Console.WriteLine("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());

        //if (IsArmstrongNumber(number))
        //{
        //    Console.WriteLine(number + " Girilen sayı Armstrong sayıdır");
        //}
        //else
        //{
        //    Console.WriteLine(number + " Girilen sayı Armstrong sayı değildir");
        //}
        FibonacciSeries();

    }
    static public void FibonacciSeries()
    {
        int number = 100;
        double number1 = 0;
        double number2 = 1;

        Console.WriteLine(number + " " + "Fibonnaci");
        for (int i = 0; i < number; i++)
        {

            Console.WriteLine(number1);
            double next = number1 + number2;

            number1 = number2;
            number2 = next;
        }

        Console.ReadLine();
    }
    Console.WriteLine(keyCount[i]+":"+counter+ ", ");


    static bool IsArmstrongNumber(int number)
    {
        int originalNumber = number;
        int numDigits = (int)Math.Floor(Math.Log10(number)) + 1;
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, numDigits);
            number /= 10;


        }

        return sum == originalNumber;




    }

//    Console.Write("Kelimenizi girin: ");
//string keyCount = Console.ReadLine();
////keyCount.ToLower();

//for (int i = 0; i<keyCount.Length; i++)
//{
//    char currentChar = keyCount[i];
//    if (char.IsLetter(currentChar))
//    {
//        int count = 1;

//        for (int j = i + 1; j<keyCount.Length; j++)
//        {
//            if (keyCount[j] == currentChar)
//            {
//                count++;
//                keyCount = keyCount.Remove(j, 1);
//                j--;
//            }
//        }

//        Console.WriteLine($"{currentChar}: {count}");
//    }

//    using System;
//namespace Anagram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.Write("Enter first word:");
//            string word1 = Console.ReadLine();
//            Console.Write("Enter second word:");
//            string word2 = Console.ReadLine();



//            if (AreAnagrams(word1, word2))
//            {
//                Console.WriteLine($"{word1} ve {word2} anagramdır.");
//            }
//            else
//            {
//                Console.WriteLine($"{word1} ve {word2} anagram değildir.");

//            }
//        }

//        static bool AreAnagrams(string word1, string word2)
//        {

//            char[] charArray1 = word1.ToLower().ToCharArray();
//            char[] charArray2 = word2.ToLower().ToCharArray();

//            Array.Sort(charArray1);
//            Array.Sort(charArray2);

//            return new string(charArray1) == new string(charArray2);
//        }
//    }
//}
}