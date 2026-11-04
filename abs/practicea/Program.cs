using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string s = Console.ReadLine();

        Console.WriteLine($"{a + numbers.Sum()} {s}");
    }
}
