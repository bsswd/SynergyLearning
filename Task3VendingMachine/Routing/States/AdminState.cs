using Task3VendingMachine.Orders;

namespace Task3VendingMachine.Routing.States
{
    class AdminState : RouterState
    {
        public AdminState(Router router) : base(router){}

        public override IOrder MakeOrder(Request request)
        {
            VendingItem vendingItem = Router.Machine.GetVendingItemById(request.Parameters[0]);
            return new NonPaidOrder(vendingItem, quantity: request.Parameters[1]);
        }
    }
}
