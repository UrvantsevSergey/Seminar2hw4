using System;

class Program 
{
  public static void Main (string[] args)
  {
    Console.Write("Введите число: ");
    string number = Convert.ToString(Console.ReadLine());
    int size = number.Length;
    int n = size;
    while (n >= size)
    {
      Console.Write($"{number[n - size]}, ");
      size--;
    }
  }
}