using System;

class Program
{
    public static void Main(string[] args)
    {
      int total = 0, i, num;
      Console.WriteLine($"Digite o número que quer saber a tabuada: ");
      num = int.Parse(Console.ReadLine());
      
      for (i = 1; i <= 10; i++)
      {
        total = num * i;
        Console.WriteLine($"{num} x {i} = {total}");
      }

    }

}
