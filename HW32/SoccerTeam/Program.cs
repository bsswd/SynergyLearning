using System;

namespace Task4SoccerTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: 1. Описать футболиста, у которого есть имя и номер.
            //         Описать футбольную команду, состоящую из 11 футболистов.
            //         Написать индексатор, позволяющий обращаться к игроку в команде.
            //
            //      2. Характеристика футболиста должна конвертироваться в строку,
            //         поместить объект футболиста в Console.WriteLine() и вывести характеристики
            //      
            //      3. В написанном коде сделать так, чтобы не возникала ошибка при
            //         передаче отрицательных индексов и индексов больше 10

            Player[] realMadrid = 
            {
                new Player ("Андрей Лунин",13),
                new Player ("Антонио Рюдигер",22),
                new Player ("Даниэль Карвахаль",2),
                new Player ("Эдер Милитао",3),
                new Player ("Фран Гарсия",20),
                new Player ("Давид Алаба",4),
                new Player ("Начо",6),
                new Player ("Винисиус Жуниор",7),
                new Player ("Эдуардо Камавинга",12),
                new Player ("Тони Кроос",8),
                new Player ("Хоселу",14),
            };

            Team team = new Team(realMadrid);

            ViewTeam();

            void ViewTeam()
            {
                for (int i = 0; i < 10; i++)
                    Console.WriteLine($"Имя: {team[i].Name}, Номер:{team[i].Number}");
            }
        }
    }
}
