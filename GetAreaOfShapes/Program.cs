using System.Transactions;

namespace GetAreaOfShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the rectangle: ");
            double width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The height of the rectangle: ");
            double height = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle1 = new Rectangle(width, height);
            Console.WriteLine($"The Area of the rectangle is :{rectangle1.GetArea()}");
            Console.WriteLine();

            Console.WriteLine("Enter the radius of the circle: ");
            double radius = Convert.ToInt32(Console.ReadLine());
            

            Circle circle1 = new Circle(radius);
            Console.WriteLine($"The Area of the circle is :{circle1.GetArea()}");
            Console.WriteLine();
        }
    }
}
