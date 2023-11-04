using System;
using System.Collections.Generic;

namespace GenericInterfaces
{
    internal class Rapid : ICar<RapidEngine>
    {
        public RapidEngine GetEngine()
        {
            return new RapidEngine();
        }

    }
}
