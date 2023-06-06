namespace _07._Max_Sequence_of_Equal_Elements;
class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int longestCount = 0;
        int theNumber = 0;
        int momentCount = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                momentCount++;
            }
            else
            {
                if (momentCount > longestCount)
                {
                    longestCount = momentCount;                    
                    theNumber = array[i - 1];
                }
                momentCount = 1;
            }
        }
        if (momentCount > longestCount)
        {
            longestCount = momentCount;
            theNumber = array[array.Length - 1];
        }

        for (int i = 0; i < longestCount; i++)
        {
            Console.Write(theNumber + " ");
        }
    }
}

