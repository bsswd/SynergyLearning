using Task3VendingMachine.Routing;

namespace Task3VendingMachine.Commands
{
    class Login : ICommand
    {
        private readonly Router _router;
        public Login(Router router) => _router = router;
        public void Execute() => _router.Login();
    }
}
