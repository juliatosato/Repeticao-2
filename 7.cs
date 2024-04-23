using System;

class Program
{
    public static void Main(string[] args)
    {
      float total = 0, i;
      int N;

      Console.WriteLine($"Digite um número: ");
      N = int.Parse(Console.ReadLine());

      for (i = 1; i <= N; i++)
      {
        total = total + 1 / i;
        Console.WriteLine($"O valor da soma é igual a {total}");

      }

    }

}
