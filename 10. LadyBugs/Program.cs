namespace _10._LadyBugs;
class Program
{
    static void Main(string[] args)
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] bugsIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] field = new int[fieldSize];
        for (int i = 0; i < field.Length; i++)
        {           
            field[i] = 0;
        }
        for (int i = 0; i < bugsIndexes.Length; i++)
        {
            field[bugsIndexes[i]] = 1;
        }
        string command = string.Empty;
        string[] commands;
        int bugIndex = 0;
        string direction = null;
        int steps = 0;
        while ((command = Console.ReadLine()) != "end")
        {           
            commands = command.Split(' ');
            bugIndex = int.Parse(commands[0]);
            direction = commands[1];
            steps = int.Parse(commands[2]);

            if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0 || steps == 0)
                continue;
            
            field[bugIndex] = 0;

            if (direction == "right")
            {
                if (bugIndex + steps >= field.Length || bugIndex + steps < 0)
                    continue;

                while (true)
                {
                    if (bugIndex + steps < field.Length && bugIndex + steps >= 0)
                    {
                        bugIndex += steps;
                    }
                    else
                    {
                        break;
                    }
                    if (field[bugIndex] == 0)
                    {
                        field[bugIndex] = 1;
                        break;
                    }
                }                
            }
            else // left
            {
                if (bugIndex - steps < 0 || bugIndex - steps >= field.Length)
                    continue;

                while (true)
                {
                    if (bugIndex - steps >= 0 && bugIndex - steps < field.Length)
                    {
                        bugIndex -= steps;
                    }
                    else
                    {
                        break;
                    } 
                    if (field[bugIndex] == 0)
                    {
                        field[bugIndex] = 1;
                        break;
                    }
                }                
            }
        }
        Console.WriteLine(string.Join(" ", field));
    }
}

