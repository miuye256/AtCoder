using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int rowCount = input[0];
        int columnCount = input[1];
        int[] rowSums = new int[rowCount];
        int[] columnSums = new int[columnCount];
        int[,] matrix = new int[rowCount, columnCount];

        for (int i = 0; i < rowCount; i++)
        {
            var row = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            rowSums[i] = row.Sum();

            for (int j = 0; j < columnCount; j++)
            {
                columnSums[j] += row[j];
                matrix[i, j] = row[j];
            }
        }
        for (int i = 0; i < rowCount; i++)
        {
            int[] resultRow = new int[columnCount];

            for (int j = 0; j < columnCount; j++)
            {
                resultRow[j] = rowSums[i] + columnSums[j] - matrix[i, j];
            }
            Console.WriteLine(string.Join(" ", resultRow));
        }
    }
}
