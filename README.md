# AtCoder

C#で取り組んだAtCoderの学習記録です。

## AtCoder Beginners Selection

[AtCoder Beginners Selection（ABS）](https://atcoder.jp/contests/abs)の全11問を解き、ACしました。各フォルダの`Program.cs`に解答を保存しています。

| 問題 | 解答フォルダ |
| --- | --- |
| [PracticeA — Welcome to AtCoder](https://atcoder.jp/contests/abs/tasks/practice_1) | [abs/practicea](abs/practicea) |
| [ABC086A — Product](https://atcoder.jp/contests/abs/tasks/abc086_a) | [abs/abc086a](abs/abc086a) |
| [ABC081A — Placing Marbles](https://atcoder.jp/contests/abs/tasks/abc081_a) | [abs/abc081a](abs/abc081a) |
| [ABC081B — Shift only](https://atcoder.jp/contests/abs/tasks/abc081_b) | [abs/abc081b](abs/abc081b) |
| [ABC087B — Coins](https://atcoder.jp/contests/abs/tasks/abc087_b) | [abs/abc087b](abs/abc087b) |
| [ABC083B — Some Sums](https://atcoder.jp/contests/abs/tasks/abc083_b) | [abs/abc083b](abs/abc083b) |
| [ABC088B — Card Game for Two](https://atcoder.jp/contests/abs/tasks/abc088_b) | [abs/abc088b](abs/abc088b) |
| [ABC085B — Kagami Mochi](https://atcoder.jp/contests/abs/tasks/abc085_b) | [abs/abc085b](abs/abc085b) |
| [ABC085C — Otoshidama](https://atcoder.jp/contests/abs/tasks/abc085_c) | [abs/abc085c](abs/abc085c) |
| [ABC049C — 白昼夢](https://atcoder.jp/contests/abs/tasks/arc065_a) | [abs/abc049c](abs/abc049c) |
| [ABC086C — Traveling](https://atcoder.jp/contests/abs/tasks/arc089_a) | [abs/abc086c](abs/abc086c) |

## 実行環境

- .NET SDK 9.0.305（`global.json`で指定）
- C# 13 / .NET 9

全プロジェクトをビルドする場合:

```sh
dotnet build atcoder.sln
```

個別の解答を実行する場合:

```sh
dotnet run --project abs/abc086c
```

入力をファイルから渡す場合は、各フォルダの`input.txt`に入力を用意します。

```sh
dotnet run --project abs/abc086c < abs/abc086c/input.txt
```
