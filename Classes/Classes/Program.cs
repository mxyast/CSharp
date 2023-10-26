namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "İlyas";
            customer.LastName = "Tuman";
            customer.City = "Adana";
            customer.Id = 1;
            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                LastName = "Engin",
                FirstName = "Edim"
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }


}