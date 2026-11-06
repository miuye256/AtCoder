using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] classOneSums = new int[n + 1];
        int[] classTwoSums = new int[n + 1];

        for (int i = 1; i <= n; i++)
        {
            int[] set = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int classNum = set[0];
            int score = set[1];

            classOneSums[i] = classOneSums[i - 1] + (classNum == 1 ? score : 0);
            classTwoSums[i] = classTwoSums[i - 1] + (classNum == 2 ? score : 0);
        }

        int q = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < q; i++)
        {
            int[] range = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int sumScoreOne = classOneSums[range[1]] - classOneSums[range[0] - 1];
            int sumScoreTwo = classTwoSums[range[1]] - classTwoSums[range[0] - 1];

            Console.WriteLine($"{sumScoreOne} {sumScoreTwo}");
        }
    }
}
