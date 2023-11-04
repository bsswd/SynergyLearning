using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Нажмите клавишу: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();


                if (keyInfo.KeyChar == 'w')
                    Console.WriteLine("\nИгрок идет вперед");

                if (keyInfo.KeyChar == 'a')
                    Console.WriteLine("\nИгрок идет влево");

                if (keyInfo.KeyChar == 's')
                    Console.WriteLine("\nИгрок идет назад");

                if (keyInfo.KeyChar == 'd')
                    Console.WriteLine("\nИгрок идет вправо");

                else
                    Console.WriteLine("Для передвижения иcпользуйте WASD");
            }

        }

        
    }
}
