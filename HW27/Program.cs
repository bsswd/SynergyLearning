using System;
using System.Data;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             
                Абстрактный класс - класс, в котором объявлен хотя бы один абстрактный элемент (метод, свойство).
                Если в производном классе нужно определить конкретную реализацию элемента (метода, свойства) абстрактного
                класса, то при объявлении элемента указывается ключевое слово override. Абстрактный класс предусматривает
                использование его как базового для других унаследованных классов. В свою очередь, унаследованный класс
                должен реализовать все абстрактные элементы базового абстрактного класса.

             */

            Figure[] figures =
            {
                new Rectangle(5,7),
                new Circle(5),
                new Triangle(3,4,5)
            };

            double sum = 0;

            foreach (Figure figure in figures)
            {
                double figureArea = figure.GetArea();

                sum += figureArea;

                Console.WriteLine($"Area of {figure} = {figureArea}");
            }

            Console.WriteLine($"Sum of all figures = {sum}");
        }
    }
}
