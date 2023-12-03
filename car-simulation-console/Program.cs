using System;

public static class AutoDrivingCar
{
    static void Main()
    {
        // Read input
        string[] fieldSize = Console.ReadLine().Split();
        int width = int.Parse(fieldSize[0]);
        int height = int.Parse(fieldSize[1]);

        string[] initialPosition = Console.ReadLine().Split();
        int x = int.Parse(initialPosition[0]);
        int y = int.Parse(initialPosition[1]);
        char direction = char.Parse(initialPosition[2]);

        string commands = Console.ReadLine();

        // Process commands
        foreach (char command in commands)
        {
            if (command == 'F')
            {
                MoveForward(ref x, ref y, direction, width, height);
            }
            else
            {
                Rotate(ref direction, command);
            }
        }
        //Display the Result in console
        Console.WriteLine($"{x} {y} {direction}");
    }

    public static void MoveForward(ref int x, ref int y, char direction, int width, int height)
    {
        switch (direction)
        {
            case 'N':
                if (y < height - 1) y++;
                break;
            case 'E':
                if (x < width - 1) x++;
                break;
            case 'S':
                if (y > 0) y--;
                break;
            case 'W':
                if (x > 0) x--;
                break;
        }
    }

    public static void Rotate(ref char direction, char rotation)
    {
        if (rotation == 'L')
        {
            switch (direction)
            {
                case 'N':
                    direction = 'W';
                    break;
                case 'E':
                    direction = 'N';
                    break;
                case 'S':
                    direction = 'E';
                    break;
                case 'W':
                    direction = 'S';
                    break;
            }
        }
        else if (rotation == 'R')
        {
            switch (direction)
            {
                case 'N':
                    direction = 'E';
                    break;
                case 'E':
                    direction = 'S';
                    break;
                case 'S':
                    direction = 'W';
                    break;
                case 'W':
                    direction = 'N';
                    break;
            }
        }
    }
}
