using Task3VendingMachine.Routing;

namespace Task3VendingMachine.Commands
{
    class Logout : ICommand
    {
        private readonly Router _router;
        public Logout(Router router) => _router = router;
        public void Execute() => _router.Logout();
    }
}
