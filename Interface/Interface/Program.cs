namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IntarfacesIntro();

            // IPerson person = new Customer();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirsName = "İlyas", Adress = "Ankara", LastName = "Tuman" });
            Student student = new Student
            {
                Id = 1,
                FirsName = "İlyas",
                Depatmant = "Computer Science",
                LastName = "Tuman"
            };
            manager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirsName { get; set; }
        string LastName { get; set; }
    }
    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public String Adress {  get; set; } 
    }
    class Student :IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public String Depatmant { get; set; }  
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public String Depatmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirsName);
        }
    }
}