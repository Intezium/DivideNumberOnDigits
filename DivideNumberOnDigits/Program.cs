using System;
using System.Collections.Generic;

namespace DivideNumberOnDigits
{
    class Program
    {
        static void DivideNumberOnDigits(int number)
        {
            List<int> numbers = new List<int>();

            if (number > 0)
            {
                for (int i = number; i > 0;)
                {
                    i = DivideNumber(i, 10, out int result);

                    numbers.Add(result);
                }

                Console.Write("\nЦифры числа {0}: ", number);

                numbers.Sort();

                foreach (var i in numbers)
                    Console.Write("{0} ", i);

                Console.WriteLine();
            }
            else
                Console.WriteLine("\nЧисло не может быть меньше 1!");
        }

        static int DivideNumber(int a, int b, out int result)
        {
            result = a % b;
            return a / b;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===>[Деление числа на цифры]<===");
                Console.Write("\nВведите число: ");

                try
                {
                    int number = int.Parse(Console.ReadLine());

                    DivideNumberOnDigits(number);
                }
                catch (FormatException) { Console.WriteLine("\nНекорректное число!"); }
                catch (OverflowException) { Console.WriteLine("\nЧисло не может быть больше {0}!", int.MaxValue); }

                Console.WriteLine("\nEnter - Делить еще");
                Console.WriteLine("Esc - Выйти");

                ConsoleKey inputKey = Console.ReadKey().Key;

                if (inputKey == ConsoleKey.Enter)
                    continue;
                else if (inputKey == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
