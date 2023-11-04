using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW14Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Amy";
            string name2 = "Kate";
            int age1 = 22;
            int age2 = 26;


            ViewInfo("Jane", 24);
            ViewInfo(name1, age1);
            ViewInfo("Debby", age1+6);

            ViewInfo(ref name2, ref age2);

        }

        static void ViewInfo(ref string name, ref int age) => Console.WriteLine($"{age}, {name}");
        static void ViewInfo(string name, int age) => Console.WriteLine($"Name: {name}, age: {age}");
    }
}
