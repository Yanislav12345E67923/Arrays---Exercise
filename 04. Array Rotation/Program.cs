namespace _04._Array_Rotation;
class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int firstIndex = array[0];
            for (int j = 1; j < array.Length; j++)
            {
                array[j - 1] = array[j];
            }
            array[array.Length - 1] = firstIndex;
        }
        Console.WriteLine(string.Join(' ', array));
    }
}

