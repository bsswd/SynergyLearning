using System;
using System.Collections.Generic;

namespace GenericInterfaces
{

    //инвариантность: тип = тип
    //ковариантность: общий тип = конкретный тип
    //контрвариантость: конкретный тип = общий тип
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Unit unit = new Archer();

            IEnumerable<Unit> units = new List<Archer>();
            
            Rapid rapid = new Rapid();

            ICar<RapidEngine> rapidEngine = rapid;

            ICar<IEngine> car = new Rapid();
            
            car.GetEngine().Start();

            IFruitCollection<Apple> fruits = new FruitCollection<IFruit>();

        }
    }
}
