using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] ny = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int num = ny[0];
        int amount = ny[1];

        for (int i = num; i >= 0; i--)
        {
            if (10000 * i > amount) continue;
            for (int j = num - i; j >= 0; j--)
            {
                if (5000 * j + 10000 * i > amount) continue;
                int k = num - i - j;
                if (1000 * k + 5000 * j + 10000 * i == amount)
                {
                    Console.WriteLine($"{i} {j} {k}");
                    return;
                }
            }
        }
        Console.WriteLine("-1 -1 -1");
    }
}
