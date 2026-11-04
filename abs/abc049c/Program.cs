using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string target = Console.ReadLine();
        bool canBeConstructed = true;
        int count = 0;

        while (true)
        {
            if (count == target.Length) break;
            // スライスでも文字列のコピーを新しく作るらしい、初めて知った
            // else if (target[..^count].EndsWith("eraser")) count += 6;
            // else if (target[..^count].EndsWith("dreamer")) count += 7;
            // else if (target[..^count].EndsWith("erase")) count += 5;
            // else if (target[..^count].EndsWith("dream")) count += 5;
            else if (EndsWith(target, target.Length - count, "eraser")) count += 6;
            else if (EndsWith(target, target.Length - count, "dreamer")) count += 7;
            else if (EndsWith(target, target.Length - count, "erase")) count += 5;
            else if (EndsWith(target, target.Length - count, "dream")) count += 5;
            else
            {
                canBeConstructed = false;
                break;
            }
        }

        Console.WriteLine(canBeConstructed ? "YES" : "NO");
    }

    static bool EndsWith(string target, int end, string word)
    {
        int start = end - word.Length;
        if (start < 0) return false;

        return string.CompareOrdinal(target, start, word, 0, word.Length) == 0;
    }
}
