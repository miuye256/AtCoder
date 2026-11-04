using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] diameters = new int[N];

        for (int i = 0; i < N; i++)
        {
            diameters[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(diameters.Distinct().Count());
    }
}
