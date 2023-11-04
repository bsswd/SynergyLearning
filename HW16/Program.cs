﻿using System;

namespace HW16CustomExeptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              1.Выброс исключений это процесс создания исключительной ситуации в программе.
              Когда происходит такая ситуация, код программы создает специальный объект исключения и "выбрасывает" его,
              чтобы сообщить об ошибке или нестандартной ситуации.


              2.Оператор это элемент языка программирования, который выполняет определенное математической
              или логическое действие с одним(унарный оператор), двумя(бинарный оператор), операндами.

            */

            int waterCapacity = 2000;
            int waterAdd = 500;
            int waterCurrent = 0;

            if (waterAdd < 0)
                throw new ArgumentException("Значение не может быть отрицательным");

            waterCurrent = waterCapacity + waterAdd;
        }
    }
}