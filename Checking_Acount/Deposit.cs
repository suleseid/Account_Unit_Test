using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_Acount
{
    public class Deposit
    {
        public readonly double Balance;


        //private int _overdrraftCharge;
      
        public void Chacking_AccountDeposit(double amount, double _balance)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public void Chacking_AccountDeposit(double amountToDeposit)
        {
            throw new NotImplementedException();
        }
    }
}  
