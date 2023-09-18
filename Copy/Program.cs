using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekPay = 100;

            for (int i = 0; i < 16; i++)
            {
                weekPay += 100*i;
            }

            Console.WriteLine(weekPay);
        }
    }
}
