using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array<int> array = new Array<int>(7,3,-4,6);

            int sum = 0;

            array.ForEach(x => sum += x);

            array.Sort();

            array.ForEach(Console.WriteLine);

        }
    }
}
