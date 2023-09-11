using System;

namespace Task2Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Вывести количество отрицательных и положительных чисел в массиве

            int[] numbers = new int[] { -20, 1, 51, -85, -9 };
            int posNumber = 0;
            int negNumber = 0;

            Console.Write("Задание #1\n\n" +
                          "Элементы массива:");

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(" " + numbers[i]);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    negNumber++;
                else if (numbers[i] > 0)
                    posNumber++;
            }

            Console.WriteLine($"\nКоличество отрицательных чисел {negNumber}" +
                              $"\nКоличество положительных чисел {posNumber}");

            //2. Создать массив содержащий 10 чисел Фибонначи
            // Числа Фибоначчи: каждое последующее число равно сумме двух предыдущих чисел:
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
            // Вручную числа класть нельзя, их надо генерировать

            Console.WriteLine("\nЗадание #2\n");

            int numberOfElements = 0;

            while (numberOfElements <= 1)
            {
                Console.Write("Введите количество элементов последовательности Фибоначчи: ");

                try
                {
                    numberOfElements = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный ввод! Вводите только цифры\n");
                }
            }

            int[] fibonacci = new int[numberOfElements];
            fibonacci[0] = fibonacci[1] = 1;

            for (int i = 2; i < numberOfElements; i++)
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];

            Console.Write($"Последовательность Фиббоначи из {numberOfElements} элементов: ");
            for (int i = 0; i < numberOfElements; i++)
                Console.Write($" {fibonacci[i]}");

            Console.WriteLine("\n\nНажмите любую клавишу для перехода к следущему заданию");
            Console.ReadLine();


            //3. Отсортировать массив в порядке возрастания

            Console.WriteLine("Задание #3\n");

            int[] values = new int[5] { 6, 31, 1, 45, 54 };     // Исходный массив
            int tempVar = 0;                                    // Временная переменная для сортировки       

            Console.Write("Массив до сортировки: ");
            for (int i = 0; i < values.Length; i++)
                Console.Write($" {values[i]}");

            for (int i = 0; i < values.Length; i++)
                for (int j = 0; j < values.Length - 1; j++)
                    if (values[j] > values[j + 1])
                    {
                        tempVar = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = tempVar;
                    }

            Console.Write("\nМассив отсортирован по возрастанию: ");
            for (int i = 0; i < values.Length; i++)
                Console.Write($" {values[i]}");

            Console.WriteLine("\n\nХорошего дня! Для выхода нажмите любую клавишу");
            Console.ReadLine();
        }
    }
}
