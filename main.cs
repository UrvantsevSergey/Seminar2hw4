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
  //Console.WriteLine($"{size} {number} ");
    while (size > 0)
    {
      int number2 = number/Math.Pow(10, size - 1);
      Console.Write($",{number2}");
      size--;
    }
  }
}