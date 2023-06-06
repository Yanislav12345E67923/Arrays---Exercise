namespace _03._Zig_Zag_Arrays;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] one = new int[n];        
        int[] two = new int[n];        
        for (int i = 1; i <= n; i++)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (i % 2 != 0) // odd
            {
                one[i - 1] = input[0];
                two[i - 1] = input[1];
            }
            else // even
            {
                one[i - 1] = input[1];
                two[i - 1] = input[0];
            }
        }
        Console.WriteLine(string.Join(' ', one));
        Console.WriteLine(string.Join(' ', two));
    }
}

