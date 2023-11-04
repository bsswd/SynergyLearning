namespace HW20Classes
{
    internal class Fish
    {
        public string Name { get; set; }
        public string Type { get; }
        public string Color { get; }
        public int Size { get; }

        public Fish() {}

        public Fish(string name, string type, string color, int size)
        {
            Name = name;
            Type = type;
            Color = color;
            Size = size;
        }
    }
}
