namespace Properties
{
    class BankAccount
    {

        public Client Client  { get; }

        private static decimal _interestRate = 5;

        public BankAccount(Client client) => Client = client;         

        public double CalculateExtraRate() => (Client.Age + (int)_interestRate) / 100.0d;
    }
}
