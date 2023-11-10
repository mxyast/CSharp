using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsKamp
{
    internal class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("product added product: " + product.Name);
        }
        public void Add2(string productName,string description,double price) {
            Console.WriteLine("product added product: " + productName);
        }
    }
}
