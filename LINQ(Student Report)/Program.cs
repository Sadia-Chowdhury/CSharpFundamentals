namespace LINQ_Student_Report_
{
    class Student
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Marks { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Ayaan", Department = "CSE", Marks = 85 },
                new Student { Name = "Raisa", Department = "CSE", Marks = 92 },
                new Student { Name = "Mehedi", Department = "EEE", Marks = 70 },
                new Student { Name = "Fatima", Department = "CSE", Marks = 60 },
                new Student { Name = "Tariq", Department = "EEE", Marks = 88 },
                new Student { Name = "Sadia", Department = "CSE", Marks = 78 }
            };

            List<Student> CSEdept = students.Where(x => x.Department == "CSE").Select(x => new Student { Name = x.Name, Department = x.Department, Marks = x.Marks }).ToList();

            foreach (Student student in CSEdept)
            {
                Console.Write($"{student.Name} {student.Department}");
                Console.WriteLine();
            }

            List<string> names = students.Where(x => x.Marks > 80).Select(x => x.Name).ToList();
            Console.WriteLine(string.Join(" ",names));

            List<Student> sortedByMarksDescending = students.OrderByDescending(x => x.Marks).ToList();

            foreach (Student student in sortedByMarksDescending)
            {
                Console.Write($"{student.Name} {student.Department} {student.Marks}");
                Console.WriteLine();
            }

            var groupedStudents = students.GroupBy(s => s.Department);

            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Department: {group.Key}");

                foreach (var student in group)
                {
                    Console.WriteLine($" - {student.Name} ({student.Marks})");
                }
            }

        }
    }
}
