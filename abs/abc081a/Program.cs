using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string squares = Console.ReadLine();
        Console.WriteLine(squares.Count(s => s == '1'));
    }
}
