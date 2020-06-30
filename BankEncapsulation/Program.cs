using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            var exitCode = false;

            Console.WriteLine("Hello, Welcome to the Bank");
            Console.WriteLine("Please type \"deposit\" to deposit or \"withdraw\" to withdraw or \"balance\" to see balance or \"exit\" to exit");
            while (!exitCode)
            {
                switch (Console.ReadLine())
                {
                    case "deposit":
                        Console.WriteLine("How much would you like to deposit?");
                        bankAccount.Deposit(double.Parse(Console.ReadLine()));
                        break;
                    case "withdraw":
                        Console.WriteLine("How much would you like to withdraw?");
                        bankAccount.Withdraw(double.Parse(Console.ReadLine()));
                        break;
                    case "balance":
                        Console.WriteLine($"Your balance is {bankAccount.GetBalance()}");
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        exitCode = true;
                        break;
                    default:
                        Console.WriteLine("Command not recognized");
                        break;
                }
                if (!exitCode) { Console.WriteLine("Would you like to do anything else?"); }
            }
        }
    }
}
