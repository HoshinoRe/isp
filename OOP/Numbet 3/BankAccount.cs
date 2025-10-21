using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ConsoleApp22
{
    class BankAccount
    {
        private string Owner;
        private double Balance;

        public BankAccount(string accOwner, double accBalance)
        {
            Owner = accOwner;

            if (accBalance >= 0)
            {
                Balance = accBalance;
            }
            else
            {
                Balance = 0;
                Console.WriteLine("Баланс не может быть отрицательным!");
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
            else
            {
                Console.WriteLine("Сумма должна быть больше 0!");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Недостаточно средств!");
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
            else
            {
                Console.WriteLine("Сумма должна быть больше 0!");
            }
        }
    }
}