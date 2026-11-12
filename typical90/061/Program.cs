using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // int q = int.Parse(Console.ReadLine()!);
        // List<int> deck = new List<int>();

        // for (int i = 0; i < q; i++)
        // {
        //     int[] input = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        //     int t = input[0];
        //     int x = input[1];

        //     if (t == 1)
        //     {
        //         deck.Insert(0, x);
        //     }
        //     else if (t == 2)
        //     {
        //         deck.Add(x);
        //     }
        //     else
        //     {
        //         Console.WriteLine(deck[x - 1]);
        //     }
        // }
        int q = int.Parse(Console.ReadLine()!);
        List<int> deckFront = new List<int>();
        List<int> deckBack = new List<int>();

        for (int i = 0; i < q; i++)
        {
            int[] input = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int t = input[0];
            int x = input[1];

            if (t == 1)
            {
                deckFront.Add(x);
            }
            else if (t == 2)
            {
                deckBack.Add(x);
            }
            else
            {
                if (x <= deckFront.Count)
                {
                    Console.WriteLine(deckFront[deckFront.Count - x]);
                }
                else
                {
                    Console.WriteLine(deckBack[x - deckFront.Count - 1]);
                }
            }
        }
    }
}
