using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int total, i;

    for (i = 10; i <= 150; i = i + 1)
    {
      total = (i*i);

      Console.WriteLine ($"O quadrado do número {i} é igual a {total}");
    }
  
  }
}