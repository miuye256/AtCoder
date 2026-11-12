using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] hw = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int h = hw[0];
        int w = hw[1];

        if (h == 1 || w == 1)
        {
            Console.WriteLine(h * w);
        }
        else
        {
            int hCount = h / 2 + h % 2;
            int wCount = w / 2 + w % 2;

            Console.WriteLine(hCount * wCount);
        }
    }
}
