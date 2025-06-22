namespace FrequencyCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            input = input.ToLower();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    continue;
                }
                if(counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts[c] = 1;
                }
            }

            int max = 0;
            char maxc=' ';
            foreach(var pair in counts)
            {
                if(pair.Value >= max)
                {
                    max = pair.Value; 
                    maxc = pair.Key;    
                }
            }

            Console.WriteLine("Most Frequent character "+ maxc +". And it apeared "+ max +"times.");
        }
    }
}
