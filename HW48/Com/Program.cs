using System;
using System.Runtime.InteropServices;

namespace Com
{
   class Program
    {

       /* 
            1.	COM - Microsoft Component Object Model(COM) — это независимая от платформы распределенная
                объектно-ориентированная система для создания двоичных программных компонентов, которые могут
                взаимодействовать.COM — это базовая технология ole(составные документы), 
                ActiveX(компоненты с поддержкой Интернета) корпорации Майкрософт, а также другие.

            2.	Aтрибут DllImport с именем библиотеки, указывает среде исполнения.NET, что функцию надо импортировать
                из динамической библиотеки.
       */


        [DllImport("NativeLibraryCPP.dll")]
        public static extern void SayHello();

        static void Main(string[] args)
        {
            SayHello();
        }
    }
}
