namespace EvenOddCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            int[] arr;
            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(str[i]);
            }
            int countEven = 0;
            int countOdd = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            Console.WriteLine("Even Count: " + countEven);
            Console.WriteLine("Odd Count: " + countOdd);

        }
    }
}
