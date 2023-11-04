using System;
using Extensions;
using System.Collections.Generic;

namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            string query = "1 100 5 7 8 9 100";

            var sequence = query.Split()
                                .Select(int.Parse)
                                .Where(x => x > 5)
                                .OrderBy(x => x);


            foreach (var item in sequence)
            {
                Console.WriteLine(item);
            }
        }

        public static int FindMax(string query)
        {
            var parsed = query.Split();
            int max = int.Parse(parsed[0]);

            for (int i = 1; i < parsed.Length; i++)
            {
                int value = int.Parse(parsed[i]);
                if (max < value)
                    max= value; 
            }
            return max;
        }
    }
}
