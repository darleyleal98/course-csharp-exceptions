using System;
using System.Text;
using ExceptionsCourse;
using ExceptionsCourse.Bank;
using ExceptionsCourse.Entities.Exceptions;

namespace ExceptionsCourse.Bank
{
    public class Account
    {
        private int Number { get; set; }
        private string Holder { get; set; }
        private double Balance { get; set; }
        private double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }
        public void Deposit(double amount) => Balance += amount;
        public void WithDraw(double amount)
        {
            if (Balance == 0)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit!");
            }
            if (amount > WithDrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit!");
            }
            Balance -= amount;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"New balance: {Balance:c}");
            return stringBuilder.ToString();
        }
    }
}
