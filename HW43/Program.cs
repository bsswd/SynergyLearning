using System;
using System.Collections;
using System.Collections.Generic;

namespace UserCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 6};

            list.ForEach(Console.WriteLine);
        }
    }
}
