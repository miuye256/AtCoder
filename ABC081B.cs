int N = int.Parse(Console.ReadLine());
int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

while (true)
{
  for (int i = 0; i < N; i++)
  {
    if (A[i] % 2 == 1)
    {
      Console.WriteLine(count);
      return;
    }
    A[i] /= 2;
  }
  
  count++;
}
