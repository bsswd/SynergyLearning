using System;

namespace Task2UsingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Вывести количество отрицательных и положительных чисел в массиве
            NegAndPos negAndPos = new NegAndPos();
            negAndPos.ViewNegAndPos();

            GoToNextTask();

            //2. Создать массив содержащий 10 чисел Фибонначи
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.MakeFibonacci();

            GoToNextTask();

            //3. Отсортировать массив в порядке возрастания
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.MakeBubbleSort();

            Console.WriteLine("\n\nХорошего дня! Для выхода нажмите Enter");
            Console.ReadLine();
        }

        static void GoToNextTask()
        {
            Console.WriteLine("\nНажмите Enter для перехода к следущему заданию");
            Console.ReadLine();
        }
    }
}
