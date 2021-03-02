using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Bank
    {
        private string name;
        private Account[] accounts;
        public Bank(string name, int size)
        {
            this.name = name;
            accounts = new Account[size];
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public Account[] Accounts
        {
            set { this.accounts = value; }
            get { return this.accounts; }
        }


        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }
        /*public void SearchAccount(int accountNo)
        {
            int flag = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].accountNumber == accountNo)
                {
                    accounts[i].ShowAccountInformation();
                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;

                }
            }
            if (flag == 1)
                Console.WriteLine("Account Not Found");
        }*/
        public void DeleteAccount(int accountNo)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].accountNumber == accountNo)
                { 
                    accounts[i] = null;
                    Console.WriteLine("Account no: "+ accountNo + " deleted");
                    break;
                } 
            }
        }
        public void Transaction(int transactionType, double amount, int acountNo)
        {
            if (transactionType == 1)
            {
                Console.WriteLine(amount+ " TK Deposited in A/C: "+ acountNo); 
            }
            else if(transactionType == 2)
            {
                Console.WriteLine(amount + " TK Withdraw from: A / C: "+ acountNo); 
            }
            else if (transactionType == 3)
            {
                Console.WriteLine(amount + " TK Transferfrom from: A / C: " + acountNo);
            }
        }
        public void PrintAccountDetails()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].ShowAccountInformation();
            }
        }
    }
}
