using System;
using System.Linq;

class Program
{
    static void Main()
    {
        ulong[] sides = Console.ReadLine()!.Split(" ").Select(ulong.Parse).ToArray();
        ulong[] copy = sides.ToArray();

        while (true)
        {
            Array.Sort(copy);

            ulong remainder = copy[2] % copy[0];

            if (remainder != 0)
            {
                copy[2] = remainder;
            }
            else
            {
                remainder = copy[1] % copy[0];
                if (remainder != 0)
                {
                    copy[1] = remainder;
                }
                else break;
            }
        }

        ulong minSide = copy.Min();
        ulong result = 0;

        foreach (ulong side in sides)
        {
            result += side / minSide - 1;
        }

        Console.WriteLine(result);
    }
}

#region 別案：ユークリッドの互除法
/*
2数の最大公約数を求める処理を `Gcd` メソッドに分け、3辺に順に適用する。
`a` と `b` の最大公約数は、`b` と `a % b` の最大公約数と同じ。
この置き換えを繰り返し、`b` が0になったときの `a` を返す。
例えば (30, 18) → (18, 12) → (12, 6) → (6, 0) となり、答えは6。
大小関係は最初の置き換えで整うため、ソートは不要。

// 以下のメソッドは `Program` クラス内の、`Main` の外に置く。
static ulong Gcd(ulong a, ulong b)
{
    while (b != 0)
    {
        ulong remainder = a % b;
        a = b;
        b = remainder;
    }

    return a;
}

// `Main` 内では、最初の2辺に `Gcd` を適用し、その結果と3辺目にも適用する。
ulong cubeSide = Gcd(Gcd(sides[0], sides[1]), sides[2]);

// `cubeSide` が立方体の一辺となる。
// 切断回数の計算は、今の `minSide` を `cubeSide` に置き換えれば同じ。
// 計算量は、辺の最大値を `M` とすると O(log M)、追加メモリは O(1)。
*/
#endregion
