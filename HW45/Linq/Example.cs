using System;
using System.Linq;

public class Example
{
    public static int FindMax(string query)
    {
        return query.Split()
                    .Select(int.Parse)
                    .Max();
    }
}
