using System;
using System.Runtime.ConstrainedExecution;

namespace BankManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Address address1 = new Address(7,28,"Dhaka");
            Account account1 = new Account("Habib", 7000, address1);
            account1.ShowAccountInformation();
            account1.Withdraw(500);
            account1.Deposit(500);
            account1.Transfer(account1, 500);

            Account account2 = new Account("Intiaz",4000,new Address(7,17,"Rangpur"));
            account2.ShowAccountInformation();

            Bank ourBank = new Bank("GH bank", 5);
            ourBank.AddAccount(new Account("Dev", 3000, new Address(10, 14, "Dhaka")));
            ourBank.AddAccount(new Account("Raz", 5000, new Address(4, 14, "Rangpur")));
            ourBank.AddAccount(new Account("Arif", 3000, new Address(7, 20, "Rajshahi")));
            ourBank.PrintAccountDetails();
            ourBank.DeleteAccount(2);
            ourBank.Transaction(2, 500, 2);
            Console.WriteLine("\n");
            ourBank.PrintAccountDetails();
            





        }
    }
}
