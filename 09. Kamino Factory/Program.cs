namespace _09._Kamino_Factory;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string input = string.Empty;

        int bestSubsequenceOfOnes = 0;
        int bestSubsequenceOfOnesSum = 0;
        int leftmostStartingIndex = -1;
        string theBest = string.Empty;
        int theBestTime = 0;
        int time = 0;
        while ((input = Console.ReadLine()) != "Clone them!")
        {
            time++;
            string realInput = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '!')
                {
                    realInput += input[i];
                }
            }

            int subsequenceOfOnes = 0;
            for (int i = 0; i < realInput.Length; i++)
            {
                if (realInput[i] == '1')
                {
                    subsequenceOfOnes++;
                }
                else
                {
                    if (subsequenceOfOnes > bestSubsequenceOfOnes)
                    {
                        bestSubsequenceOfOnes = subsequenceOfOnes;
                        bestSubsequenceOfOnesSum = 0;
                        for (int j = 0; j < realInput.Length; j++)
                        {
                            if (realInput[j] == '1')
                            {
                                bestSubsequenceOfOnesSum++;
                            }
                        }
                        theBest = realInput;
                        theBestTime = time;
                        leftmostStartingIndex = i - bestSubsequenceOfOnes;
                    }
                    else if (subsequenceOfOnes == bestSubsequenceOfOnes)
                    {
                        if (leftmostStartingIndex > i - subsequenceOfOnes)
                        {
                            bestSubsequenceOfOnes = subsequenceOfOnes;
                            bestSubsequenceOfOnesSum = 0;
                            for (int j = 0; j < realInput.Length; j++)
                            {
                                if (realInput[j] == '1')
                                {
                                    bestSubsequenceOfOnesSum++;
                                }
                            }
                            theBest = realInput;
                            theBestTime = time;
                            leftmostStartingIndex = i - bestSubsequenceOfOnes;
                        }
                        else if (leftmostStartingIndex == i - subsequenceOfOnes)
                        {
                            int sum = 0;
                            for (int j = 0; j < realInput.Length; j++)
                            {
                                if (realInput[j] == '1')
                                {
                                    sum++;
                                }
                            }
                            if (bestSubsequenceOfOnesSum < sum)
                            {
                                bestSubsequenceOfOnes = subsequenceOfOnes;
                                bestSubsequenceOfOnesSum = sum;
                                theBest = realInput;
                                theBestTime = time;
                            }
                        }
                    }
                    subsequenceOfOnes = 0;
                }
            }
            if (subsequenceOfOnes > bestSubsequenceOfOnes)
            {
                bestSubsequenceOfOnes = subsequenceOfOnes;
                bestSubsequenceOfOnesSum = 0;
                for (int j = 0; j < realInput.Length; j++)
                {
                    if (realInput[j] == '1')
                    {
                        bestSubsequenceOfOnesSum++;
                    }
                }
                theBest = realInput;
                theBestTime = time;
                leftmostStartingIndex = i - bestSubsequenceOfOnes;
            }
            else if (subsequenceOfOnes == bestSubsequenceOfOnes)
            {
                if (leftmostStartingIndex > i - subsequenceOfOnes)
                {
                    bestSubsequenceOfOnes = subsequenceOfOnes;
                    bestSubsequenceOfOnesSum = 0;
                    for (int j = 0; j < realInput.Length; j++)
                    {
                        if (realInput[j] == '1')
                        {
                            bestSubsequenceOfOnesSum++;
                        }
                    }
                    theBest = realInput;
                    theBestTime = time;
                    leftmostStartingIndex = i - bestSubsequenceOfOnes;
                }
                else if (leftmostStartingIndex == i - subsequenceOfOnes)
                {
                    int sum = 0;
                    for (int j = 0; j < realInput.Length; j++)
                    {
                        if (realInput[j] == '1')
                        {
                            sum++;
                        }
                    }
                    if (bestSubsequenceOfOnesSum < sum)
                    {
                        bestSubsequenceOfOnes = subsequenceOfOnes;
                        bestSubsequenceOfOnesSum = sum;
                        theBest = realInput;
                        theBestTime = time;
                    }
                }
            }
        }

        if (theBest == string.Empty)
        {
            for (int i = 0; i < n; i++)
            {
                theBest += '0';
            }
        }

        Console.WriteLine($"Best DNA sample {theBestTime} with sum: {bestSubsequenceOfOnesSum}.\n{string.Join(' ', theBest.ToArray())}");
    }    
}
