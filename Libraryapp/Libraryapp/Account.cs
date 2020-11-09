using System;
using System.Collections.Generic;
using System.Text;

namespace Libraryapp
{
    class Account
    {
        private String accname;
        private String acid;
        private Double balance;

        public string AccName
        {
            get { return accname; }
            set { accname = value; }
        }
        public string AcId
        {
            get { return acid; }
            set { acid = value; }
        }
        public Double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public Account(string accname, string acid, int balance)
        {
            this.accname = accname;
            this.acid = acid;
            this.balance = balance;

        }

        public Double Deposit(Double amount)
        {
            balance = balance + amount;
            return balance;
        }

        public  Double Withdraw(Double amount)
        {
            balance = balance - amount;
            return balance;


        }
        public void Transfer(int amount, Account reciever)
        {
            this.balance -= amount;
            this.balance += amount;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Name :" + accname);
            Console.WriteLine("Account ID :" + acid);
            Console.WriteLine("Balance :" + balance);
        }


    }
}

