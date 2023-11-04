using System;


namespace Abstract
{
    internal class Triangle : Figure
    {
        
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            if (!CheckTriangleExistance(a, b, c))
                throw new ArgumentException("Triangle not exist");

            _a = a;
            _b = b;
            _c = c;
        }

        public override double GetArea()
        {
            double p = (_a + _b + _c) / 2.0d;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));                              
        }

        private bool CheckTriangleExistance(double a, double b, double c)
        {
            return (a < b + c) && (b < a + c) && (c < a + b);
        }
    }
}
