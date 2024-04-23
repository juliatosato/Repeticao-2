using System;

class Program
{
    public static void Main(string[] args)
    {
      int i, num1, num2, somaImpares = 0;

      Console.WriteLine("Digite o primeiro número: ");
      num1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo número: ");
      num2 = int.Parse(Console.ReadLine());

      int maior = num1 > num2 ? num1 : num2;
      int menor = num1 < num2 ? num1 : num2;

      for (i = menor + 1; i < maior; i++)
      {
        if (i % 2 != 0)
        {
          somaImpares += i;
        }

      }

      Console.WriteLine($"A soma dos números ímpares entre {menor} e {maior} é: {somaImpares}");

    }

}