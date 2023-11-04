using System;

namespace Task3VendingMachine
{
    class VendingItem
    {
        public string Name { get; }
        public int Price { get; }
        public int Quantity { get; set; }
        
        public VendingItem (string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }
}
