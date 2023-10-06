using System;

namespace Task5OperatorsVillage
{
    public class Village
    {
        private int _population;
        private int _area;

        public int Population
        {
            get => _population;
            set => _population = value;
        }

        public int Area
        {
            get => _area;
            set=> _area = value;
        }

        public Village(int population, int area)
        {
            _population = population;
            _area = area;
        }

        #region Operators
        public static Village operator +(Village villageA, Village villageB) => Addition(villageA, villageB);
        public static Village operator *(Village village, int value) => Multiply(village, value);
        public static bool operator >(Village villageA, Village villageB) => MoreOrLess(villageA, villageB);
        public static bool operator <(Village villageA, Village villageB) => MoreOrLess(villageA, villageB);
        public static bool operator ==(Village villageA, Village villageB) => Equals(villageA, villageB);
        public static bool operator !=(Village villageA, Village villageB) => !Equals(villageA, villageB);
        #endregion


        public static Village Addition(Village villageA, Village villageB)
        {
            Village villageResult = new Village(0, 0);

            villageResult.Population = villageA.Population + villageB.Population;
            villageResult.Area = villageA.Area + villageB.Area;

            return villageResult;
        }

        public static Village Multiply(Village village, int value)
        {
            Village villageResult = new Village(0, 0);
            
            villageResult.Population = village.Population * value;
            villageResult.Area = village.Area * value;

            return villageResult;
        }

        public static bool MoreOrLess(Village villageA, Village villageB)
        {
            if(villageA.Population > villageB.Population)
                return true;
            else
                return false;
        }

        public static bool Equals(Village villageA, Village villageB)
        {
            if (villageA.Population == villageB.Population)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"Население:{Population}, Площадь:{Area}"; 
        }

    }
}
