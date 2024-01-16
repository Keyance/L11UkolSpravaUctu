using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace L11UkolSpravaUctu
{
    internal class Account
    {
        private string _accountNumber;
        public string AccountNumber 
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }

        private string _ownerName;
        public string OwnerName 
        {
            get
            {
                return _ownerName;
            }
            set
            {
                _ownerName = value;
            }
        }

        private decimal _balance;
        public decimal Balance 
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public void Deposit (decimal depositMoney)
        {
            Balance = Balance + depositMoney;
        }

        public void Withdraw (decimal amount)
        {
            if (amount < _balance)
            {
                _balance -= amount;
            } else
            { Console.WriteLine("Na účtu není dost peněz na tento výběr."); }
        }
    }
}
