namespace DynamicArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();

            int n = Convert.ToInt32(Console.ReadLine());

            string input = Console.ReadLine();
            string[] numbers = input.Split();

            for(int i=0;i<n;i++)
            {
                list.Add(Convert.ToInt32(numbers[i]));
            }

            list.Insert(2, 10);
            list.RemoveAt(4);
            list.Insert(0, 99);


            
            foreach(int i in list)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
