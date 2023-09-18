using System;

namespace Task2UsingMethods
{
    class Fibonacci
    {
        public int NumberOfElements = 0;
        public void MakeFibonacci()
        {
            Console.WriteLine("\nЗадание #2\n");
            while (NumberOfElements <= 1)
            {
                Console.Write("Введите количество элементов последовательности Фибоначчи: ");

                try
                {
                    NumberOfElements = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный ввод! Вводите только цифры\n");
                }
            }

            int[] fibonacci = new int[NumberOfElements];
            fibonacci[0] = fibonacci[1] = 1;

            for (int i = 2; i < NumberOfElements; i++)
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];

            Console.Write($"Последовательность Фиббоначи из {NumberOfElements} элементов: ");
            for (int i = 0; i < NumberOfElements; i++)
                Console.Write($" {fibonacci[i]}");
                Console.WriteLine();
        }
    }
}

