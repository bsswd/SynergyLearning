using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GenericDelegates
{
    delegate Fruit FruitCreator();

    delegate T Func<out T>();

    internal class Program
    {
        static void Main(string[] args)
        {
            // Array sort
            
            double a = 25.3;
            double b = 34.2;

            ArraySortExtensions.Swap(ref a, ref b);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int[] array = { 2, -5, 1, 3 };


            array.ForEach(Console.WriteLine);

            // Fruits

            FruitCreator fruitCreator = CreateApple;

            fruitCreator.Invoke().Eat();

            Func<Apple> appleCreator = CreateApple;

            Func<Fruit> func1 = appleCreator;

            Func<Fruit> func = CreateBanana;

            func.Invoke().Eat();

            Apple[] apples = { new Apple(25), new Apple(67), new Apple(12) };
            Banana[] bananas = { new Banana(56), new Banana(17) };

            Comparer<Fruit> comparer = (c,d) => c.Price > d.Price;

            apples.SelectionSort<Apple>(comparer);
            bananas.SelectionSort<Banana>(comparer);

            apples.ForEach(x => Console.WriteLine(x.Price));
            bananas.ForEach(x => Console.WriteLine(x.Price));
        }

        private static Apple CreateApple()
        {
            return new Apple(20);
        }

        private static Banana CreateBanana()
        {
            return new Banana(40);
        }


    }

    delegate bool Comparer<in T>(T obj1, T obj2);

    abstract class Fruit
    {
        public abstract int Price { get; protected set; }
        public abstract void Eat();

        protected Fruit(int price) => Price = price;
    }

    class Apple : Fruit
    {
        public override int Price { get; protected set; }

        public Apple(int price) : base(price) { }  

        public override void Eat()
        {
            Console.WriteLine("Apple was eaten");
        }

    }

    class Banana : Fruit
    {
        public override int Price { get; protected set; }

        public Banana(int price) : base(price) { } 

        public override void Eat()
        {
            Console.WriteLine("Banana was eaten");
        }

    }

}
