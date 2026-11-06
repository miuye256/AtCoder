using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        HashSet<string> registeredUserNames = new HashSet<string>();

        for (int i = 1; i <= n; i++)
        {
            if (registeredUserNames.Add(Console.ReadLine()!))
            {
                Console.WriteLine(i);
            }
        }
    }
}
