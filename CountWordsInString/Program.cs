namespace CountWordsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine().Trim();
            Console.WriteLine(input);
            string[] str = input.Split(' ');

            Console.WriteLine(str.Length);
        }
    }
}
