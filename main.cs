using System;

class Program 
{
  public static void Main (string[] args)
  {
//    Console.Write("Введите число: ");
//    string number = Convert.ToString(Console.ReadLine());
//    int size = number.Length;
//    int n = size;
//    while (n >= size)
//    {
//      Console.Write($"{number[n - size]}, ");
//      size--;
//    }
//  }
//}

  Console.WriteLine("Введите число: ");
  int number = Convert.ToInt32(Console.ReadLine());
  int size = number.ToString().Length;
  Console.WriteLine($"{size} {number} ");
  }
}