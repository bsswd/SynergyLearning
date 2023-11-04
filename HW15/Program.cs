using System;

namespace HW15Exeptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = int.Parse(Console.ReadLine());
                int X = int.Parse(Console.ReadLine());

                int result = a / X;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль в нашей Вселенной пока нельзя");
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}
