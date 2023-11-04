using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace DLR
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic viewbag = new ExpandoObject();

            viewbag.Value = 25;
            viewbag.Array = new int[] { 1, 2, 3, };
            viewbag.SayHelloTo = (Action<string>)(str => Console.WriteLine($"Hello {str}."));

            viewbag.SayHelloTo.Invoke("World!");




        }

        private static dynamic SomeMethod()
        {
            double percent = new Random().NextDouble()*100;

            if (percent < 50)
                return new Customer() { Name = "Anton"};

            return new Car();
        }
    }

    class Customer
    {
        public string Name { get; set; }
    }

    class Car { }
}
