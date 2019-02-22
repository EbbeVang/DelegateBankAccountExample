using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBankAccountExample
{
    class Account
    {
        private int _balance;

        public delegate int Transaction(int amount);

        public Transaction Deposit;

        public Transaction Withdrawal;

        public Account()
        {
            Deposit = DepositNoAlerts;
            Withdrawal = WithdrawalStandard;
        }

        public bool ActivateMoneyLoundryAlert()
        {
            if (Deposit != DepositMoneyLaundryAlert)
            {
                Deposit = DepositMoneyLaundryAlert;
                return true;
            }
            else return false;
        }

        public bool DeactivateMoneyLoundryAlert()
        {
            if (Deposit == DepositMoneyLaundryAlert)
            {
                Deposit = DepositNoAlerts;
                return true;
            }
            return false;
        }


        // varianter til brug i mine delegates:
        private int DepositNoAlerts(int deposit)
        {
            Console.WriteLine("Deposit: " + deposit);
            _balance += deposit;
            return deposit;
        }

        private int DepositMoneyLaundryAlert(int deposit)
        {
            Console.WriteLine("Deposit: " + deposit);
            if (deposit >= 10000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!! MONEY LAUNDRY ALERT !!!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            _balance += deposit;
            return deposit;
        }

        private int WithdrawalStandard(int withdrawal)
        {
            _balance -= withdrawal;
            return withdrawal;
        }

        private int WithdrawalMax1000(int withdrawal)
        {
            if (withdrawal > 1000)
            {
                return 0;
            }
            else
            {
                _balance -= withdrawal;
                return withdrawal;
            }
        }

        private int WithdrawalDebit(int withdrawal)
        {
            if (_balance - withdrawal < 0)
            {
                return 0;
            }
            else
            {
                _balance -= withdrawal;
                return withdrawal;
            }
        }

        public int Balance
        {
            get { return _balance; }
        }
    }
}
