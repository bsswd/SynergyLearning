using System;
using System.Collections.Generic;

namespace GenericInterfaces
{
    interface IFruitCollection<in T> where T : IFruit
    {
        void Add(T fruit);
    }
}
