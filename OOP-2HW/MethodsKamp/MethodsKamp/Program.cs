namespace MethodsKamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = "Elma";
            double price = 15;
            string description = "Amasya Elması";

            Product product = new Product();
            product.Name = "Elma";
            product.price = 15;
            product.Description = "Amasya Elması";

            Product product1 = new Product();
            product.Name = "Karpuz";
            product.price = 80;
            product.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product,product1};

            foreach (Product p in products)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Description);
                Console.WriteLine(p.price);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("----------------Methods--------------------");
           //instance -- örnek

            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product);
            sepetManager.Add(product1);
            //encapsulation

            sepetManager.Add2("Armut", " yeşil armut", 12);
            sepetManager.Add2("elma", " kırmızı elma", 12);
            sepetManager.Add2("karpuz", " diyarbakır karpuzu", 12);



        }
    }
}