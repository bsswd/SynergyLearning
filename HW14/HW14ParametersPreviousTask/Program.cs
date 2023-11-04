using System;

namespace HW14ParametersPreviousTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Вывести количество отрицательных и положительных чисел в массиве

            int[] numbers = { -20, 1, 51, -85, -9 };
            int numberOfElements = 0;

            ViewNegAndPos(numbers);
            GoToNextTask();

            //2. Создать массив содержащий 10 чисел Фибонначи

            MakeFibonacci(numberOfElements);
            GoToNextTask();

            //3. Отсортировать массив в порядке возрастания

            MakeBubbleSort(numbers);

        }

        static void GoToNextTask()
        {
            Console.WriteLine("\nНажмите Enter для перехода к следущему заданию");
            Console.ReadLine();
        }


        static void ViewNegAndPos(int[] numbers)
        {
            int PosNumber = 0;
            int NegNumber = 0;

            Console.Write("Задание #1\n\n" +
                          "Элементы массива:");

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(" " + numbers[i]);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    NegNumber++;
                else if (numbers[i] > 0)
                    PosNumber++;
            }

            Console.WriteLine($"\nКоличество отрицательных чисел {NegNumber}" +
                              $"\nКоличество положительных чисел {PosNumber}");
        }

        static void MakeFibonacci(int numberOfElements)
        {
            Console.WriteLine("\nЗадание #2\n");
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
            Console.WriteLine();
        }

        static void MakeBubbleSort(int[] numbers)
        {
            int TempVar = 0;

            Console.WriteLine("Задание #3\n");

            Console.Write("Массив до сортировки: ");

            for (int i = 0; i < numbers.Length; i++)
                Console.Write($" {numbers[i]}");

            for (int i = 0; i < numbers.Length; i++)
                for (int j = 0; j < numbers.Length - 1; j++)
                    if (numbers[j] > numbers[j + 1])
                    {
                        TempVar = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = TempVar;
                    }

            Console.Write("\nМассив отсортирован по возрастанию: ");
            for (int i = 0; i < numbers.Length; i++)
                Console.Write($" {numbers[i]}");
        }
    }
}
