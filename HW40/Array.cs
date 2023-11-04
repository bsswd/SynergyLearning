using System;

namespace Generics
{
    public class Array<T> where T : IComparable<T>
    {
        private T[] _items;

        public Array(int size) => _items = new T[size];

        public Array(params T[] array) => _items = array;

        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        public void Add(T item)
        {
            int size = _items.Length;

            T[] newItems = new T[size+1];

            for (int i = 0; i < size; i++)
                newItems[i] = _items[i];

            newItems[size] = item;

            _items = newItems;
        }

        public void ForEach(Action<T> action)
        {
            foreach (var item in _items)
            {
                action?.Invoke(item);
            }
        }

        public void Sort()
        {
            for (int i = 0; i < _items.Length - 1; i++)
                for (int j = i + 1; j < _items.Length; j++)
                    if (_items[i].CompareTo(_items[j]) > 0)
                    {
                        T cachedElements = _items[i];
                        _items[i] = _items[j];
                        _items[j] = cachedElements;
                    }
        }
    }
}
