namespace Task3VendingMachine.Orders
{
    interface IOrder
    {
        bool Available { get; }
        int GetCost();
        void Process();
    }
}
