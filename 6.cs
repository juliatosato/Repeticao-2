using System;

class Program
{
    public static void Main(string[] args)
    {
        int total = 1, i, num;
        Console.WriteLine("Digite o número que quer saber o fatorial: ");
        num = int.Parse(Console.ReadLine());

        for (i = 1; i <= num; i++)
        {
            total = total * (i);
        }
      Console.WriteLine($"O fatorial de {num} é igual a {total}");

    }

}
