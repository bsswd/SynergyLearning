using Task3VendingMachine.Orders;

namespace Task3VendingMachine.Routing.States
{
    abstract class RouterState
    {
        protected readonly Router Router;
        protected RouterState(Router router) => Router = router;
        public abstract IOrder MakeOrder(Request request);
    }
}
