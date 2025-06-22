namespace TwoSumUsingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =Convert.ToInt32(Console.ReadLine());

            string input = Console.ReadLine();
            string[] str = input.Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(str[i]);
            }
            int target = Convert.ToInt32(Console.ReadLine());
            
            Dictionary<int,int> map = new Dictionary<int,int>();

            for (int i = 0; i < n; i++)
            {
               int sum = target - arr[i];
               if(map.ContainsKey(sum))
                {
                    Console.WriteLine("Pair Found at indices {0} and {1}.", map[sum],i);
                }
               else
                {
                    map[arr[i]]= i;
                }
            }

        }
       
    }
}
