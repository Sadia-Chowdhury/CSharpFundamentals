namespace StudentClassReport
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Student's name :");
            string name = Console.ReadLine();
            Console.WriteLine("Student's ID: ");
            string id = Console.ReadLine();

            Console.WriteLine("Student's Marks: ");

            string input = Console.ReadLine();
            string[] str = input.Split();
            List<int> marks = new List<int>();

            foreach (string str2 in str)
            {
                marks.Add(int.Parse(str2));
            }


            Student student1 = new Student(name, id, marks);
            int avg = student1.PrintAvg(marks);
            student1.PrintReportCard(name, id, marks, avg);
        }
    }
}
