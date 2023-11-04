using System;

namespace HW10Array
{
    internal class Program
    {
        //Массив – это область памяти, в которой хранятся данные определенного типа в определенном порядке

        static void Main(string[] args)
        {
            int[,,] array3d =
            {
                {
                    {1}, {2} , {3}
                },

                {
                    {4}, {5} , {6}
                },

                {
                    {7}, {8} , {9}
                },

            };


            for (int i = 0; i < array3d.GetLength(0); i++)
            {
                for (int j = 0; j < array3d.GetLength(1); j++)
                    for(int k = 0; k < array3d.GetLength(2); k++)
                        Console.WriteLine(array3d[i,j,k]);
            }
        }
    }
}
