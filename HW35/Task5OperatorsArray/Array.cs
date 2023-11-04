using System;

namespace Task5OperatorsArray
{
    class Array
    {
        public int Length => _array.Length;
        private int[] _array;

        public Array(int size) => _array = new int[size];

        public Array(params int[] array) => _array = array;

        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public static Array operator +(Array lhs, Array rhs) => CalculateElements(lhs,rhs, (x,y) => x + y);
        public static Array operator -(Array lhs, Array rhs) => CalculateElements(lhs, rhs, (x, y) => x - y);
        public static Array operator *(Array lhs, Array rhs) => CalculateElements(lhs, rhs, (x, y) => x * y);
        public static Array operator /(Array lhs, Array rhs) => CalculateElements(lhs, rhs, (x, y) => x / y);
        public static Array operator %(Array lhs, Array rhs) => CalculateElements(lhs, rhs, (x, y) => x % y);

        public static Array CalculateElements(Array lhs, Array rhs, Func<int, int, int> operation)
        {
            Array minArray = lhs.Length > rhs.Length ? rhs : lhs;
            Array maxArray = ReferenceEquals(minArray, lhs) ? rhs : lhs;

            Array resultArray = new Array(maxArray.Length);

            for (int i = 0; i<maxArray.Length; i++)
            {
                if (i >= minArray.Length)
                {
                    resultArray[i] = maxArray[i];
                    continue;
                }

                resultArray[i] = operation.Invoke(lhs[i], rhs[i]);
            }

            return resultArray;
        }

        public void Print()
        {
            foreach (int item in _array)
                Console.Write($"{item} ");
        }
    }
}
