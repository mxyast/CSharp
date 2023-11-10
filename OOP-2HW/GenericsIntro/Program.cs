namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("engin");
            Console.WriteLine(isimler.Length);
            isimler.Add("kerem");
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}