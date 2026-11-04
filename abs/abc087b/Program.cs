using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int targetAmount = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i <= a; i++)
        {
            for (int j = 0; j <= b; j++)
            {
                int remainingAmount = targetAmount - (i * 500 + j * 100);
                if (remainingAmount >= 0)
                {
                    int k = remainingAmount / 50;
                    if (k <= c)
                    {
                        count++;
                    }
                }
            }
        }

        Console.WriteLine(count);
    }
}
