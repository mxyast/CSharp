using Entities.Concretes;
using System.Net.Http.Headers;

namespace TobetoETrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Table";
            product.UnitPrice = 10;
            product.Id = 1;
        }
    }
}