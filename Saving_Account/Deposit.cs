using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saving_Account
{
    public class Deposit
    {
        public double Balance;
        double _interst;
     

        public Deposit(double _balance)
        {
            
        }

        public double Interst
        {
            get { return _interst = 5.00; }
        }
        public static void Saving_AccountDeposit(double amount, double _balance)
        {
            if(amount > 0)
            {
                _balance += amount;
            }
        }

        public void Saving_AccountDeposit(double amountToDeposit)
        {
            throw new NotImplementedException();
        }
    }
}
