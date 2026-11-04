using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int N = numbers[0];
        int A = numbers[1];
        int B = numbers[2];

        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            int sumOfDigits = i.ToString().Sum(c => c - '0');

            if (sumOfDigits >= A && sumOfDigits <= B)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
}
