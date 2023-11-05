using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saving_Account
{
    public class Withdrow
    {
        public static void Saving_AccountWithdrow(double amount, double _balance)
        {
            if(amount > 0)
            {
                if (_balance - amount < 0)
                {
                    _balance -= 15;
                }
                else
                {
                    _balance -= amount;
                }
            }
                
        }
    }
}
