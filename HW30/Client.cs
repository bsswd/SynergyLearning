using System;

namespace Properties
{
    internal class Client
    {
        private int _age;

        public string Name { get; set; } = "Default";

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Age must be higher than zero");
                _age = value;
            }
        }
    }
     
}
