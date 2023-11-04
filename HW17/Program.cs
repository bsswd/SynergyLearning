using System;
using System.IO;
using System.Linq;

namespace HW17FileAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
              
                1.Файловая система это порядок, определяющий способ организации, хранения и именования
                данных на носителях информации в компьютерах.


                2.Получить доступ к папке по определенному пути можно используя пространство имен System.IO.
                Классы, расположенные в этом пространстве имен(такие как Stream, StreamWriter, FileStream и др.),
                позволяют управлять файловым вводом-выводом.

            */


            string pathToFolder = @"C:\Users\79061\Desktop\HW17";

            if(Directory.Exists(pathToFolder))
            {
                string[] folders = Directory.GetDirectories(pathToFolder);
                string[] files = Directory.GetFiles(pathToFolder);
                
                ViewFolders(folders);

                ViewFiles(files);
            }
        }

        static void ViewFolders(string[] folders)
        {
            Console.WriteLine("Папки:");

            foreach (string folder in folders)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(folder);
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void ViewFiles(string[] files)
        {
            Console.WriteLine("Файлы:");

            foreach (string file in files)
            {
                    if (file.Contains("txt"))
                        Console.ForegroundColor = ConsoleColor.Green;

                    if (file.Contains("prdx"))
                        Console.ForegroundColor = ConsoleColor.Magenta;

                    if (file.Contains("zip"))
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine(file);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
