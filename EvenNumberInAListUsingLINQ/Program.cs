namespace EvenNumberInAListUsingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1,2,3,4,54,6,7,8,9,2,4,4342,56,54,566,12};

           List<int>evenList= list.Where(x => x % 2 == 0).ToList();

            foreach(int x in evenList)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

        }
    }
}
