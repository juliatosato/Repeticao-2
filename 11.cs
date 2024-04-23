using System;

class Program
{
    public static void Main(string[] args)
    {
      int N;

      Console.WriteLine("Insira um número: ");
      N = int.Parse(Console.ReadLine());

      Console.WriteLine("Série de Fibonacci: ");

      Fibonacci(N);

    }

    public static void Fibonacci(int N)
    {
      int primeirotermo = 1;
      int segundotermo = 1;
      int i;

      Console.WriteLine($"{primeirotermo} \n{segundotermo}");

      for (i = 3; i <= N; i++)
      {
        int proximotermo = primeirotermo + segundotermo;
        Console.WriteLine($"{proximotermo}");

        primeirotermo = segundotermo;
        segundotermo = proximotermo;

      }
    }

}


