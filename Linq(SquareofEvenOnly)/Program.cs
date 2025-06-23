namespace Linq_SquareofEvenOnly_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> squareOfInts = list.Where(x => x % 2 == 0).Select(x => x * x).ToList();

            Console.WriteLine(string.Join(" ", squareOfInts));

        }
    }
}
