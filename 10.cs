using System;

class Program
{
    public static void Main(string[] args)
    {
      int i, N;
      double serie = 1;

      Console.WriteLine("Insira um número: ");
      N = int.Parse(Console.ReadLine());

      for (i = 1; i <= N; i = i + 1)
      {
         serie += 1.0 / Fatorial(i);
      }
      Console.WriteLine($"O valor da soma do inverso dos fatoriais de {N} é igual a {serie}");
    }

    public static int Fatorial(int num)
    {
      int fatorial = 1;
      for (int i = 2; i <= num; i++)
      {
        fatorial *= i;
      }
      return fatorial;
    }

}
