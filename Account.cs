using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Account
    {
        public int accountNumber=0;
        private string accountName;
        private double balance;
        private Address address;
        static int count = 1;
        public Account(string accountName, double balance, Address address)
        {
            accountNumber= count++;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        /*public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }*/

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public void Withdraw(double amount)
        {
            if(balance>amount)
            {
                Console.WriteLine(amount+" TK Withdraw succesfully.");
            }
            else
            {
                Console.WriteLine("You don't have enough blance.");
            }
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Your current balance is: " + balance);
        }
        public void Transfer(Account receiver, double amount)
        {
            if (balance > amount)
            {
                Console.WriteLine("Transfer succesfull. ");
            }
            else
            {
                Console.WriteLine("You don't have enough blance for Transfer.");
            }
        }
        public void ShowAccountInformation()
        {
            //Console.WriteLine("Account No:"+this.accountNumber+"\nAccount Name:"+this.accountName+"\nBalance:"+this.balance);
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", accountNumber, this.accountName, this.balance);
            Console.WriteLine(this.address.GetAddress());
        }
    }
}
