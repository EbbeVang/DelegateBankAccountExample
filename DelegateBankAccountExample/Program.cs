using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBankAccountExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Account NikolajsAccount = new Account(); // no alarms attached

            Console.WriteLine(NikolajsAccount.Deposit(20000));
            Console.WriteLine("saldo: " + NikolajsAccount.Balance);

            Console.WriteLine(NikolajsAccount.ActivateMoneyLoundryAlert());
            
            Console.WriteLine(NikolajsAccount.Deposit(20000));
            Console.WriteLine("saldo: " + NikolajsAccount.Balance);

            Console.WriteLine(NikolajsAccount.DeactivateMoneyLoundryAlert());
            Console.WriteLine(NikolajsAccount.Deposit(20000));
            Console.WriteLine("saldo: " + NikolajsAccount.Balance);






        }
    }
}
