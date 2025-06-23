namespace SquareElementsToListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {1,2,3,4,5,6 };

            List<int> squareList = list.Select(x => x * x).ToList();

            foreach (int x in squareList) {
                Console.Write(x);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
