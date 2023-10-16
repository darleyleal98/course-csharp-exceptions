using ExceptionsCourse.Bank;
using ExceptionsCourse.Entities;
using ExceptionsCourse.Entities.Exceptions;
using System;

namespace ExceptionCourse
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string name = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine());

                Account account = new Account(number, name, balance, limit);

                Console.Write("Enter amount for withdraw: ");
                double value = double.Parse(Console.ReadLine());
                account.WithDraw(value);

                Console.WriteLine(account.ToString());
            }
            catch (DomainException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}