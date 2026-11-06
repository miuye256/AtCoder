using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] num = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int k = num[1];

        int[] sequenceA = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int[] sequenceB = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

        int requiredOperations = sequenceA.Zip(sequenceB, (numA, numB) => Math.Abs(numA - numB)).Sum();

        if (k >= requiredOperations && (k - requiredOperations) % 2 != 1) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}
