using Task3VendingMachine.Orders;

namespace Task3VendingMachine.Commands
{
    class BuyItem : ICommand
    {
        private readonly VendingMachine _vendingMachine;
        private readonly IOrder _order;

        public BuyItem(VendingMachine vendingMachine, IOrder order)
        {
            _vendingMachine = vendingMachine;
            _order = order;
        }
        public void Execute() => _vendingMachine.ProcessOrder(_order);
    }
}
