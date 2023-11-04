using System;
using System.IO;
using System.Text;

namespace HW18Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
                1.	Чтение файлов это получение доступа к информации расположенной внутри файла

                2.	Запись файлов это изменение информации расположенной внутри файла
             
            */


            string path = @"C:\Users\79061\Desktop";
            string textToWrite = "У Дмитрия Евгеньевича сегодня день рождения. Давайте соберемся в 18:00 и поздравим.";

            WriteTextInFile(textToWrite, $@"{path}\URGENT.txt");
        }

        static void WriteTextInFile(string textToWrite, string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textToWrite);
                fileStream.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
