namespace LINQwithClassandObjects
{
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Amina", Marks = 85 },
                new Student { Name = "Kamal", Marks = 70 },
                new Student { Name = "Raihan", Marks = 90 },
                new Student { Name = "Lima", Marks = 78 }
            };

           
            var highScorers = students.Where(s => s.Marks >= 80).Select(s => new { s.Name, s.Marks }).ToList();

            
            Console.WriteLine("Students with Marks >= 80:");
            foreach (var student in highScorers)
            {
                Console.WriteLine($"{student.Name} - {student.Marks}");
            }
        }
    }
}

