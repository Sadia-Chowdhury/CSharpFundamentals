using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassReport
{
    internal class Student
    {
        string Name { get; set; }
        string ID { get; set; }
        List<int> Marks { get; set; }

        public Student(string name, string id, List<int>marks)
        {
            this.Name = name;
            this.ID = id;
            this.Marks = marks;
        }

        public void PrintReportCard()

        {
            Console.WriteLine($"Student's Name : {Name}");
            Console.WriteLine($"Student's ID : {ID}");
            Console.Write("Marks: ");

            for (int i = 0; i < Marks.Count; i++)
            {
                Console.Write(Marks[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine($"Student's Aveerage : {PrintAvg()}");

        }
        public int PrintAvg()
        {
            return Marks.Sum()/Marks.Count;
        }



    }
}
