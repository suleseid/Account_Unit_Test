using System;

namespace Saving_Account.Tests
{
    internal class Saving
    {
        private int v;

        public Saving(int v)
        {
            this.v = v;
        }

        public double Balance { get; internal set; }

        internal void Withdraw(double amountToWithdraw)
        {
            throw new NotImplementedException();
        }
    }
}