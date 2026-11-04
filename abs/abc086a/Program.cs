using System;
using System.Linq;

class Program
{
    static void Main()
    {
        bool isEven = Console.ReadLine().Split(' ').Select(int.Parse).Any(n => n % 2 == 0);

        Console.WriteLine(isEven ? "Even" : "Odd");
    }
}
