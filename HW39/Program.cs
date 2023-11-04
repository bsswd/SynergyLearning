using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Под коллизией понимается ситуация, когда при добавлении разных объектов мы попадаем в одну и ту же
            //ячейку массива. Для разрешения коллизий придумано 2 метода: метод цепочек и метод открытой адресации.
            //Метод цепочек. Метод цепочек является наиболее простым методом разрешения коллизий.
            //В ячейке массива мы будем хранить не элементы, а связанный список данных элементов.


            List<int> list = new List<int>(16)
            {
                1,2, 3, 4,5,6
            };

            Stack<string> stack = new Stack<string>();

            stack.Push("abc");
            stack.Push("cbd");

            string value = stack.Pop();

            // foreach (var item in stack)
            //     Console.WriteLine(item);

            //Console.WriteLine($"Удаленное: {value}");

            list.Add(100);

            list.Sort();

            //list.ForEach(Console.WriteLine);


            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"Poland", "Warsaw"},
                {"France", "Paris"},
                {"Great Britain", "London"},
                {"Czech", "Prague"},
                {"Russia", "Moscow"}
            };

            dictionary.Add("Ukraine", "Kiev");
            dictionary["USA"] = "Washington";
            dictionary["USA"] = "New York";

            dictionary.Remove("Ukraine");


            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }
        }
    }
}
