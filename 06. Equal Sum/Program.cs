namespace _06._Equal_Sum;
class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int leftSum = 0;
        int rightSum = 0;

        int printNo = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                leftSum = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }
                if (leftSum == rightSum)
                {
                    printNo = 1;
                    Console.WriteLine(i);
                    break;
                }
            }
            else if (i == array.Length - 1)
            {
                rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                if (leftSum == rightSum)
                {
                    printNo = 1;
                    Console.WriteLine(i);
                    break;
                }
            }
            else
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }
                if (leftSum == rightSum)
                {
                    printNo = 1;
                    Console.WriteLine(i);
                    break;
                }
            }
            leftSum = 0;
            rightSum = 0;
        }

        if (printNo == 0)
            Console.WriteLine("no");        
    }
}

