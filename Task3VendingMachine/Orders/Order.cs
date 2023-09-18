using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3VendingMachine.Orders
{
    abstract class Order : IOrder
    {
        protected readonly VendingItem VendingItem;
        protected readonly int Quantity;

        public Order (VendingItem vendingItem, int quantity)
        {
            if (quantity < 0)
                throw new ArgumentOutOfRangeException("Количество товара не может быть отрицательным");

            VendingItem = vendingItem;
            Quantity = quantity;
        }

        public bool Available => Quantity <= VendingItem.Quantity;

        public abstract int GetCost();

        public void Process() => VendingItem.Quantity -= Quantity;
    }
}
