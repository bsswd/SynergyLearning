using System;
using System.Collections.Generic;

namespace GenericInterfaces
{
    class FruitCollection<T> : IFruitCollection<T> where T : IFruit
    {
        public void Add(T fruit)
        {
        }
    }
}
