using Task3VendingMachine.Orders;

namespace Task3VendingMachine.Routing.States
{
    class CustomerState : RouterState
    {
        public CustomerState(Router router) : base(router) { }

        public override IOrder MakeOrder(Request request)
        {
            VendingItem vendingItem = Router.Machine.GetVendingItemById(request.Parameters[0]);
            return new PaidOrder(vendingItem, quantity: request.Parameters[1]);
        }
    }
}
