using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5OperatorsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Создать класс представляющий массив
            //  Объекты такого класса можно складывать, вычитать, умножать, делить, брать остаток от деления
            //  В результате работы этих операций должен возвращаться новый такой массив.
            //  Если массивы разной длины, то возвращаться должен новый массив с длиной большего из них.
            //  (Над лишними элементами операции не выполняются - они просто помещаются в новый массив)
            //  Написать метод Print, выводящий на консоль все элементы массива.

            Array array1 = new Array(23,34,56,36);
            Array array2 = new Array(11,5,77);

            Console.WriteLine("Первый массив: ");
            array1.Print();
            Console.WriteLine("\nВторой массив: ");
            array2.Print();


            Console.WriteLine("\n\nСложение: ");
            (array1 + array2).Print();
            Console.WriteLine("\nВычитание: ");
            (array1 - array2).Print();
            Console.WriteLine("\nУмножение: ");
            (array1 * array2).Print();
            Console.WriteLine("\nДеление: ");
            (array1 / array2).Print();
            Console.WriteLine("\nОстаток от деления: ");
            (array1 % array2).Print();




        }
    }
}
