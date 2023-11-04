using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GenericDelegates
{
    static class ArraySortExtensions
    {
        public static void SelectionSort<T>(this T[] array, Comparer<T> comparer)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int index = FindIndex(array, i, comparer);

                if (index != i)
                    Swap(ref array[i], ref array[index]);
            }
        }

        private static int FindIndex<T>(T[] array, int from, Comparer<T> comparer)
        {
            int index = from;

            for (int i = from + 1; i < array.Length; i++)
                if (comparer.Invoke(array[index], array[i]))
                    index = i;

            return index;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T cached = a;
            a = b;
            b = cached;
        }

        public static void ForEach<T>(this T[] array, Action<T> action)
        {
            foreach (var item in array)
                action?.Invoke(item);
        }
    }
}
