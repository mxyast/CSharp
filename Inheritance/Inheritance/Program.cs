namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="İlyas"}, new Person{FirstName="Muhammed"},new Student{FirstName="Tuman"}

            };
            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Person2 
    {

    }
    class Customer : Person //interface birden fazla implementasyon yapılabilir ama classlar kullanılamaz 
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
    //inheritance kullanılması gerekmiyorsa interfacelerden devam 
}