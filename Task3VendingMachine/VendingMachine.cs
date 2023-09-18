using System;
using System.Runtime.Remoting.Messaging;
using Task3VendingMachine.Orders;

namespace Task3VendingMachine
{
    class VendingMachine
    {
        public int Balance { get; private set; }

        private VendingItem[] _vendingItems;

        public VendingMachine(int balance, params VendingItem[] vendingItems)
        {
            Balance = balance;
            _vendingItems = vendingItems;
        }

        public void AddBalance(int balanceAdd)
        {
            if (balanceAdd < 0)
                throw new ArgumentOutOfRangeException("Баланс не может быть отрицательным");

            Balance += balanceAdd;
        }

        public void SubtractBalance(int balanceSubtract)
        {
            if (balanceSubtract < 0 && Balance >= balanceSubtract)
                throw new ArgumentOutOfRangeException("Баланс не может быть отрицательным");

            Balance -= balanceSubtract;
        }

        public bool IsFilled(int id) => id >=0 && id < _vendingItems.Length;

        public VendingItem GetVendingItemById(int id)
        {
            if (!IsFilled(id))
                throw new ArgumentOutOfRangeException("Неверный артикул");
            
            return _vendingItems[id];
        }

        public void ProcessOrder(IOrder order)
        {
            TryToOrder(order, out bool isSuccess);

            if (!isSuccess)
                throw new ArgumentException("Невозможно совершить покупку");
        }

        public void TryToOrder(IOrder order, out bool isSuccess)
        {
            isSuccess = IsOrderPossible(order);

            if (!isSuccess)
                return;

            SubtractBalance(order.GetCost());
            order.Process();
        }

        private bool IsOrderPossible(IOrder order)
        {
            return order.Available && order.GetCost() <= Balance;
        }
    }
}
