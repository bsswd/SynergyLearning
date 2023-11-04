using System;
using System.Collections.Generic;

namespace GenericInterfaces
{
    interface ICar<out T> where T : IEngine
    {
        T GetEngine();
    }
}
