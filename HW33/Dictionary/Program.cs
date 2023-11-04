using System;

namespace Task4Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Создать словарь, использующий класс Word,
            //  где Origin - слово, Translate - перевод слова
            //  *определить индексатор для доступа к словарю

            
            Dictionary dictionary = new Dictionary();

            dictionary.AddWord(new Word("Dog", "Собака"));
            dictionary.AddWord(new Word("Cat", "Кошка"));
            dictionary.AddWord(new Word("Rabbit", "Кролик"));

            Console.WriteLine(dictionary["Dog"]);
        }
    }
}
