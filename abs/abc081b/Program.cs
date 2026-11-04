using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int count = 0;

        while (numbers.All(n => n % 2 == 0))
        {
            numbers = numbers.Select(n => n / 2).ToArray();
            count++;
        }

        Console.WriteLine(count);
    }
}
