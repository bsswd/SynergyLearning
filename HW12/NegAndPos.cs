using System;

namespace Task2UsingMethods
{
    internal class NegAndPos
    {
        public int[] Numbers = new int[] { -20, 1, 51, -85, -9 };
        public int PosNumber = 0;
        public int NegNumber = 0;
        public void ViewNegAndPos()
        { 
            Console.Write("Задание #1\n\n" +
                          "Элементы массива:");

            for (int i = 0; i < Numbers.Length; i++)
                Console.Write(" " + Numbers[i]);

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] < 0)
                    NegNumber++;
                else if (Numbers[i] > 0)
                    PosNumber++;
            }

            Console.WriteLine($"\nКоличество отрицательных чисел {NegNumber}" +
                              $"\nКоличество положительных чисел {PosNumber}");
        }
    }
}
