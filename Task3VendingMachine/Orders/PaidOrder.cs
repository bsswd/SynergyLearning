using System;

namespace Task3VendingMachine.Orders
{
    class PaidOrder : Order
    {
        public PaidOrder(VendingItem vendingItem, int quantity) : base(vendingItem, quantity){}

        public override int GetCost() => Quantity * VendingItem.Price;
    }
}
