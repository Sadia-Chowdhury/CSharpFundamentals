namespace MatrixRowColDiagonalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[r, c];
            for(int i =0;i<r;i++)
            {
                string input = Console.ReadLine();
                string[] str = input.Split();

                for(int j=0;j<c;j++)
                {
                    arr[i,j]= Convert.ToInt32(str[j]);
                }
            }

            int sumRow = 0;
            int sumCol = 0;
            int sumDiag1 = 0;
            int sumDiag2 = 0;
            for(int i = 0; i < r; i++)
            {
                for(int j=0; j<c;j++)
                {
                    sumRow = sumRow + arr[i, j];
                    sumCol = sumCol + arr[j, i];
                    if(i==j)
                    {
                        sumDiag1 = sumDiag1 + arr[i, j];
                    }
                    if(i+j==c-1)
                    {
                        sumDiag2 = sumDiag2 + arr[i, j];
                    }
                }
                Console.WriteLine("Sum of the Row {0} is : {1}", i,sumRow);
                sumRow = 0;
                Console.WriteLine("Sum of the Column {0} is : {1}", i, sumCol);
                sumCol = 0;
            }
            Console.WriteLine("Sum of the main diagonal is : {0}",sumDiag1);
            Console.WriteLine("Sum of the main diagonal is : {0}",sumDiag2);

        }
    }
}
