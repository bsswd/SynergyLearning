using System;
using System.Threading;
using Task3VendingMachine.Commands;
using Task3VendingMachine.Routing;

namespace Task3VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine(0, new VendingItem("Энергоячейка для бластера ЭБ-48М/25МВ", 50, 23),
                                                                  new VendingItem("Молоко деревенско-космическое М-1/0.45л", 5, 15),
                                                                  new VendingItem("Журнал 'Космический рабочий' Январь-2168г", 10, 99));

            ICommandInput input = new ConsoleCommandInput(new Router(vendingMachine));

            while (true)
            {   
                Console.Clear();
                Console.WriteLine("\tДобро пожаловать в систему обеспечения космического корабля ОКФСС линкор 'Николай Рукавишников'!\n\n");
                Console.WriteLine($"Текущий счет: {vendingMachine.Balance} кр.");
                Console.WriteLine("Введите команду: ");

                ICommand command = input.GetCommand();
                Console.WriteLine();

                if (command is null )
                {
                    Console.WriteLine("Нераспознанная команда");
                    Thread.Sleep(2000);
                    continue;
                }

                try
                {
                    command.Execute();
                }
                catch (Exception ex)  
                {
                    Console.WriteLine($"Возникла проблема " +
                                      $"\nСообщение: {ex.Message}");
                    Thread.Sleep(2000);
                    continue;
                }

                Console.WriteLine("\nКоманда выполнена. Нажмите ВВОД.");
                Console.ReadKey();
            }
        }
    }
}
