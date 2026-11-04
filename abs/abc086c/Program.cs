using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int second, x, y;
        int previousSecond = 0, previousX = 0, previousY = 0;

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            second = int.Parse(inputs[0]);
            x = int.Parse(inputs[1]);
            y = int.Parse(inputs[2]);

            int timeDiff = second - previousSecond;
            int distance = Math.Abs(x - previousX) + Math.Abs(y - previousY);

            if (distance > timeDiff || (timeDiff - distance) % 2 != 0)
            {
                Console.WriteLine("No");
                return;
            }
            previousSecond = second;
            previousX = x;
            previousY = y;
        }
        Console.WriteLine("Yes");
    }
}
