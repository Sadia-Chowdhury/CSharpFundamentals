namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] jaggedArr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                string input = Console.ReadLine();
                string[] str = input.Split();
                jaggedArr[i] = new int[m];

                for (int j = 0; j < str.Length; j++)
                {
                    jaggedArr[i][j] = Convert.ToInt32(str[j]);
                }
            }

            
            int maxSum = 0;
            int maxR = 0;
            for (int i = 0; i < n; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    rowSum = rowSum + jaggedArr[i][j];
                }
                if(rowSum > maxSum)
                {
                    maxSum = rowSum;
                    maxR = i;

                }
            }

            Console.WriteLine($"Row-{maxR} has the maximum sum = {maxSum}");
        }
    }
}
