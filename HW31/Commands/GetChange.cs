namespace Task3VendingMachine.Commands
{
    class GetChange : ICommand
    {
        private readonly VendingMachine _vendingMachine;


        public GetChange(VendingMachine vendingMachine) => _vendingMachine = vendingMachine; 

        public void Execute() => _vendingMachine.SubtractBalance(_vendingMachine.Balance);
        
    }
}
