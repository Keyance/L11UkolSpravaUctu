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
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException ("value", "Hodnota na účtu nemůže být menší než nula.");
                    }
                    else { _balance = value; }
                }
            }
        }

        public void Deposit (decimal depositMoney)
        {
            {
                if (depositMoney < 0)
                {
                    throw new ArgumentOutOfRangeException("depositMoney", "Na účet nemůže být vloženo negativní číslo.");
                }
                else
                {
                    Balance = Balance + depositMoney;
                }
            }
        }

        public void Withdraw (decimal amount)
        {
            {
                if (amount < _balance)
                {
                    if (amount < 0)
                    {
                        throw new ArgumentOutOfRangeException("amount", "Hodnota, kterou chceme oderat z účtu nemůže být menší než nula.");
                    }
                    else
                    {
                        _balance -= amount;
                    }
                }
                else
                { 
                    throw new ArgumentOutOfRangeException("amount", "Nemůže být vybráno více peněz, než je na účtu.");
                }
            }
        }
    }
}
