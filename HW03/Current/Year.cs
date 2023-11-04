using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("YearUnitTest")]

namespace Current
{
    internal class Year
    {
        private static void Main()
        {
            Console.WriteLine(GetCurrentYear());
        }

        public static int GetCurrentYear() => DateTime.Now.Year;
    }
}

namespace AnotherYear
{
    class Year
    {
        
    }
}
