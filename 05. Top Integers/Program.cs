namespace _05._Top_Integers;
class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool isItGrater = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] <= array[j])
                {
                    isItGrater = false;
                    break;
                }
            }
            if (isItGrater)
            {
                Console.Write(array[i] + " ");
            }

            isItGrater = true;
        }

        Console.Write(array[array.Length - 1]);
    }
}

