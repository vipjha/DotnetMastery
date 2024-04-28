using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public sealed class SealedClass
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            // Deposit implementation
        }

        public void Withdraw(decimal amount)
        {
            // Withdraw implementation
        }
    }

    public static class InheritSealedClass 
    {
        public static void InheritSealedClassMethod(this SealedClass sealedClass) 
        {
            Console.WriteLine(sealedClass.ToString());
        }

    }
}
