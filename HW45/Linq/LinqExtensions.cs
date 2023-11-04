using System;
using System.Collections.Generic;

namespace Extensions
{
    public static class LinqExtensions
    {
        public static IEnumerable<TSource> Where<TSource>
            (this IEnumerable<TSource> source, Predicate<TSource> predicate)
        {
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                    yield return item;
            }
        }

        public static int Count<TSource>
            (this IEnumerable<TSource> source, Predicate<TSource> predicate)
        {
            int counter = 0;

            foreach (var item in source)
                if(predicate.Invoke(item))
                    counter++;

            return counter;
        }

        public static IEnumerable<TResult> Select<TSource, TResult>
            (this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var item in source)
                yield return selector.Invoke(item);
        }

        public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
        {
            return new List<TSource>(source);
        }


        public static IEnumerable<TSource> OrderBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> func, IComparer<TKey> comparer=null)
        {
            var comparerObj = comparer is null ? Comparer<TKey>.Default : comparer;

            List<TSource> elements = source.ToList();

            int size = elements.Count;

            for (int i = 0; i < size - 1; i++)
            {
                var index = FindIndex(i, elements, func, comparerObj);
                if (index != i)
                {
                    TSource cached = elements[i];
                    elements[i] = elements[index];
                    elements[index] = cached;
                }

                yield return elements[i];
            }
            yield return elements[size-1];
        }

        private static int FindIndex<TSource, TKey>
            (int from, List<TSource> source, Func<TSource, TKey> func, IComparer<TKey> comparer)
        {
            int index = from;

            for (int i = from+1; i < source.Count; i++)
            {
                var element1 = func.Invoke(source[i]);
                var element2 = func.Invoke(source[index]);

                if(comparer.Compare(element1, element2) < 0)
                    index = i;
            }
            return index;
        }
    }
}


