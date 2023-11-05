using System;

namespace Checking_Acount.Tests
{
    internal class Checking
    {
        public Checking(int v)
        {
        }

        public double Balance { get; internal set; }

        internal void Withdraw(double amountToWithdraw)
        {
            throw new NotImplementedException();
        }
    }
}