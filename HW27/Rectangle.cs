using System;

namespace Abstract
{
    internal class Rectangle : Figure
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double GetArea()
        {
            return _width * _height;
        }
    }
}
