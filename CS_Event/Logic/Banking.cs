using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Event.Logic
{
    // 1. Declare delegate

    public delegate void TransactionHandler(decimal trAmt);


    internal class Banking
    {
        decimal _NetBalance;

        // 2. Define Events

        public event TransactionHandler OverBalance;
        public event TransactionHandler UnderBalance;

        public Banking(decimal netBalance)
        {
            _NetBalance = netBalance;
        }

        public void Deposit(decimal trAmt)
        {
            _NetBalance += trAmt;
            // 3. Raise Event Conditionally
            if (_NetBalance > 100000)
            {
                OverBalance(_NetBalance);
            }
        }

        public void Withdrawal(decimal trAmt)
        {
            _NetBalance -= trAmt;
            // 3. Raise Event Conditionally
            if (_NetBalance < 5000)
            {
                UnderBalance(_NetBalance);
            }
        }

        public decimal GetNetBalance() 
        {
            return _NetBalance;
        }
    }
}
