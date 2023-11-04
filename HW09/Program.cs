using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //а. Бинарные арифметические операции

            // Сложение +
            
            int a = 5;
            int b = a + 2; // 7

            // Вычитание -

            int c = b - a; // 2

            // Умножение *

            int m = c * b; // 14

            // Деление /

            int d = m / c; // 7
            int d2 = d / c; // 3

            double q = 7;
            double e = 3;

            double t = q / e; // 2.33333333333

            double s = 10 / 4; // 2
            double p = 10.0 / 4.0; // 2.5

            // Получение остатка %

            int o = c % m; // 2


            //б. Операции присваивания

            int x = 2;
            int x1 = 0;
            int x2 = 1;

            x = x1;

            x = x1 = x2;

            x = (x1 + 2)/x2;

            x += 2;
            x -= 1;
            x *= 4;
            x /= 2;
            x %= 3;


            // в. Логические операции

            // Логическое умножение &

            int y1 = 4; //100
            int y2 = 5; //101
                        //100    

            int y3 = y1 & y2; //4 

            // Логическое сложение |

            int y4 = 3; //011
            int y5 = 5; //101
                        //111

            int y6 = y4 | y5; //7

            // Логическое исключающее Или ^ (XOR)

            int password = 45; //0101101
            int key = 102;     //1100110
                               //1001011

            int encrypt = password ^ key; //75
            int decrypt = encrypt ^ key; //45

            // Логическое отрицание ~ (Инверсия)

            int number = 14; //0000 1110
                             //1111 0001

            int inversedNumber = ~number;


            //г. Операции сдвига

            int valueToShift = 4; //0000 0100 Число, которое будем сдвигать
            int shift = 1; // На сколько будем сдвигать

            int shiftLeft = valueToShift << shift;   //0000 1000
            int shiftRight = valueToShift >> shift;  //0000 0010


            //д. Преобразования типов

            byte f1 = 4;
            int f2 = f1 + 100;
            int f3 = 4;

            //byte - 1 байт
            //int - 4 байта

            byte f5 = (byte)(f3 + 2);

            // Расширяющеся преобразование 

            byte h1 = 5;   //0000 0101
            short h2 = h1; // 0000 0000 0000 0101         неявное

            // Сужающиеся преобразования

            short h3 = 5;       // 0000 0000 0000 0101
            byte h4 = (byte)h3;  // 0000 0101             явное 


            // Приоритеты операций

            int o1 = 27;
            int o2 = 42;
            int o3 = 23;
            int o4 = 18;

            int result = o1 + o2 - o1 * (o3 + o4);

            Console.WriteLine(result); // - 1038

            // 1. 23 + 18 = 41
            // 2. 41 * 27 = 1107
            // 3. 27 + 42 = 69
            // 4. 69 - 1107 = - 1038

        }
    }
}
