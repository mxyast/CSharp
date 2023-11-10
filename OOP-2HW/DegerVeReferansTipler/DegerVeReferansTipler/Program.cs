using System.Security.Cryptography;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int sayil = 10;
            int sayi2 = 30;
            sayil = sayi2;
            sayi2 = 65;
            //sayil ?? =30
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilari [0] ?? =999
        }
    }
}