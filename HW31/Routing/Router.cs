using Task3VendingMachine.Commands;
using Task3VendingMachine.Routing.States;

namespace Task3VendingMachine.Routing
{
    class Router
    {
        public VendingMachine Machine { get; }
        private RouterState _state;

        public Router(VendingMachine machine)
        {
            Machine = machine;
            _state = new CustomerState(this);
        }

        public ICommand CreateCommand(Request request)
        {
            switch (request.Command)
            {
                case nameof(AddMoney):
                     if(request.IsIncorrectParametersCount(1)) return null;
                     return new AddMoney(Machine, request.Parameters[0]);

                case nameof(BuyItem):
                     if (request.IsIncorrectParametersCount(2)) return null;
                     return new BuyItem(Machine, _state.MakeOrder(request));

                case nameof(GetChange):
                     if (request.IsIncorrectParametersCount(0)) return null;
                     return new GetChange(Machine);

                case nameof(Commands.Login):
                     if (request.IsIncorrectParametersCount(0)) return null;
                     return new Login(this);

                case nameof(Commands.Logout):
                     if (request.IsIncorrectParametersCount(0)) return null;
                     return new Logout(this);

                case nameof(ShowCommands):
                     if (request.IsIncorrectParametersCount(0)) return null;
                     return new ShowCommands(nameof(AddMoney), nameof(BuyItem),
                            nameof(GetChange), nameof(Commands.Login),
                            nameof(Commands.Logout), nameof(ShowCommands));

                default:
                     return null;
            }
        }

        public void Login() => _state = new AdminState(this);
        public void Logout() => _state = new CustomerState(this);
    }
}
