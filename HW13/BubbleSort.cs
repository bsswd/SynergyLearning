using System;

namespace Task2UsingMethods
{
    class BubbleSort
    {
        public int[] Values = new int[5] { 6, 31, 1, 45, 54 };     
        public int TempVar = 0;

        public void MakeBubbleSort()
        {
            Console.WriteLine("Задание #3\n");

            Console.Write("Массив до сортировки: ");

            for (int i = 0; i < Values.Length; i++)
                Console.Write($" {Values[i]}");

            for (int i = 0; i < Values.Length; i++)
                for (int j = 0; j < Values.Length - 1; j++)
                    if (Values[j] > Values[j + 1])
                    {
                        TempVar = Values[j];
                        Values[j] = Values[j + 1];
                        Values[j + 1] = TempVar;
                    }

            Console.Write("\nМассив отсортирован по возрастанию: ");
            for (int i = 0; i < Values.Length; i++)
                Console.Write($" {Values[i]}");
        }
    }
}
