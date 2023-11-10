namespace OOPIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

          Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = "C# OOP Dersleri";
            course1.InstructorId = 1;
            course1.Price = 0;

            Course course2 = new Course();
            course1.Id = 2;
            course1.Name = "Java";
            course1.Description = "Java OOP Dersleri";
            course1.InstructorId = 1;
            course1.Price = 0;

            course1 = course2;
            course2.Name = "Javascript";
            Console.WriteLine(course1.Name);//obje refrans tipidir ondan  course2.Name = "Javascript"; döner


        }
    }
}