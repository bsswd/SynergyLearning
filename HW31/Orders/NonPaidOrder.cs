using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3VendingMachine.Orders
{
    internal class NonPaidOrder : Order
    {
        public NonPaidOrder(VendingItem vendingItem, int quantity) : base(vendingItem, quantity) { }   

        public override int GetCost() => 0;
    }
}
