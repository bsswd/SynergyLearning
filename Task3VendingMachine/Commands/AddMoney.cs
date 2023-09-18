namespace Task3VendingMachine.Commands
{
    class AddMoney : ICommand
    {
        private readonly VendingMachine _vendingMachine;
        private readonly int _moneyToAdd;

        public AddMoney(VendingMachine vendingMachine, int moneyToAdd)
        {
            _vendingMachine = vendingMachine;
            _moneyToAdd = moneyToAdd;
        }
        public void Execute() => _vendingMachine.AddBalance(_moneyToAdd);
    }
}
