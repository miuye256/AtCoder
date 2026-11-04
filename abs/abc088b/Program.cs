using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] cardValues = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).ToArray();

        int aliceScore = 0;
        int bobScore = 0;

        for (int i = 0; i < N; i++)
        {
            if (i % 2 == 0)
            {
                aliceScore += cardValues[i];
            }
            else
            {
                bobScore += cardValues[i];
            }
        }
        Console.WriteLine(aliceScore - bobScore);
    }
}
