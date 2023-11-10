namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course();
            Course c2 = new Course();
            Course c3 = new Course();
            Course c4 = new Course();

            Instructor instructor = new Instructor();
            Instructor instructor1 = new Instructor();

            Category category = new Category();
            Category category1 = new Category();

            List<Course> coursesProgramalam = new List<Course>();
            List<Course> coursesSql = new List<Course>();


            instructor.Id = 1;
            instructor.Name = "Engin";

            instructor1.Id= 2;
            instructor1.Name = "İrem"; 

            category.Name = "programlama";
            category.Id = 1;

            category.Name = "Sql";
            category.Id = 2;

            c1.Id = 1;
            c1.Title = "C#";
            c1.Price = 100;
            c1.Category = category;
            c1.Description = "Description1";
            c1.Instructor = instructor;
            c1.ImageUrl = "url1";

            c2.Id = 2;
            c2.Title = "Java";
            c2.Price = 200;
            c2.Category = category;
            c2.Description = "Description2";
            c2.Instructor = instructor;
            c2.ImageUrl = "url2";
            Console.WriteLine(c2.Instructor.Name);

            c3.Id = 3;
            c3.Title = "JavaScript";
            c3.Price = 300;
            c3.Category = category;
            c3.Description = "Description3";
            c3.Instructor = instructor;
            c3.ImageUrl = "url3";

            coursesProgramalam.Add(c1);
            coursesProgramalam.Add(c2);
            coursesProgramalam.Add(c3);

            c4.Id = 4;
            c4.Title = "MsSql";
            c4.Price = 400;
            c4.Category = category1;
            c4.Description = "Description4";
            c4.Instructor = instructor1;
            c4.ImageUrl = "url3";

            coursesSql.Add(c4);
            instructor.Courses = coursesProgramalam;
            instructor1.Courses = coursesSql;
            

            foreach (Course course in coursesProgramalam)
            {
                Console.WriteLine($"Course ID: {course.Id}, Course Name: {course.Title}");
            }
        }
    }
}