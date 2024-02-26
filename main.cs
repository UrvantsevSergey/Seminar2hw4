using System;

class Program 
{
  public static void Main (string[] args)
  {
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    // функция подсчёта колличествп символов в введённом чтсле (с параметром с возвращаемым результатом)
    int NumberSize(int number)
    {
      int size = 0;
      for (int i = 0; number != 0; i++)
      {
         number = number/10;
         size++;
      }
      return size;
    }
    // функция печати без последнего числа
    void PrintWOutLast(int number)
    {
      int number2 = 0;
      for (int i = 1; i < NumberSize(number); i++)
      {
        number2 = number / (int) Math.Pow(10, NumberSize(number) - i);
        Console.Write($"{number2%10}, ");
      }
    }
    // печать последнего числа, без запятой
    int number3 = 0;
    number3 = number%10;
    PrintWOutLast(number);
    Console.Write($"{number3}");
  }
} 