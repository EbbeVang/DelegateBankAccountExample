using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBankAccountExample
{
    class Account
    {
        private int _saldo;

        public delegate int Deposit(int deposit);

        public delegate int Withdrawal(int withdrawal);

        public Deposit AccountDeposit;

        public Withdrawal AccountWithdrawal;

        // varianter til brug i mine delegates:
        public int DepositNoAlerts(int deposit)
        {
            Console.WriteLine("Deposit: " + deposit);
            _saldo += deposit;
            return deposit;
        }

        public int DepositMoneyLaundryAlert(int deposit)
        {
            Console.WriteLine("Deposit: " + deposit);
            if (deposit >= 10000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!! MONEY LAUNDRY ALERT !!!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            _saldo += deposit;
            return deposit;
        }


        public int Saldo
        {
            get { return _saldo; }
        }
    }
}
